using System;
using System.Windows.Forms;

namespace COVID_19.ES
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Precheking_Click(object sender, EventArgs e)
        {
            Prechequeo cheking = new Prechequeo();
            cheking.ShowDialog();
            this.Close();
        }

        private void DateProces_Click(object sender, EventArgs e)
        {
            AppointmentProcess date = new AppointmentProcess();
            date.ShowDialog();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            SignIn sign = new SignIn();
            sign.ShowDialog();
        }
    }
}