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

        public int Count = 0;
        
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
                    bttn_Verifydata.Enabled = false;
                    check_yes.Enabled = true;
                    check_No.Enabled = true;
                    
                }
            }
            
        }
        
        private void check_yes_CheckedChanged(object sender, EventArgs e)
        {
            //IF PARA QUE NO SE REPITA EL MENSAJE DE CONFIRMACION CUANDO SE RESETEA 
            if (Count == 0)
            {
                string message = "¿Esta seguro de esta opcion?";
                string title = "Ventana de confirmacion";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult ventana = (MessageBox.Show(message, title, buttons));
            
                if (ventana == DialogResult.Yes)
                {
                    check_yes.Enabled = false;
                    check_No.Enabled = false;
                    MessageBox.Show("Continue con el siguiente paso");
                    dateTimePicker3.Enabled = true;
                    SendSymt.Enabled = true;
                }
                else
                {
                    ++Count;
                    check_yes.Checked = false;
                    --Count;
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
                DialogResult ventana = (MessageBox.Show(message, title, buttons));
            
                if (ventana == DialogResult.Yes)
                {
                    MessageBox.Show("La cita sera borrada");
                    this.Close();
                }
                else
                {
                    ++Count;
                    check_No.Checked = false;
                    --Count;
                }
            }
        }
        
        //wait row
        private void SendSymt_Click(object sender, EventArgs e)
        {
            var db = new  Vaccination_ManagementContext();
            
            var DUI = db.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            
            /*TimeSpan diferenciaDeHora = dateTimePicker3.Value - dateTimePicker4.Value; 
            if (diferenciaDeHora >= TimeSpan.FromMinutes(30))
            {
                MessageBox.Show("EL TIEMPO DE ESPERA SUPERO LA MARCA DE TOLERANCIA DE 30 MINUTOS",
                    "ADVERTENCIA DE PRODUCTIVIDAD",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Tiempo de atencion en rango aceptable", "ADVERTENCIA DE PRODUCTIVIDAD");
            }*/
            
            WaitRow1 waitingTime = new WaitRow1()
            {
                DateTime = dateTimePicker3.Value,
                DuiAppointment1 = DUI[0].Id
            };
            db.Add(waitingTime);
            db.SaveChanges();
            
            dateTimePicker3.Enabled = false;
            SendSymt.Enabled = false;
            button1.Enabled = true;
            dateTimePicker4.Enabled = true;
            MessageBox.Show("Informacion enviada exitosamente", "Primera dosis");
        }
        
        // Envia a Dose1
        private void button1_Click(object sender, EventArgs e)
        {
            var db = new  Vaccination_ManagementContext();
            
            var DUI = db.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            
            Dose1 firstDosage = new Dose1()
            {
                DateTime = dateTimePicker4.Value,
                DuiCitizen = DUI[0].DuiCitizen
            };
            db.Add(firstDosage);     
            db.SaveChanges();

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            button1.Enabled = false;
            dateTimePicker4.Enabled = false;
            
            MessageBox.Show("Informacion enviada exitosamente, continue con el siguiente paso", "Primera dosis");
        }
        
        //Aparicion de campos para introducir efectos secundarios
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                labelSym.Visible = true;
                labelTime.Visible = true;
                textBSym.Visible = true;
                TimePick.Visible = true;
                bttn_sendsym.Visible = true;
                
                checkBox2.Checked = false;
                
                secondAppointment.Enabled = false;
            }
            
            
        }
        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                labelSym.Visible = false;
                labelTime.Visible = false;
                textBSym.Visible = false;
                textBSym.Text = "";
                TimePick.Visible = false;
                bttn_sendsym.Visible = false;
                
                checkBox1.Checked = false;

                secondAppointment.Enabled = true;
            }
            
        }
        
        //sintomas
        private void bttn_sendsym_Click(object sender, EventArgs e)
        {
            if (textBSym.Text == "")
            {
                MessageBox.Show("Introduzca todos los datos");
            }
            else
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
        
        //Generar segunda cita
        private void secondAppointment_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var db = new Vaccination_ManagementContext();

            dateTimePicker5.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                DateTime.Now.Day, rand.Next(7, 10), rand.Next(0, 50), 0);
            dateTimePicker5.Value = DateTime.Now.AddDays(rand.Next(10, 20));
            
            var Cit_Ap = db.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            
            //intro de datos a Appointment2
            Appointment2 secondDosage = new Appointment2()
            {
                DateTime = dateTimePicker5.Value,
                DuiCitizen = Cit_Ap[0].Id,
                Place = Cit_Ap[0].Place
            };
            db.Add(secondDosage);
            db.SaveChanges();

            MessageBox.Show("Datos enviados");
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }


        
    }
}