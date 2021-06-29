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

        public int Count;
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
            var DUI = db.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            var Ap1 = db.Appointment1s.Where(
                U => U.DateTime.Value.Date.Equals(datePickerSystem.Value.Date) &&
                     U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                ).ToList();

            if (DUI.Count == 0)
            {
                MessageBox.Show("DUI no agendado");
                
            }
            else
            {
                if (Ap1.Count == 0)
                {
                    MessageBox.Show("El usuario se encuetra registrado pero la fecha no corresponde a su cita",
                        "Verificador");
                }
                else
                {
                    MessageBox.Show("El usuario esta registrado para vacunacion",
                        "Verificador");
                }
            }
            
        }
        
        //Aparicion de campos para introducir efectos secundarios
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelSym.Visible = true;
            labelTime.Visible = true;
            textBSym.Visible = true;
            TimePick.Visible = true;
            
            bttn_sendsym.Visible = true;
            secondAppointment.Location = new Point(362, 361);
        }
        
        //Generar segunda cita
        private void secondAppointment_Click(object sender, EventArgs e)
        {
            var db = new Vaccination_ManagementContext();
            DateTime dateSecondVax = dateTimePicker2.Value.AddDays(50);
            
            //asignacion de hospital segun appointment1.
            var db2 = new  Vaccination_ManagementContext();
            var DUI = db2.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();

            List<Appointment1> AppointList = db2.Appointment1s.OrderBy(a => a.DuiCitizen).ToList();
            String hospital = "Hospital Control";
            for (int i = 0; i < DUI.Count; i++)
            {
                if (Int32.Parse(textBox1.Text) == AppointList[i].DuiCitizen)
                {
                    hospital = AppointList[i].Place;
                }
            }
            //intro de datos a Appointment2
            Appointment2 secondDosage = new Appointment2()
            {
                DateTime = dateSecondVax,
                DuiCitizen = Int32.Parse(textBox1.Text),
                Place = hospital
            };
            MessageBox.Show("Segunda dosis dentro de 50 dias, cita registrada para" + dateSecondVax,
                "Segunda dosis");
            db.Add(secondDosage);
            db.SaveChanges();
        }

        private void SendSymt_Click(object sender, EventArgs e)
        {
            var db3 = new  Vaccination_ManagementContext();
            var DUI = db3.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();

            List<Appointment1> AppointList = db3.Appointment1s.OrderBy(a => a.DuiCitizen).ToList();
            int dui = 0;
            for (int i = 0; i <= DUI.Count; i++)
            {
                if (Int32.Parse(textBox1.Text) == AppointList[i].DuiCitizen)
                {
                    dui = AppointList[i].Id;
                }
                else
                {
                    dui = 0;
                }
                
            }
            
            TimeSpan diferenciaDeHora = dateTimePicker3.Value - dateTimePicker4.Value; 
            if (diferenciaDeHora >= TimeSpan.FromMinutes(30))
            {
                MessageBox.Show("EL TIEMPO DE ESPERA SUPERO LA MARCA DE TOLERANCIA DE 30 MINUTOS",
                    "ADVERTENCIA DE PRODUCTIVIDAD",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Tiempo de atencion en rango aceptable", "ADVERTENCIA DE PRODUCTIVIDAD");
            }
            //Enviar info a WaitRow1 sobre tiempo de espera
            /*
            var db = new Vaccination_ManagementContext();
            WaitRow1 waitingTime = new WaitRow1()
            {
                DateTime = dateTimePicker2.Value,
                DuiAppointment1 = dui
            };
            db.Add(waitingTime);
            db.SaveChanges();
            */
            
            //completar info sobre Dose1
            
            var db2 = new Vaccination_ManagementContext();
            Dose1 firstDosage = new Dose1()
            {
                DateTime = dateTimePicker2.Value,
                DuiCitizen = Int32.Parse(textBox1.Text)
            };
            //Dose1 firstDosage = new Dose1(dateTimePicker2.Value, Int32.Parse(textBox1.Text));
            db2.Add(firstDosage);     
            db2.SaveChanges();
            MessageBox.Show("Informacion enviada exitosamente", "Primera dosis");
            
        }

        private void bttn_sendsym_Click(object sender, EventArgs e)
        {
            var db = new Vaccination_ManagementContext();
            SideEffect sideEF = new SideEffect()
            {
                Name = textBSym.Text
            };
            db.Add(sideEF);
            db.SaveChanges();
            MessageBox.Show("El informe de sintomas se envio exitosamente", "Envio de informe");
        }
    }
}