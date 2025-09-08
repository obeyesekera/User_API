
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
            btnReset.Text = "PW Reset";
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
            // mainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(447, 250);
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
    }
}

