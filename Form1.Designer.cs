namespace Blood_Bank_Management_system
{
    partial class frmHome
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
            menuStripTop = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            panelFooter = new Panel();
            lblFootername = new Label();
            label1 = new Label();
            panelOPositive = new Panel();
            lblBloodGroup = new Label();
            menuStripTop.SuspendLayout();
            panelFooter.SuspendLayout();
            panelOPositive.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripTop
            // 
            menuStripTop.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStripTop.ImageScalingSize = new Size(20, 20);
            menuStripTop.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, donorsToolStripMenuItem });
            menuStripTop.Location = new Point(0, 0);
            menuStripTop.Name = "menuStripTop";
            menuStripTop.Padding = new Padding(6, 10, 0, 10);
            menuStripTop.Size = new Size(1135, 44);
            menuStripTop.TabIndex = 0;
            menuStripTop.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(70, 24);
            usersToolStripMenuItem.Text = "Users";
            // 
            // donorsToolStripMenuItem
            // 
            donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            donorsToolStripMenuItem.Size = new Size(85, 24);
            donorsToolStripMenuItem.Text = "Donors";
            // 
            // panelFooter
            // 
            panelFooter.BackColor = SystemColors.Control;
            panelFooter.Controls.Add(lblFootername);
            panelFooter.Controls.Add(label1);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 550);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1135, 60);
            panelFooter.TabIndex = 1;
            // 
            // lblFootername
            // 
            lblFootername.AutoSize = true;
            lblFootername.Font = new Font("Harrington", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFootername.Location = new Point(144, 32);
            lblFootername.Name = "lblFootername";
            lblFootername.Size = new Size(324, 24);
            lblFootername.TabIndex = 1;
            lblFootername.Text = "Blood Bank Management system";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Harrington", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(793, 32);
            label1.Name = "label1";
            label1.Size = new Size(272, 24);
            label1.TabIndex = 0;
            label1.Text = "Developed By Wanjie Ryan";
            // 
            // panelOPositive
            // 
            panelOPositive.BackColor = SystemColors.Control;
            panelOPositive.Controls.Add(lblBloodGroup);
            panelOPositive.Location = new Point(28, 74);
            panelOPositive.Name = "panelOPositive";
            panelOPositive.Size = new Size(200, 100);
            panelOPositive.TabIndex = 2;
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Font = new Font("Harrington", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBloodGroup.Location = new Point(14, 10);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(29, 20);
            lblBloodGroup.TabIndex = 3;
            lblBloodGroup.Text = "O+";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1135, 610);
            Controls.Add(panelOPositive);
            Controls.Add(panelFooter);
            Controls.Add(menuStripTop);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripTop;
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            panelOPositive.ResumeLayout(false);
            panelOPositive.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTop;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem donorsToolStripMenuItem;
        private Panel panelFooter;
        private Label label1;
        private Label lblFootername;
        private Panel panelOPositive;
        private Label lblBloodGroup;
    }
}
