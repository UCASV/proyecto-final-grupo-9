using System;
using System.Linq;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;

namespace COVID_19.ES
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            int x = ignore.data;
            
            var db = new Vaccination_ManagementContext(); //Busca ID
            var ID = db.Managers.Where(
                U => U.Id.Equals(x)
            ).ToList();

            label7.Text = ID[0].Id.ToString();
            label8.Text = ID[0].Name;
            label9.Text = ID[0].InstitutionalMail;
            label10.Text = ID[0].HomeDirection;
            label13.Text = ID[0].EmployeeType;
            label15.Text = ignore.dataC.ToString();

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
            Charts sign = new Charts();
            sign.ShowDialog();
        }
    }
}