
namespace User_API
{
    partial class mainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            cmbUserID = new System.Windows.Forms.ComboBox();
            btnLogout = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            lblURL = new System.Windows.Forms.Label();
            btnAddUser = new System.Windows.Forms.Button();
            cmbRole = new System.Windows.Forms.ComboBox();
            cmbLocation = new System.Windows.Forms.ComboBox();
            txtGivenName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cmbUserID
            // 
            cmbUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbUserID.FormattingEnabled = true;
            cmbUserID.Location = new System.Drawing.Point(12, 12);
            cmbUserID.Name = "cmbUserID";
            cmbUserID.Size = new System.Drawing.Size(299, 23);
            cmbUserID.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogout.ForeColor = System.Drawing.Color.Green;
            btnLogout.Location = new System.Drawing.Point(360, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new System.Drawing.Size(75, 59);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnReset.ForeColor = System.Drawing.Color.Red;
            btnReset.Location = new System.Drawing.Point(360, 90);
            btnReset.Name = "btnReset";
            btnReset.Size = new System.Drawing.Size(75, 59);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new System.Drawing.Point(12, 226);
            lblURL.Name = "lblURL";
            lblURL.Size = new System.Drawing.Size(52, 15);
            lblURL.TabIndex = 3;
            lblURL.Text = "baseURL";
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddUser.ForeColor = System.Drawing.Color.Blue;
            btnAddUser.Location = new System.Drawing.Point(360, 179);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new System.Drawing.Size(75, 59);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new System.Drawing.Point(12, 58);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new System.Drawing.Size(299, 23);
            cmbRole.TabIndex = 5;
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new System.Drawing.Point(12, 90);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new System.Drawing.Size(299, 23);
            cmbLocation.TabIndex = 6;
            // 
            // txtGivenName
            // 
            txtGivenName.Location = new System.Drawing.Point(12, 126);
            txtGivenName.Name = "txtGivenName";
            txtGivenName.Size = new System.Drawing.Size(132, 23);
            txtGivenName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(150, 126);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(161, 23);
            txtLastName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(12, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(299, 23);
            txtEmail.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(236, 184);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(155, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // mainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(447, 250);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtGivenName);
            Controls.Add(cmbLocation);
            Controls.Add(cmbRole);
            Controls.Add(btnAddUser);
            Controls.Add(lblURL);
            Controls.Add(btnReset);
            Controls.Add(btnLogout);
            Controls.Add(cmbUserID);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainFrm";
            Text = "User API";
            Load += mainFrm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtGivenName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

