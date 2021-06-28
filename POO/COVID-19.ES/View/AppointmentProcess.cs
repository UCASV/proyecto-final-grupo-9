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

                        if (dataEntered.Count == 0)
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

                            MessageBox.Show("Datos introducidos");

                            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                    DateTime.Now.Day, 7, 0, 0);
                            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(14);

                            label12.Text = dateTimePicker1.Value.ToString();
                            label11.Visible = true;
                            label12.Visible = true;

                            Dose1 dose = new Dose1()
                            {
                                DateTime = dateTimePicker1.Value,
                                DuiCitizen = Int32.Parse(textBox1.Text)
                            };
                            db.Add(dose);
                            db.SaveChanges();

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
                        }else
                        {
                            MessageBox.Show("Ya existe un gestor con ese identificacion.");
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
                                    DateTime.Now.Day, 7, 0, 0);
                            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(30);

                            label12.Text = dateTimePicker1.Value.ToString();
                            label11.Visible = true;
                            label12.Visible = true;

                            Dose1 dose = new Dose1()
                            {
                                DateTime = dateTimePicker1.Value,
                                DuiCitizen = Int32.Parse(textBox1.Text)
                            };
                            db.Add(dose);
                            db.SaveChanges();

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
    }
}