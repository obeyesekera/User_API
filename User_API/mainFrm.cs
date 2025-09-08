using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace User_API
{
    public partial class mainFrm : Form
    {
        
        string[,] userList;
        string[,] urlList;
        string appURL;

        public mainFrm()
        {
            InitializeComponent();
        }



        private async void DoPATCH(string userID, string URL, string endPoint)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("PATCH"), URL + "/resetLoggedUser?email=" + userID))
                    {
                        var response = await httpClient.SendAsync(request);

                        string result = await response.Content.ReadAsStringAsync();

                        var logoutResponse = JsonSerializer.Deserialize<httpResponse>(result);

                        MessageBox.Show(logoutResponse?.message ?? "No message received");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void mainFrm_Load(object sender, EventArgs e)
        {

            fillUserIDComboBox("userIDs.cfg");

            loadBaseAPI("baseAPI.cfg");

            //set version info
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = "User API " + version.ToString().Substring(0, 5);

        }


        private static readonly Regex sWhitespace = new Regex(@"\s+");
        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }


        private void fillUserIDComboBox(string cfgFile)
        {
            userList = readComboCfg(cfgFile, 1);

            for (int i = 0; i < userList.GetLength(0); i++)
            {
                cmbUserID.Items.Add(userList[i, 0]);
            }

            cmbUserID.SelectedIndex = 0;
        }

        private void loadBaseAPI(string cfgFile)
        {
            urlList = readComboCfg(cfgFile, 1);

            for (int i = 0; i < urlList.GetLength(0); i++)
            {
                appURL = urlList[i, 0];
                lblURL.Text = appURL;
            }

        }

        private string[,] readComboCfg(string cfgName, int cfgParam)
        {

            int parmCount = cfgParam;
            string[] lineOfContents = File.ReadAllLines(cfgName);
            string[,] cfgContents = new string[lineOfContents.Length, parmCount];
            int i = 0;
            foreach (var line in lineOfContents)
            {
                string[] parVals = line.Split(',');


                for (int j = 0; j < parmCount; j++)
                {
                    cfgContents[i, j] = parVals[j].Trim();
                }

                i++;
            }

            return cfgContents;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string userID = cmbUserID.SelectedItem.ToString();

            DoPATCH(userID, appURL, "/resetLoggedUser?email=");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string userID = cmbUserID.SelectedItem.ToString();

            DoPATCH(userID, appURL, "/resetLocked?email=");
        }
    }
}
