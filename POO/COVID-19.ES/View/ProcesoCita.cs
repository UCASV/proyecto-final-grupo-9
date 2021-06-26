using System;
using System.Windows.Forms;

namespace COVID_19.ES
{
    public partial class ProcesoCita : Form
    {
        public ProcesoCita()
        {
            InitializeComponent();
        }

        private void bttn_ApointProcess_Click(object sender, EventArgs e)
        {
            //TODO: INGRESAR DATOS DE TextBoxes A BD
        }

        private void bttnback_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }
    }
}