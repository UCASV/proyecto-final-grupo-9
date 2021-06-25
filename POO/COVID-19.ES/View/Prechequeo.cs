using System;
using System.Windows.Forms;

namespace COVID_19.ES
{
    public partial class Prechequeo : Form
    {
        public Prechequeo()
        {
            InitializeComponent();
        }

        private void check_yes_CheckedChanged(object sender, EventArgs e)
        {
            //IF PARA QUE NO SE REPITA EL MENSAJE DE CONFIRMACION CUANDO SE RESETEA 
            if (Count == 0)
            {
                string message = "¿Esta seguro de esta opcion?";
                string title = "Ventana de confirmacion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                System.Windows.Forms.DialogResult ventana = (MessageBox.Show(message, title, buttons));
                if (ventana == DialogResult.Yes)
                {
                    //mostrando elementos ocultos
                    label4.Visible = true;
                    label5.Visible = true;
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Visible = true;
                    dateTimePicker3.Visible = true;
                    dateTimePicker4.Visible = true;
                }
                else
                {
                    ++Count;
                    checkBox1.Checked = false;
                }
            }        
        }

        public int Count=0;
        private void check_No_CheckedChanged(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                string message = "¿Esta seguro de esta opcion?";
                string title = "Ventana de confirmacion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                System.Windows.Forms.DialogResult ventana = (MessageBox.Show(message, title, buttons));
                if (ventana == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    ++Count;
                    checkBox2.Checked = false;
                } 
            }
        }
    }
}