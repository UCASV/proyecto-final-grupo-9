using System;
using System.Windows.Forms;

namespace ProcesoCita
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Regresar al menu principal
            Form MainMenu = new Form1();
            MainMenu.Show();
            //Cerrar esta form
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
            //TODO: INGRESAR DATOS DE TextBoxes A BD
        }
    }
}