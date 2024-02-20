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
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtPwd = new TextBox();
            lblPwd = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            txtAddress = new TextBox();
            lblUserAddress = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvUsers = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBCloseUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
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
            // txtUsername
            // 
            txtUsername.Location = new Point(195, 412);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(203, 31);
            txtUsername.TabIndex = 11;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 412);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 24);
            lblUsername.TabIndex = 10;
            lblUsername.Text = "User Name";
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(195, 467);
            txtPwd.MaxLength = 10;
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(203, 31);
            txtPwd.TabIndex = 13;
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Location = new Point(12, 467);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(97, 24);
            lblPwd.TabIndex = 12;
            lblPwd.Text = "Password";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(195, 522);
            txtContact.MaxLength = 10;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(203, 31);
            txtContact.TabIndex = 15;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(12, 522);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(77, 24);
            lblContact.TabIndex = 14;
            lblContact.Text = "Contact";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(195, 581);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(203, 73);
            txtAddress.TabIndex = 17;
            // 
            // lblUserAddress
            // 
            lblUserAddress.AutoSize = true;
            lblUserAddress.Location = new Point(12, 581);
            lblUserAddress.Name = "lblUserAddress";
            lblUserAddress.Size = new Size(85, 24);
            lblUserAddress.TabIndex = 16;
            lblUserAddress.Text = "Address";
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(463, 616);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 38);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.System;
            btnUpdate.Location = new Point(577, 616);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 38);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Location = new Point(692, 616);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 38);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatStyle = FlatStyle.System;
            btnClear.Location = new Point(807, 616);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 38);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(498, 301);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(521, 275);
            dgvUsers.TabIndex = 22;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(498, 239);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(72, 24);
            lblSearch.TabIndex = 23;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(621, 239);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(398, 31);
            txtSearch.TabIndex = 24;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1100, 700);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvUsers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(lblUserAddress);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtPwd);
            Controls.Add(lblPwd);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
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
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
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
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtPwd;
        private Label lblPwd;
        private TextBox txtContact;
        private Label lblContact;
        private TextBox txtAddress;
        private Label lblUserAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvUsers;
        private Label lblSearch;
        private TextBox txtSearch;
    }
}