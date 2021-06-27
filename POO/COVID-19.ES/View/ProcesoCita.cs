using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;

namespace COVID_19.ES
{
    public partial class ProcesoCita : Form
    {
        public ProcesoCita()
        {
            InitializeComponent();
        }

        private void bttn_ApointProcess_Click(object sender, EventArgs e)
        {
            if (txtbxDUI.Text == "" || txtbxMail.Text == "" || txtbxName.Text == ""
                || txtbxDirection.Text == "" || txtbxChronic.Text == "" || txtbxPhone.Text == "")
            {
                MessageBox.Show("Introduzca todos los datos");
            }
            else
            {
                
                var db = new Vaccination_ManagementContext();
                List<Citizen> citizenlist = db.Citizens.ToList();
                
                var dataEntered = citizenlist.Where(
                    U => U.Dui.Equals(Int32.Parse(txtbxDUI.Text)) 
                ).ToList();
                
                if (dataEntered.Count == 0)
                {
                    
                    Citizen one = new Citizen(Int32.Parse(txtbxDUI.Text), txtbxName.Text, txtbxDirection.Text, txtbxPhone.Text, txtbxMail.Text);
                    db.Add(one);
                    db.SaveChanges();
                    MessageBox.Show("Datos introducidos");
                }
                else
                {
                    MessageBox.Show("Ya existe un gestor con ese identificacion.");
                }
                txtbxDUI.Text = "";
                txtbxName.Text = "";
                txtbxDirection.Text = "";
                txtbxPhone.Text = "";
                txtbxMail.Text = "";
            }
        }

        private void bttnback_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void cmbInstitucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}