using System;
using System.Windows.Forms;

namespace ProcesoCita
{
    public partial class Prechequeo : Form
    {
        public Prechequeo()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO: METODO DE VERIFICACION CON LA BD
            throw new System.NotImplementedException();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string message = "¿Esta seguro de esta opcion?";
            string title = "Ventana de confirmacion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            System.Windows.Forms.DialogResult ventana = (MessageBox.Show(message, title, buttons));
            if (ventana == DialogResult.No)
            {
                this.Close();
            }
            else
            { 
                //mostrando elementos ocultos
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                dateTimePicker3.Visible = true;
                dateTimePicker4.Visible = true;
                dateTimePicker5.Visible = true;
                //Labels
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Regresar al menu principal
            Form MainMenu = new Form1();
            MainMenu.Show();
            //Cerrar esta form
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TODO: PUSHEAR FECHA Y HORA DE DATE TIME PICKER A LA BD
            throw new System.NotImplementedException();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string message = "¿Esta seguro de esta opcion?";
            string title = "Ventana de confirmacion";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            System.Windows.Forms.DialogResult ventana = (MessageBox.Show(message, title, buttons));
            if (ventana == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}