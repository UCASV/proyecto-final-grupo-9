using System;
using System.Collections.Generic;
using System.Drawing;
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

        public int Count=0;
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
                    ++Count;
                    check_No.Checked = false;
                }
                else
                {
                    ++Count;
                    check_yes.Checked = false;
                }
            }        
        }
        
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
                    check_yes.Checked = false;
                } 
            }
        }

        //TODO: Boton de retroceso.
        private void bttnback_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }
        
        //Busqueda por DUI en el sistema de appointment
        private void bttn_Verifydata_Click(object sender, EventArgs e)
        {
            var db = new Vaccination_ManagementContext();
            List<Appointment1> apointDateList = db.Appointment1s
                .OrderBy(c => c.Id).ToList();
            
            List<Citizen> citizenlList = db.Citizens
                .OrderBy(c => c.Dui).ToList();
            
            for (int i = 0; i < citizenlList.Count; i++)
            {
                if (Int32.Parse(textBox1.Text) == citizenlList[i].Dui)
                {
                    if (datePickerSystem.Value == apointDateList[i].DateTime)
                    {
                        MessageBox.Show("El usuario esta registrado para vacunacion",
                            "Verificador");
                    }
                    else if(datePickerSystem.Value != apointDateList[i].DateTime)
                    {
                        MessageBox.Show("El usuario se encuetra registrado pero la fecha no corresponde a su cita",
                            "Verificador");
                        
                    }
                    
                }
                else
                {
                    int flag = 0;
                    flag++;
                    if (flag == citizenlList.Count)
                    {
                        MessageBox.Show("No esta registrado", "Verificador");
                    }
                }
            }
            
        }
        
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var db = new Vaccination_ManagementContext();
            List<Dose1> DoseOneList = db.Dose1s.ToList();
            
            //para verificar Que el DUI no se repita
            var dataEntered = DoseOneList.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();

            if (dataEntered.Count == 0)
            {
                Dose1 firstDosage = new Dose1(dateTimePicker2.Value, Int32.Parse(textBox1.Text));
                db.Add(firstDosage);     
                db.SaveChanges();
            }

        }
        
        //advertencia de mala gestion
        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            
            TimeSpan diferenciaDeHora = dateTimePicker3.Value - dateTimePicker4.Value; 
            if (diferenciaDeHora >= TimeSpan.FromMinutes(30))
            {
                MessageBox.Show("EL TIEMPO DE ESPERA SUPERO LA MARCA DE TOLERANCIA DE 30 MINUTOS",
                    "ADVERTENCIA DE PRODUCTIVIDAD",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        //Aparicion de campos para introducir efectos secundarios
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelSym.Visible = true;
            labelTime.Visible = true;
            secondAppointment.Location = new Point(186, 355);
        }
        
        //Generar segunda cita
        private void secondAppointment_Click(object sender, EventArgs e)
        {
            var db = new Vaccination_ManagementContext();
            DateTime dateSecondVax = dateTimePicker2.Value.AddDays(50);
            Appointment2 secondDosage = new Appointment2(dateSecondVax,"Hospital El Salvador",Int32.Parse(textBox1.Text));
            MessageBox.Show("Segunda dosis dentro de 50 dias, cita registrada para" + dateSecondVax,
                "Segunda dosis");
            db.Add(secondDosage);
            db.SaveChanges();
        }
        
        //Envio automatico de sintomas
        private void TimePick_ValueChanged(object sender, EventArgs e)
        {
            var db = new Vaccination_ManagementContext();
            SideEffect sideEF = new SideEffect(textBSym.Text);
            MessageBox.Show("El informe de sintomas se envio exitosamente", "Envio de informe");
            db.Add(sideEF);
            db.SaveChanges();
        }
        
    }
}