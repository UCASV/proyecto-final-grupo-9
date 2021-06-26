using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;

namespace COVID_19.ES
{
    public partial class Prechequeo : Form
    {
        public Prechequeo()
        {
            InitializeComponent();
            datePickerSystem.Value = DateTime.Now;
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

        private void bttn_Verifydata_Click(object sender, EventArgs e)
        {
            var db = new Vaccination_ManagementContext();
            List<Appointment1> apointdate = db.Appointment1s
                .OrderBy(c => c.Id).ToList();
            
            List<Citizen> save = db.Citizens
                .OrderBy(c => c.Dui).ToList();
            
            for (int i = 0; i < save.Count; i++)
            {
                if (Int32.Parse(textBox1.Text) == save[i].Dui && datePickerSystem.Value == apointdate[i].DateTime)
                {
                    MessageBox.Show("El usuario esta registrado para vacunacion",
                        "Verificador");
                }
                else if (Int32.Parse(textBox1.Text) == save[i].Dui && datePickerSystem.Value != apointdate[i].DateTime)
                {
                    MessageBox.Show("El usuario se encuetra registrado pero la fecha no corresponde a su cita",
                        "Verificador");
                }
                else
                {
                    MessageBox.Show("No esta registrado", "Verificador");
                }
            }
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int protoId = 0;
            var db = new Vaccination_ManagementContext();
            List<Dose1> DoseOneList = db.Dose1s.ToList();
            Dose1 FirstDosage = new Dose1(++protoId, dateTimePicker2.Value, Int32.Parse(textBox1.Text));
            db.Add(FirstDosage);     
            db.SaveChanges();
            
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            int fg = 0;
            var db = new Vaccination_ManagementContext();
            List<Dose2> doseTwoList = db.Dose2s.ToList();
            
            DateTime dateSecondvax = dateTimePicker2.Value.AddDays(50);
            Dose2 secondDosage = new Dose2(++fg, dateSecondvax,Int32.Parse(textBox1.Text));
            MessageBox.Show("Segunda dosis dentro de 50 dias, cita registrada para" + dateSecondvax, "Segunda dosis");
            
            TimeSpan diferenciaDeHora = dateTimePicker3.Value - dateTimePicker4.Value; 
            if (diferenciaDeHora >= TimeSpan.FromMinutes(30))
            {
                MessageBox.Show("EL TIEMPO DE ESPERA SUPERO LA MARCA DE TOLERANCIA DE 30 MINUTOS",
                    "ADVERTENCIA DE PRODUCTIVIDAD",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            /*
             var db = new Vaccination_ManagementContext();
            List<Dose1> DoseOneList = db.Dose1s.ToList();
            Dose1 FirstDosage = new Dose1(++protoId, dateTimePicker2.Value, Int32.Parse(textBox1.Text));
            db.Add(FirstDosage);     
            db.SaveChanges();
             */
        }
        //TODO: terminar funcion "secondDosage" para pushear a db
    }
}