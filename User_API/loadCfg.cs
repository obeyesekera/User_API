using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace User_API
{
    public partial class mainFrm
    {

        private void fillUserIDComboBox(string cfgFile)
        {
            userList = readComboCfg(cfgFile, 1);

            for (int i = 0; i < userList.GetLength(0); i++)
            {
                cmbUserID.Items.Add(userList[i, 0]);
            }

            cmbUserID.SelectedIndex = 0;
        }

        private void fillRolesComboBox(string cfgFile)
        {
            rolesList = readComboCfg(cfgFile, 2);

            for (int i = 0; i < rolesList.GetLength(0); i++)
            {
                cmbRole.Items.Add(rolesList[i, 1]);
            }

            cmbRole.SelectedIndex = 0;
        }

        private void fillLocationsComboBox(string cfgFile)
        {
            locationList = readComboCfg(cfgFile, 2);

            for (int i = 0; i < locationList.GetLength(0); i++)
            {
                cmbLocation.Items.Add(locationList[i, 1]);
            }

            cmbLocation.SelectedIndex = 0;
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

    }
}
