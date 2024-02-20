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
            lblFormTitle = new Label();
            PBCloseUser = new PictureBox();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBCloseUser).BeginInit();
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
            // users
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1100, 500);
            Controls.Add(panelTop);
            Font = new Font("Harrington", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "users";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBCloseUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private PictureBox PBCloseUser;
        private Label lblFormTitle;
    }
}