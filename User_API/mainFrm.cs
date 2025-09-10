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
using System.Security.Policy;
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
        string[,] rolesList;
        string[,] locationList;
        string appURL;

        public mainFrm()
        {
            InitializeComponent();
        }
        

        private void mainFrm_Load(object sender, EventArgs e)
        {
            addUserUI(false);

            fillUserIDComboBox("userIDs.cfg");

            loadBaseAPI("baseAPI.cfg");

            fillRolesComboBox("roles.cfg");
            fillLocationsComboBox("locations.cfg");


            //set version info
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = "User API " + version.ToString().Substring(0, 5);

        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            userLogout();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            userReset();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUserUI(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            addUserUI(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveNewUser();
        }
    }
}
