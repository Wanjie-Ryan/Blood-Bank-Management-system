namespace Blood_Bank_Management_system
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            // this.Close completely terminates the program
            this.Close();

            // this.Hide just hides the program, but the program is still running in the background
            //this.Hide();
        }
    }
}
