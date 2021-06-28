using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;
using Microsoft.EntityFrameworkCore;

namespace COVID_19.ES
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""
                || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Introduzca todos los datos");
            }
            else
            {
                
                var db = new Vaccination_ManagementContext();

                List<Manager> managerlist = db.Managers.ToList();
                
                var dataEntered = managerlist.Where(
                    U => U.Id.Equals(Int32.Parse(textBox1.Text)) 
                ).ToList();
                
                    if (dataEntered.Count == 0)
                    {
                        Manager one = new Manager(Int32.Parse(textBox1.Text), textBox3.Text,
                            textBox4.Text, textBox5.Text, textBox6.Text,
                            textBox2.Text);
                        db.Add(one);
                        db.SaveChanges();
                        MessageBox.Show("Datos introducidos");
                        
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un gestor con ese identificacion.");
                    }
                    
                    
            }
        }

        private void bttnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}