using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;

namespace COVID_19.ES
{
    public partial class GoAppointment : Form
    {
        public GoAppointment()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox2.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Introduzca todos los datos");
            }
            else
            {
                /////arreglar los datos de tiempo por favor para que se tengan el formato "2020-01-01 13:30:15"
                string stringdatetime = (dateTimePicker1.Text+" "+ dateTimePicker2.Text);
                DateTime varDateTime = Convert.ToDateTime(stringdatetime);
                
                ////
                var db = new Vaccination_ManagementContext();
                List<Appointment1> appointment1slist = db.Appointment1s.ToList();
                List<Citizen> citizenslist = db.Citizens.ToList();
                
                var dataEntered = appointment1slist.Where(
                    U => U.DuiCitizen.Equals(Int32.Parse(textBox1.Text))
                ).ToList();
                var citizenssearch = citizenslist.Where(
                    U => U.Dui.Equals(Int32.Parse(textBox1.Text))
                ).ToList();;

                if (dataEntered.Count == 0)
                {
                    var citizennew = citizenssearch.First();
                    Appointment1 one = new Appointment1(varDateTime, comboBox2.Text, Int32.Parse(textBox1.Text),
                        citizennew);
                    db.Add(one);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ya existe un gestor con ese identificacion.");
                }

                textBox1.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
        }
    }
    }
