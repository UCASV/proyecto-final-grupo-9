﻿using System;
using System.Collections.Generic;
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
            int number = 0;
            int.TryParse(textBox1.Text, out number);
            
                
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""
                || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Introduzca todos los datos");
            }
            else
            {
                using (var db = new Vaccination_ManagementContext())
                {
                    var Qstn = new List<Manager>()
                    {
                        new Manager()
                        {
                            Id = number,
                            Name = textBox2.Text,
                            Password = textBox3.Text,
                            InstitutionalMail = textBox4.Text,
                            HomeDirection = textBox5.Text,
                            EmployeeType = textBox6.Text
                        }
                    };
                    Qstn.ForEach(qs => db.Add(qs));
                    db.SaveChanges(); 
                    MessageBox.Show("Datos introducidos");                    
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                }
            }
        }
    } 
}