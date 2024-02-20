namespace Blood_Bank_Management_system.UI
{
    partial class users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            panelTop = new Panel();
            PBCloseUser = new PictureBox();
            lblFormTitle = new Label();
            lblProfPic = new Label();
            pbProfPic = new PictureBox();
            btnSelectImage = new Button();
            lblFullname = new Label();
            txtFullname = new TextBox();
            txtUsermail = new TextBox();
            lblUserEmail = new Label();
            txtUserID = new TextBox();
            lblUserId = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBCloseUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfPic).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.WindowFrame;
            panelTop.Controls.Add(PBCloseUser);
            panelTop.Controls.Add(lblFormTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 80);
            panelTop.TabIndex = 0;
            // 
            // PBCloseUser
            // 
            PBCloseUser.Image = (Image)resources.GetObject("PBCloseUser.Image");
            PBCloseUser.Location = new Point(1021, 12);
            PBCloseUser.Name = "PBCloseUser";
            PBCloseUser.Size = new Size(48, 42);
            PBCloseUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PBCloseUser.TabIndex = 1;
            PBCloseUser.TabStop = false;
            PBCloseUser.Click += PBCloseUser_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Harrington", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFormTitle.Location = new Point(392, 19);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(214, 35);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Manage Users";
            // 
            // lblProfPic
            // 
            lblProfPic.AutoSize = true;
            lblProfPic.Location = new Point(12, 110);
            lblProfPic.Name = "lblProfPic";
            lblProfPic.Size = new Size(136, 24);
            lblProfPic.TabIndex = 1;
            lblProfPic.Text = "Profile Picture";
            // 
            // pbProfPic
            // 
            pbProfPic.Location = new Point(195, 110);
            pbProfPic.Name = "pbProfPic";
            pbProfPic.Size = new Size(156, 80);
            pbProfPic.TabIndex = 2;
            pbProfPic.TabStop = false;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Cursor = Cursors.Hand;
            btnSelectImage.FlatStyle = FlatStyle.System;
            btnSelectImage.Location = new Point(375, 153);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(137, 37);
            btnSelectImage.TabIndex = 3;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            // 
            // lblFullname
            // 
            lblFullname.AutoSize = true;
            lblFullname.Location = new Point(12, 239);
            lblFullname.Name = "lblFullname";
            lblFullname.Size = new Size(97, 24);
            lblFullname.TabIndex = 4;
            lblFullname.Text = "Full Name";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(195, 239);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(203, 31);
            txtFullname.TabIndex = 5;
            // 
            // txtUsermail
            // 
            txtUsermail.Location = new Point(195, 357);
            txtUsermail.Name = "txtUsermail";
            txtUsermail.Size = new Size(203, 31);
            txtUsermail.TabIndex = 7;
            // 
            // lblUserEmail
            // 
            lblUserEmail.AutoSize = true;
            lblUserEmail.Location = new Point(12, 357);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(59, 24);
            lblUserEmail.TabIndex = 6;
            lblUserEmail.Text = "Email";
            // 
            // txtUserID
            // 
            txtUserID.Cursor = Cursors.No;
            txtUserID.Location = new Point(195, 301);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(203, 31);
            txtUserID.TabIndex = 9;
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(12, 301);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(75, 24);
            lblUserId.TabIndex = 8;
            lblUserId.Text = "User ID";
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1100, 500);
            Controls.Add(txtUserID);
            Controls.Add(lblUserId);
            Controls.Add(txtUsermail);
            Controls.Add(lblUserEmail);
            Controls.Add(txtFullname);
            Controls.Add(lblFullname);
            Controls.Add(btnSelectImage);
            Controls.Add(pbProfPic);
            Controls.Add(lblProfPic);
            Controls.Add(panelTop);
            Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "users";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBCloseUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private PictureBox PBCloseUser;
        private Label lblFormTitle;
        private Label lblProfPic;
        private PictureBox pbProfPic;
        private Button btnSelectImage;
        private Label lblFullname;
        private TextBox txtFullname;
        private TextBox txtUsermail;
        private Label lblUserEmail;
        private TextBox txtUserID;
        private Label lblUserId;
    }
}