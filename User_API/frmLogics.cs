using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;

namespace User_API
{
    public partial class mainFrm
    {

        private void addUserUI(bool enabled)
        {

            if (enabled)
            {
                cmbUserID.Enabled = false;
                btnReset.Enabled = false;
                btnLogout.Enabled = false;
                btnAddUser.Enabled = false;

                cmbRole.Visible = true;
                cmbLocation.Visible = true;
                txtGivenName.PlaceholderText = "Given Name";
                txtGivenName.Visible = true;
                //txtGivenName.Text = "Test";
                txtLastName.PlaceholderText = "Last Name";
                txtLastName.Visible = true;
                //txtLastName.Text = "User";
                txtEmail.PlaceholderText = "Email";
                txtEmail.Visible = true;
                //txtEmail.Text = "test.user@example.com";
                btnSave.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                cmbUserID.Enabled = true;
                btnReset.Enabled = true;
                btnLogout.Enabled = true;
                btnAddUser.Enabled = true;

                cmbRole.Visible = false;
                cmbLocation.Visible = false;
                txtGivenName.Visible = false;
                txtLastName.Visible = false;
                txtEmail.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
            }

        }


        private static readonly Regex sWhitespace = new Regex(@"\s+");
        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }

        private void userLogout()
        {
            string userID = cmbUserID.SelectedItem.ToString();
            DoPATCH(userID, appURL, "/user-mgt-service/auth/v1/resetLoggedUser?email=");
        }

        private void userReset()
        {
            string userID = cmbUserID.SelectedItem.ToString();
            DoPATCH(userID, appURL, "/user-mgt-service/auth/v1/resetLocked?email=");
        }

        private void saveNewUser()
        {
            string givenName = ReplaceWhitespace(txtGivenName.Text.Trim(), " ");
            string lastName = ReplaceWhitespace(txtLastName.Text.Trim(), " ");
            string email = txtEmail.Text.Trim();
            string role = rolesList[cmbRole.SelectedIndex, 0];
            string location = locationList[cmbLocation.SelectedIndex, 0];
            DoPOST(email, givenName, lastName, role, location, appURL, "/user-mgt-service/users/v1");
        }

    }
}
