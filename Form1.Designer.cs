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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            menuStripTop = new MenuStrip();
            usersToolStripMenuItem = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            panelFooter = new Panel();
            lblFootername = new Label();
            label1 = new Label();
            panelOPositive = new Panel();
            lblDonors = new Label();
            lblPositiveCount = new Label();
            lblBloodGroup = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblOnegativecount = new Label();
            lblONegative = new Label();
            panel2 = new Panel();
            label5 = new Label();
            lblANegCount = new Label();
            lblAnegative = new Label();
            panel3 = new Panel();
            label8 = new Label();
            lblApositiveCount = new Label();
            lblAPositive = new Label();
            panel4 = new Panel();
            label11 = new Label();
            lblABPosCount = new Label();
            lblABPos = new Label();
            panel5 = new Panel();
            label14 = new Label();
            lblABNegCount = new Label();
            lblABNeg = new Label();
            panel6 = new Panel();
            label17 = new Label();
            lblBNegCount = new Label();
            lblBnegative = new Label();
            panel7 = new Panel();
            label20 = new Label();
            lblBposCount = new Label();
            lblBpos = new Label();
            dgvDonors = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            pictureBoxClose = new PictureBox();
            menuStripTop.SuspendLayout();
            panelFooter.SuspendLayout();
            panelOPositive.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
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
            panelOPositive.Controls.Add(lblDonors);
            panelOPositive.Controls.Add(lblPositiveCount);
            panelOPositive.Controls.Add(lblBloodGroup);
            panelOPositive.Location = new Point(25, 60);
            panelOPositive.Name = "panelOPositive";
            panelOPositive.Size = new Size(200, 100);
            panelOPositive.TabIndex = 2;
            // 
            // lblDonors
            // 
            lblDonors.AutoSize = true;
            lblDonors.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDonors.ForeColor = Color.FromArgb(226, 76, 58);
            lblDonors.Location = new Point(96, 59);
            lblDonors.Name = "lblDonors";
            lblDonors.Size = new Size(81, 24);
            lblDonors.TabIndex = 4;
            lblDonors.Text = "Donors";
            // 
            // lblPositiveCount
            // 
            lblPositiveCount.AutoSize = true;
            lblPositiveCount.Font = new Font("Harrington", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPositiveCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblPositiveCount.Location = new Point(116, 13);
            lblPositiveCount.Name = "lblPositiveCount";
            lblPositiveCount.Size = new Size(37, 40);
            lblPositiveCount.TabIndex = 3;
            lblPositiveCount.Text = "0";
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Font = new Font("Harrington", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBloodGroup.ForeColor = Color.FromArgb(226, 76, 58);
            lblBloodGroup.Location = new Point(3, 31);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(70, 52);
            lblBloodGroup.TabIndex = 3;
            lblBloodGroup.Text = "O+";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblOnegativecount);
            panel1.Controls.Add(lblONegative);
            panel1.Location = new Point(265, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(226, 76, 58);
            label2.Location = new Point(96, 59);
            label2.Name = "label2";
            label2.Size = new Size(81, 24);
            label2.TabIndex = 4;
            label2.Text = "Donors";
            // 
            // lblOnegativecount
            // 
            lblOnegativecount.AutoSize = true;
            lblOnegativecount.Font = new Font("Harrington", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOnegativecount.ForeColor = Color.FromArgb(226, 76, 58);
            lblOnegativecount.Location = new Point(116, 13);
            lblOnegativecount.Name = "lblOnegativecount";
            lblOnegativecount.Size = new Size(37, 40);
            lblOnegativecount.TabIndex = 3;
            lblOnegativecount.Text = "0";
            // 
            // lblONegative
            // 
            lblONegative.AutoSize = true;
            lblONegative.Font = new Font("Harrington", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblONegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblONegative.Location = new Point(3, 31);
            lblONegative.Name = "lblONegative";
            lblONegative.Size = new Size(69, 52);
            lblONegative.TabIndex = 3;
            lblONegative.Text = "O-";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblANegCount);
            panel2.Controls.Add(lblAnegative);
            panel2.Location = new Point(265, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(226, 76, 58);
            label5.Location = new Point(96, 59);
            label5.Name = "label5";
            label5.Size = new Size(81, 24);
            label5.TabIndex = 4;
            label5.Text = "Donors";
            // 
            // lblANegCount
            // 
            lblANegCount.AutoSize = true;
            lblANegCount.Font = new Font("Harrington", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblANegCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblANegCount.Location = new Point(116, 13);
            lblANegCount.Name = "lblANegCount";
            lblANegCount.Size = new Size(37, 40);
            lblANegCount.TabIndex = 3;
            lblANegCount.Text = "0";
            // 
            // lblAnegative
            // 
            lblAnegative.AutoSize = true;
            lblAnegative.Font = new Font("Harrington", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAnegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblAnegative.Location = new Point(3, 31);
            lblAnegative.Name = "lblAnegative";
            lblAnegative.Size = new Size(73, 52);
            lblAnegative.TabIndex = 3;
            lblAnegative.Text = "A-";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblApositiveCount);
            panel3.Controls.Add(lblAPositive);
            panel3.Location = new Point(28, 181);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(226, 76, 58);
            label8.Location = new Point(96, 59);
            label8.Name = "label8";
            label8.Size = new Size(81, 24);
            label8.TabIndex = 4;
            label8.Text = "Donors";
            // 
            // lblApositiveCount
            // 
            lblApositiveCount.AutoSize = true;
            lblApositiveCount.Font = new Font("Harrington", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApositiveCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblApositiveCount.Location = new Point(116, 13);
            lblApositiveCount.Name = "lblApositiveCount";
            lblApositiveCount.Size = new Size(37, 40);
            lblApositiveCount.TabIndex = 3;
            lblApositiveCount.Text = "0";
            // 
            // lblAPositive
            // 
            lblAPositive.AutoSize = true;
            lblAPositive.Font = new Font("Harrington", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAPositive.ForeColor = Color.FromArgb(226, 76, 58);
            lblAPositive.Location = new Point(3, 31);
            lblAPositive.Name = "lblAPositive";
            lblAPositive.Size = new Size(74, 52);
            lblAPositive.TabIndex = 3;
            lblAPositive.Text = "A+";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblABPosCount);
            panel4.Controls.Add(lblABPos);
            panel4.Location = new Point(28, 433);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(226, 76, 58);
            label11.Location = new Point(96, 59);
            label11.Name = "label11";
            label11.Size = new Size(81, 24);
            label11.TabIndex = 4;
            label11.Text = "Donors";
            // 
            // lblABPosCount
            // 
            lblABPosCount.AutoSize = true;
            lblABPosCount.Font = new Font("Harrington", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblABPosCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblABPosCount.Location = new Point(116, 13);
            lblABPosCount.Name = "lblABPosCount";
            lblABPosCount.Size = new Size(37, 40);
            lblABPosCount.TabIndex = 3;
            lblABPosCount.Text = "0";
            // 
            // lblABPos
            // 
            lblABPos.AutoSize = true;
            lblABPos.Font = new Font("Harrington", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblABPos.ForeColor = Color.FromArgb(226, 76, 58);
            lblABPos.Location = new Point(3, 31);
            lblABPos.Name = "lblABPos";
            lblABPos.Size = new Size(105, 52);
            lblABPos.TabIndex = 3;
            lblABPos.Text = "AB+";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label14);
            panel5.Controls.Add(lblABNegCount);
            panel5.Controls.Add(lblABNeg);
            panel5.Location = new Point(265, 433);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(226, 76, 58);
            label14.Location = new Point(96, 59);
            label14.Name = "label14";
            label14.Size = new Size(81, 24);
            label14.TabIndex = 4;
            label14.Text = "Donors";
            // 
            // lblABNegCount
            // 
            lblABNegCount.AutoSize = true;
            lblABNegCount.Font = new Font("Harrington", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblABNegCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblABNegCount.Location = new Point(116, 13);
            lblABNegCount.Name = "lblABNegCount";
            lblABNegCount.Size = new Size(37, 40);
            lblABNegCount.TabIndex = 3;
            lblABNegCount.Text = "0";
            // 
            // lblABNeg
            // 
            lblABNeg.AutoSize = true;
            lblABNeg.Font = new Font("Harrington", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblABNeg.ForeColor = Color.FromArgb(226, 76, 58);
            lblABNeg.Location = new Point(3, 31);
            lblABNeg.Name = "lblABNeg";
            lblABNeg.Size = new Size(104, 52);
            lblABNeg.TabIndex = 3;
            lblABNeg.Text = "AB-";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(label17);
            panel6.Controls.Add(lblBNegCount);
            panel6.Controls.Add(lblBnegative);
            panel6.Location = new Point(265, 312);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(226, 76, 58);
            label17.Location = new Point(96, 59);
            label17.Name = "label17";
            label17.Size = new Size(81, 24);
            label17.TabIndex = 4;
            label17.Text = "Donors";
            // 
            // lblBNegCount
            // 
            lblBNegCount.AutoSize = true;
            lblBNegCount.Font = new Font("Harrington", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBNegCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblBNegCount.Location = new Point(116, 13);
            lblBNegCount.Name = "lblBNegCount";
            lblBNegCount.Size = new Size(37, 40);
            lblBNegCount.TabIndex = 3;
            lblBNegCount.Text = "0";
            // 
            // lblBnegative
            // 
            lblBnegative.AutoSize = true;
            lblBnegative.Font = new Font("Harrington", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBnegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblBnegative.Location = new Point(3, 31);
            lblBnegative.Name = "lblBnegative";
            lblBnegative.Size = new Size(70, 52);
            lblBnegative.TabIndex = 3;
            lblBnegative.Text = "B-";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(label20);
            panel7.Controls.Add(lblBposCount);
            panel7.Controls.Add(lblBpos);
            panel7.Location = new Point(25, 312);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 100);
            panel7.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Harrington", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(226, 76, 58);
            label20.Location = new Point(96, 59);
            label20.Name = "label20";
            label20.Size = new Size(81, 24);
            label20.TabIndex = 4;
            label20.Text = "Donors";
            // 
            // lblBposCount
            // 
            lblBposCount.AutoSize = true;
            lblBposCount.Font = new Font("Harrington", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBposCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblBposCount.Location = new Point(116, 13);
            lblBposCount.Name = "lblBposCount";
            lblBposCount.Size = new Size(37, 40);
            lblBposCount.TabIndex = 3;
            lblBposCount.Text = "0";
            // 
            // lblBpos
            // 
            lblBpos.AutoSize = true;
            lblBpos.Font = new Font("Harrington", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBpos.ForeColor = Color.FromArgb(226, 76, 58);
            lblBpos.Location = new Point(3, 31);
            lblBpos.Name = "lblBpos";
            lblBpos.Size = new Size(71, 52);
            lblBpos.TabIndex = 3;
            lblBpos.Text = "B+";
            // 
            // dgvDonors
            // 
            dgvDonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonors.Location = new Point(595, 107);
            dgvDonors.Name = "dgvDonors";
            dgvDonors.RowHeadersWidth = 51;
            dgvDonors.Size = new Size(528, 358);
            dgvDonors.TabIndex = 11;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Harrington", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(585, 60);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(162, 27);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search Donor";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Harrington", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(763, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(360, 29);
            txtSearch.TabIndex = 13;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = SystemColors.Control;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1073, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(28, 24);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 14;
            pictureBoxClose.TabStop = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1135, 610);
            Controls.Add(pictureBoxClose);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDonors);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
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
        private Label lblDonors;
        private Label lblPositiveCount;
        private Panel panel1;
        private Label label2;
        private Label lblOnegativecount;
        private Label lblONegative;
        private Panel panel2;
        private Label label5;
        private Label lblANegCount;
        private Label lblAnegative;
        private Panel panel3;
        private Label label8;
        private Label lblApositiveCount;
        private Label lblAPositive;
        private Panel panel4;
        private Label label11;
        private Label lblABPosCount;
        private Label lblABPos;
        private Panel panel5;
        private Label label14;
        private Label lblABNegCount;
        private Label lblABNeg;
        private Panel panel6;
        private Label label17;
        private Label lblBNegCount;
        private Label lblBnegative;
        private Panel panel7;
        private Label label20;
        private Label lblBposCount;
        private Label lblBpos;
        private DataGridView dgvDonors;
        private Label lblSearch;
        private TextBox txtSearch;
        private PictureBox pictureBoxClose;
    }
}
