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
            if (Int32.Parse(textBox7.Text) >= 60 || comboBox2.Text == "SI" || comboBox1.Text != "")
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""
                || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Introduzca todos los datos");
                }
                else
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
                        
                        ChronicDisease disease = new ChronicDisease( )
                        {
                            Name = textBox6.Text,
                            DuiCitizen = Int32.Parse(textBox1.Text),
                            DuiCitizenNavigation = one
                        };
                        db.Add(disease);
                        db.SaveChanges();
                        
                        Institution institutionA = new Institution( )
                        {
                            Name = comboBox1.Text,
                            DuiCitizen = Int32.Parse(textBox1.Text)
                        };
                        db.Add(institutionA);
                        db.SaveChanges();
                        MessageBox.Show("Datos introducidos");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un gestor con ese identificacion.");
                    }

                    /*textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.Text = "";*/
                }
            }
            else
            {
                MessageBox.Show("No esta dentro del grupo");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}