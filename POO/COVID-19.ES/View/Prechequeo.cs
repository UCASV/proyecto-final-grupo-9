using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;
using System.Data;
using System.IO;
using Microsoft.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace COVID_19.ES
{
    public partial class Prechequeo : Form
    {
        SqlConnection connect = new SqlConnection("Server=DESKTOP-J4TCMI2;Database=Vaccination_ManagementV3;Trusted_Connection=True");
        public Prechequeo()
        {
            InitializeComponent();
            datePickerSystem.Value = DateTime.Now;
        }

        public int Count = 0;
        
        //Busqua al ciudadano
        private void bttn_Verifydata_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduzca un DUI");
                
            }
            else
            {   
                var db = new Vaccination_ManagementContext(); //Busca DUI
                var DUI = db.Citizens.Where(
                    U => U.Dui.Equals(Int32.Parse(textBox1.Text))
                ).ToList();
            
                var Ap1 = db.Appointment1s.Where( //Busca la cita 1
                    U => U.DateTime.Value.Date.Equals(datePickerSystem.Value.Date) &&
                         U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                ).ToList();
            
                var Ap2 = db.Appointment2s.Where( //Busca la cita 2
                    U => U.DateTime.Value.Date.Equals(datePickerSystem.Value.Date) &&
                         U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                ).ToList();
                
                var Comp = db.Dose1s.Where( //Busca si ya tuvo la segunda dosis
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                ).ToList();
                
                var CompFin = db.Dose2s.Where( //Busca si ya tuvo la segunda dosis
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                ).ToList();
                
                if (DUI.Count == 0) //Comprueba si el DUI esta registrado
                {
                    MessageBox.Show("DUI no agendado"); 
                
                }
                else
                {
                    if (CompFin.Count == 1) //Comprueba si ya tuvo las dos dosis 
                    {
                        MessageBox.Show("El ciudadano ya realizo las dos dosis");
                    }
                    else if (Ap2.Count == 1) //Comprueba si su proceso esta en la segunda dosis y es su hora
                    {
                        MessageBox.Show("El usuario esta registrado para la segunda vacunacion",
                            "Segunda Dosis");
                        bttn_Verifydata.Enabled = false;
                        check_yes.Enabled = true;
                        check_No.Enabled = true;
                        textBox1.Enabled = false;
                    }
                    else if(Comp.Count == 1)
                    {
                        MessageBox.Show("El usuario se encuetra registrado pero la fecha no corresponde a su cita",
                            "Verificador");
                    }
                    else if (Ap1.Count == 1) //Comprueba si su proceso esta en la primera dosis y es su hora
                    {
                        MessageBox.Show("El usuario esta registrado para la primera vacunacion",
                            "Primera Dosis");
                        bttn_Verifydata.Enabled = false;
                        check_yes.Enabled = true;
                        check_No.Enabled = true;
                        textBox1.Enabled = false;
                    }
                    else //Si esta registrado pero aun no es hora
                    {
                        MessageBox.Show("El usuario se encuetra registrado pero la fecha no corresponde a su cita",
                            "Verificador");
                    }
                }
            }
            
        }
        
        //Si da su consentimiento
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
                    ++Count; //Para que no repita el mensaje
                    check_yes.Checked = false;
                    --Count; //Para devolverlo a la normalidad
                }
            }

        }
        
        //Si no da su consentimiento
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
                    
                    var db = new Vaccination_ManagementContext(); //Busca DUI
                    var DUI = db.Citizens.Where(
                        U => U.Dui.Equals(Int32.Parse(textBox1.Text))
                    ).ToList();
            
                    var Ap1 = db.Appointment1s.Where( //Busca la cita 1
                        U => U.DateTime.Value.Date.Equals(datePickerSystem.Value.Date) &&
                             U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                    ).ToList();
            
                    var Ap2 = db.Appointment2s.Where( //Busca la cita 2
                        U => U.DateTime.Value.Date.Equals(datePickerSystem.Value.Date) &&
                             U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                    ).ToList();
                    
                    if (Ap2.Count == 1)
                    {
                        db.Remove(Ap2[0]);
                        db.SaveChanges();
                    }
                    else if (Ap1.Count == 1)
                    {
                        db.Remove(Ap1[0]);
                        db.SaveChanges();
                    }
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
            
            var Ap1 = db.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            
            var Ap2 = db.Appointment2s.Where(
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
            
            if (Ap2.Count == 1)
            {
                WaitRow2 waitingTime = new WaitRow2() //Introduce a la fila de espera 2
                {
                    DateTime = dateTimePicker3.Value,
                    DuiAppointment2 = Ap2[0].Id
                };
                db.Add(waitingTime);
                db.SaveChanges();
            
                dateTimePicker3.Enabled = false;
                SendSymt.Enabled = false;
                button1.Enabled = true;
                dateTimePicker4.Enabled = true;
                MessageBox.Show("Informacion enviada exitosamente", "Segunda dosis");
            }
            else if (Ap1.Count == 1)
            {
                WaitRow1 waitingTime = new WaitRow1() //Introduce a la fila de espera 1
                {
                    DateTime = dateTimePicker3.Value,
                    DuiAppointment1 = Ap1[0].Id
                };
                db.Add(waitingTime);
                db.SaveChanges();
            
                dateTimePicker3.Enabled = false;
                SendSymt.Enabled = false;
                button1.Enabled = true;
                dateTimePicker4.Enabled = true;
                MessageBox.Show("Informacion enviada exitosamente", "Primera dosis");
            }
            
            
        }
        
        // Envia a Dose1
        private void button1_Click(object sender, EventArgs e)
        {
            var db = new  Vaccination_ManagementContext();
            
            var Ap1 = db.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            
            var Ap2 = db.Appointment2s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            
            if (Ap2.Count == 1)
            {
                Dose2 SecDosage = new Dose2() //Introduce a dosis 2
                {
                    DateTime = dateTimePicker4.Value,
                    DuiCitizen = Ap2[0].DuiCitizen
                };
                db.Add(SecDosage);     
                db.SaveChanges();

                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                button1.Enabled = false;
                dateTimePicker4.Enabled = false;
                secondAppointment.Text = "Terminar proceso";
            
                MessageBox.Show("Informacion enviada exitosamente. Continue con el siguiente paso", "Segunda dosis");
            }
            else if (Ap1.Count == 1)
            {
                Dose1 firstDosage = new Dose1() //Introduce a dosis 1
                {
                    DateTime = dateTimePicker4.Value,
                    DuiCitizen = Ap1[0].DuiCitizen
                };
                db.Add(firstDosage);     
                db.SaveChanges();

                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                button1.Enabled = false;
                dateTimePicker4.Enabled = false;
                secondAppointment.Text = "Registrar segunda cita";
                
                MessageBox.Show("Informacion enviada exitosamente. Continue con el siguiente paso", "Primera dosis");
            }
            
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
                secondAppointment.Enabled = true;
                textBSym.Enabled = false;
                TimePick.Enabled = false;
                bttn_sendsym.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            
        }
        
        //Generar segunda cita
        private void secondAppointment_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var db = new Vaccination_ManagementContext();

            var Ap1 = db.Appointment1s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            
            var Ap2 = db.Appointment2s.Where(
                U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
            ).ToList();
            
            if (Ap2.Count == 1)
            {
                MessageBox.Show("Ha terminado el proceso de vacunacion");
                
                this.Close();
            }
            else if (Ap1.Count == 1)
            {
                dateTimePicker5.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                    DateTime.Now.Day, rand.Next(7, 10), rand.Next(0, 50), 0);
                dateTimePicker5.Value = DateTime.Now.AddDays(rand.Next(42, 56));
            
                var Cit_Ap = db.Appointment1s.Where(
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                ).ToList();
            
                //intro de datos a Appointment2
                Appointment2 secondDosage = new Appointment2()
                {
                    DateTime = dateTimePicker5.Value,
                    DuiCitizen = Cit_Ap[0].DuiCitizen,
                    Place = Cit_Ap[0].Place
                };
                db.Add(secondDosage);
                db.SaveChanges();

                MessageBox.Show($"Fecha: {dateTimePicker5.Value}       Lugar: {Cit_Ap[0].Place}"
                    ,"Segunda cita programada");
                
                this.Close();
            }

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void bttnExport_Click(object sender, EventArgs e)
        {
            if (DGVData.Rows.Count > 0) {  
                 SaveFileDialog sfd = new SaveFileDialog();  
                 sfd.Filter = "PDF (.pdf)|.pdf";  
                 sfd.FileName = "Data.pdf";  
                 bool fileError = false;  
                 if (sfd.ShowDialog() == DialogResult.OK)  
                 {  
                     if (File.Exists(sfd.FileName))  
                     {  
                         try  
                         {  
                             File.Delete(sfd.FileName);  
                         }  
                         catch (IOException ex)  
                         {  
                             fileError = true;  
                             MessageBox.Show("No fue posible escribir los datos en el disco." + ex.Message);  
                         }  
                     }  
                     if (!fileError)  
                     {  
                         try  
                         {
                             PdfPTable pdfTable = new PdfPTable(DGVData.Columns.Count);  
                             pdfTable.DefaultCell.Padding = 3;  
                             pdfTable.WidthPercentage = 100;  
                             pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;  
  
                             foreach (DataGridViewColumn column in DGVData.Columns)  
                             {  
                                 PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));  
                                 pdfTable.AddCell(cell);  
                             }  
  
                             foreach (DataGridViewRow row in DGVData.Rows)  
                             {  
                                 foreach (DataGridViewCell cell in row.Cells)  
                                 {  
                                     if (cell.Value != null)
                                     {
                                         pdfTable.AddCell(cell.Value.ToString());
                                     } 
                                 }  
                             }  
  
                             using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))  
                             {  
                                 Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);  
                                 PdfWriter.GetInstance(pdfDoc, stream);  
                                 pdfDoc.Open();  
                                 Paragraph title;
                                 Font titleFont = FontFactory.GetFont("Arial", 32);
                                 title = new Paragraph("Datos recolectados", titleFont );
                                 title.Alignment = Element.ALIGN_CENTER;
                                 pdfDoc.Add(title);
                                 pdfDoc.Add(new Chunk("\n"));
                                 pdfDoc.Add(pdfTable);  
                                 pdfDoc.Close();  
                                 stream.Close();  
                             }  
  
                             MessageBox.Show("Datos exportados con exito!", "Covid-19 - Exportando datos",MessageBoxButtons.OK,MessageBoxIcon.Information);  
                         }  
                         catch (Exception ex)  
                         {  
                             MessageBox.Show("Error :" + ex.Message);  
                         }  
                     }  
                 }  
            }  
            else  
            {  
                MessageBox.Show("No hay nada para exportar!", "Info");  
            }
        }

        private void Prechequeo_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CITIZEN;",connect);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            DGVData.DataSource = table;
        }
    }
}