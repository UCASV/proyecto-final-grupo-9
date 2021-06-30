using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;

namespace COVID_19.ES
{
    public partial class AppointmentProcess : Form
    {
        public AppointmentProcess()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            if ((textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""
                 || textBox4.Text == "" || textBox5.Text == "" || textBox7.Text == "") ||
                (textBox6.Text == "" && comboBox2.Text != "") || (textBox8.Text == "" && comboBox1.Text != ""))
            {
                MessageBox.Show("Introduzca todos los datos");
            }
            else
            {
                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.Now.Day);
                    if (Int32.Parse(textBox7.Text) >= 60 || comboBox2.Text == "SI" || comboBox1.Text != "")
                    {
                        var db = new Vaccination_ManagementContext();
                        List<Citizen> citizenlist = db.Citizens.ToList();
                        List<ChronicDisease> diseaselist = db.ChronicDiseases.ToList();
                        List<Institution> institutionlist = db.Institutions.ToList();

                        var dataEntered = citizenlist.Where(
                            U => U.Dui.Equals(Int32.Parse(textBox1.Text))
                        ).ToList();
                        
                        var comprIdInst = institutionlist.Where(
                            U => U.Name.Equals(comboBox1.Text)
                                 && U.InstID.Equals(textBox8.Text)
                        ).ToList();

                        if (dataEntered.Count == 0 && comprIdInst.Count == 0)
                        {

                            Citizen one = new Citizen(Int32.Parse(textBox1.Text), textBox2.Text,
                                textBox3.Text, textBox4.Text, textBox5.Text);
                            db.Add(one);
                            db.SaveChanges();

                            if (textBox6.Text != "" && comboBox2.Text != "")
                            {
                                ChronicDisease disease = new ChronicDisease()
                                {
                                    Name = textBox6.Text,
                                    DuiCitizen = Int32.Parse(textBox1.Text),
                                    DuiCitizenNavigation = one
                                };
                                db.Add(disease);
                                db.SaveChanges();
                            }


                            if (textBox8.Text != "" && comboBox1.Text != "")
                            {
                                Institution institutionA = new Institution()
                                {
                                    Name = comboBox1.Text,
                                    InstID = textBox8.Text,
                                    DuiCitizen = Int32.Parse(textBox1.Text)
                                };
                                db.Add(institutionA);
                                db.SaveChanges();
                            }
                            
                            PriorityGroup Pg = new PriorityGroup()
                            {
                                Name = textBox2.Text,
                                DuiCitizen = Int32.Parse(textBox1.Text),
                            };
                            db.Add(Pg);
                            db.SaveChanges();
                            
                            MessageBox.Show("Datos introducidos");

                            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                    DateTime.Now.Day, rand.Next(7, 10), rand.Next(0, 50), 0);
                            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(rand.Next(10, 20));

                            int randhospital = rand.Next(1, 5);
                            string hospital = "";
                            switch (randhospital)
                            {
                                case 1:
                                    hospital = "Hospital Nacional de la mujer";
                                    break;
                                case 2:
                                    hospital = "Hospital de San Rafael";
                                    break;
                                case 3:
                                    hospital = "Hospital de El Salvador";
                                    break;
                                case 4:
                                    hospital = "Hospital Zacamil ";
                                    break;
                                case 5:
                                    hospital = "Hospital Nacional Rosales";
                                    break;
                            }

                            label12.Text = dateTimePicker1.Value.ToString();
                            label14.Text = hospital;
                            label11.Visible = true;
                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;
                            
                            
                            Appointment1 appoinment = new Appointment1()
                            {
                                DateTime = dateTimePicker1.Value,
                                Place = hospital,
                                DuiCitizen = Int32.Parse(textBox1.Text)
                                
                            };
                            db.Add(appoinment);
                            db.SaveChanges();

                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            textBox6.Enabled = false;
                            textBox7.Enabled = false;
                            textBox8.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                        }else
                        {
                            MessageBox.Show("Ya existe un gestor con ese identificacion. Compruebe DUI o ID institucional.");
                        }
                            
                    }else
                    {
                        var db = new Vaccination_ManagementContext();
                        List<Citizen> citizenlist = db.Citizens.ToList();
                        List<ChronicDisease> diseaselist = db.ChronicDiseases.ToList();
                        List<Institution> institutionlist = db.Institutions.ToList();

                        var dataEntered = citizenlist.Where(
                            U => U.Dui.Equals(Int32.Parse(textBox1.Text))
                        ).ToList();

                        if (dataEntered.Count == 0)
                        {

                            Citizen one = new Citizen(Int32.Parse(textBox1.Text), textBox2.Text,
                                textBox3.Text, textBox4.Text, textBox5.Text);
                            db.Add(one);
                            db.SaveChanges();
                            

                            MessageBox.Show("Datos introducidos");
                            
                            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                DateTime.Now.Day, rand.Next(7, 10), rand.Next(0, 50), 0);
                            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(rand.Next(30, 50));

                            int randhospital = rand.Next(1, 5);
                            string hospital = "";
                            switch (randhospital)
                            {
                                case 1:
                                    hospital = "Hospital Nacional de la mujer";
                                    break;
                                case 2:
                                    hospital = "Hospital de San Rafael";
                                    break;
                                case 3:
                                    hospital = "Hospital de El Salvador";
                                    break;
                                case 4:
                                    hospital = "Hospital Zacamil ";
                                    break;
                                case 5:
                                    hospital = "Hospital Nacional Rosales";
                                    break;
                            }

                            label12.Text = dateTimePicker1.Value.ToString();
                            label14.Text = hospital;
                            label11.Visible = true;
                            label12.Visible = true;
                            label13.Visible = true;
                            label14.Visible = true;

                            Appointment1 appoinment = new Appointment1()
                            {
                                DateTime = dateTimePicker1.Value,
                                Place = hospital,
                                DuiCitizen = Int32.Parse(textBox1.Text)
                                
                            };
                            db.Add(appoinment);
                            db.SaveChanges();

                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox3.Enabled = false;
                            textBox4.Enabled = false;
                            textBox5.Enabled = false;
                            textBox6.Enabled = false;
                            textBox7.Enabled = false;
                            textBox8.Enabled = false;
                            comboBox1.Enabled = false;
                            comboBox2.Enabled = false;
                        }else
                        {
                            MessageBox.Show("Ya existe un gestor con ese identificacion.");
                        }
                        
                        

                    }
                    
            }
            
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                textBox8.Enabled = true;
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                textBox6.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            if (textBox9.Text == "")
            {
                MessageBox.Show("Introduzca todos los datos");
            }
            else
            {   
                var db = new Vaccination_ManagementContext();
                List<Citizen> citizenlist = db.Citizens.ToList();
                List<PriorityGroup> priorityGrouplist = db.PriorityGroups.ToList();

                var dataEntered = citizenlist.Where(
                    U => U.Dui.Equals(Int32.Parse(textBox9.Text))
                ).ToList();

                var compPriority = priorityGrouplist.Where(
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox9.Text))
                ).ToList();
                
                var compAp1 = db.Appointment1s.Where(
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox9.Text))
                ).ToList();
                
                var compAp2 = db.Appointment2s.Where(
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox9.Text))
                ).ToList();
                
                var compDose1 = db.Dose1s.Where(
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox9.Text))
                ).ToList();
                
                var compDose2 = db.Dose2s.Where(
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox9.Text))
                ).ToList();
                
                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                        DateTime.Now.Day);

                if (compDose2.Count == 1)
                {
                    MessageBox.Show(
                        "El ciudadano ya cumplio las dos dosis.");
                }
                else if (compDose1.Count == 1 )
                {
                    if (compAp2.Count == 0)
                    {
                        if (compPriority.Count == 1)
                        {
                            if (dataEntered.Count == 1)
                            {
                                MessageBox.Show("Datos introducidos");

                                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                    DateTime.Now.Day, rand.Next(7, 10), rand.Next(0, 50), 0);
                                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(rand.Next(10, 20));

                                int randhospital = rand.Next(1, 5);
                                string hospital = "";
                                switch (randhospital)
                                {
                                    case 1:
                                        hospital = "Hospital Nacional de la mujer";
                                        break;
                                    case 2:
                                        hospital = "Hospital de San Rafael";
                                        break;
                                    case 3:
                                        hospital = "Hospital de El Salvador";
                                        break;
                                    case 4:
                                        hospital = "Hospital Zacamil ";
                                        break;
                                    case 5:
                                        hospital = "Hospital Nacional Rosales";
                                        break;
                                }

                                label26.Text = dateTimePicker1.Value.ToString();
                                label28.Text = hospital;
                                label28.Text = hospital;
                                label17.Text = "Segunda dosis";
                                label16.Visible = true;
                                label17.Visible = true;
                                label25.Visible = true;
                                label26.Visible = true;
                                label27.Visible = true;
                                label28.Visible = true;


                                Appointment2 appoinment = new Appointment2()
                                {
                                    DateTime = dateTimePicker1.Value,
                                    Place = hospital,
                                    DuiCitizen = Int32.Parse(textBox9.Text)

                                };
                                db.Add(appoinment);
                                db.SaveChanges();

                                textBox9.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show(
                                "El DUI no ha sido registrado.");
                            }


                        }
                        else if (compPriority.Count == 0)
                        {
                            if (dataEntered.Count == 1)
                            {
                                MessageBox.Show("Datos introducidos");

                                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                    DateTime.Now.Day, rand.Next(7, 10), rand.Next(0, 50), 0);
                                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(rand.Next(30, 50));

                                int randhospital = rand.Next(1, 5);
                                string hospital = "";
                                switch (randhospital)
                                {
                                    case 1:
                                        hospital = "Hospital Nacional de la mujer";
                                        break;
                                    case 2:
                                        hospital = "Hospital de San Rafael";
                                        break;
                                    case 3:
                                        hospital = "Hospital de El Salvador";
                                        break;
                                    case 4:
                                        hospital = "Hospital Zacamil ";
                                        break;
                                    case 5:
                                        hospital = "Hospital Nacional Rosales";
                                        break;
                            }

                            label26.Text = dateTimePicker1.Value.ToString();
                            label28.Text = hospital;
                            label17.Text = "Segunda dosis";
                            label16.Visible = true;
                            label17.Visible = true;
                            label25.Visible = true;
                            label26.Visible = true;
                            label27.Visible = true;
                            label28.Visible = true;


                            Appointment2 appoinment = new Appointment2()
                            {
                                DateTime = dateTimePicker1.Value,
                                Place = hospital,
                                DuiCitizen = Int32.Parse(textBox9.Text)

                            };
                            db.Add(appoinment);
                            db.SaveChanges();

                            textBox9.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show(
                                    "El DUI no ha sido registrado.");
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(
                            "Ya tiene una cita programada.");
                    }
                    
                }
                else if (compDose1.Count == 0)
                {
                    if (compAp1.Count == 0)
                    {
                        if (compPriority.Count == 1)
                        {
                            if (dataEntered.Count == 1)
                            {
                                MessageBox.Show("Datos introducidos");

                                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                    DateTime.Now.Day, rand.Next(7, 10), rand.Next(0, 50), 0);
                                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(rand.Next(10, 20));

                                int randhospital = rand.Next(1, 5);
                                string hospital = "";
                                switch (randhospital)
                                {
                                    case 1:
                                        hospital = "Hospital Nacional de la mujer";
                                        break;
                                    case 2:
                                        hospital = "Hospital de San Rafael";
                                        break;
                                    case 3:
                                        hospital = "Hospital de El Salvador";
                                        break;
                                    case 4:
                                        hospital = "Hospital Zacamil ";
                                        break;
                                    case 5:
                                        hospital = "Hospital Nacional Rosales";
                                        break;
                                }

                                label26.Text = dateTimePicker1.Value.ToString();
                                label28.Text = hospital;
                                label28.Text = hospital;
                                label17.Text = "Primera dosis";
                                label16.Visible = true;
                                label17.Visible = true;
                                label25.Visible = true;
                                label26.Visible = true;
                                label27.Visible = true;
                                label28.Visible = true;


                                Appointment1 appoinment = new Appointment1()
                                {
                                    DateTime = dateTimePicker1.Value,
                                    Place = hospital,
                                    DuiCitizen = Int32.Parse(textBox9.Text)

                                };
                                db.Add(appoinment);
                                db.SaveChanges();

                                textBox9.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show(
                                "El DUI no ha sido registrado.");
                            }


                        }
                        else if (compPriority.Count == 0)
                        {
                            if (dataEntered.Count == 1)
                            {
                                MessageBox.Show("Datos introducidos");

                                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                    DateTime.Now.Day, rand.Next(7, 10), rand.Next(0, 50), 0);
                                dateTimePicker1.Value = dateTimePicker1.Value.AddDays(rand.Next(30, 50));

                                int randhospital = rand.Next(1, 5);
                                string hospital = "";
                                switch (randhospital)
                                {
                                    case 1:
                                        hospital = "Hospital Nacional de la mujer";
                                        break;
                                    case 2:
                                        hospital = "Hospital de San Rafael";
                                        break;
                                    case 3:
                                        hospital = "Hospital de El Salvador";
                                        break;
                                    case 4:
                                        hospital = "Hospital Zacamil ";
                                        break;
                                    case 5:
                                        hospital = "Hospital Nacional Rosales";
                                        break;
                            }

                            label26.Text = dateTimePicker1.Value.ToString();
                            label28.Text = hospital;
                            label28.Text = hospital;
                            label17.Text = "Primera dosis";
                            label16.Visible = true;
                            label17.Visible = true;
                            label25.Visible = true;
                            label26.Visible = true;
                            label27.Visible = true;
                            label28.Visible = true;


                            Appointment1 appoinment = new Appointment1()
                            {
                                DateTime = dateTimePicker1.Value,
                                Place = hospital,
                                DuiCitizen = Int32.Parse(textBox9.Text)

                            };
                            db.Add(appoinment);
                            db.SaveChanges();

                            textBox9.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show(
                                    "El DUI no ha sido registrado.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Ya tiene una cita programada.");
                    }
                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox9.Enabled = true;
            label16.Visible = false;
            label17.Visible = false;
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
        }
    }
}