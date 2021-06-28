using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;

namespace COVID_19.ES
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bttnIngresar_Click(object sender, EventArgs e)
        {
            if (txtbxPassword.Text == "" || txtbxUser.Text == "")
            {
                MessageBox.Show("Introduzca todos los datos");
            }
            else
            {
                var db = new Vaccination_ManagementContext();
                var List = db.Managers
                    .OrderBy(c => c.Id)
                    .ToList();
                var resultado = List.Where(
                    u => u.Id.Equals(Int32.Parse(txtbxUser.Text)) &&
                         u.Password.Equals(txtbxPassword.Text)).ToList();

                if(resultado.Count == 0)
                {
                    MessageBox.Show("El usuario no existe", "Inicio",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bienvenido", "Inicio",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainMenu menu = new MainMenu();
                    menu.ShowDialog();
                    this.Close();
                }
            }
           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SignIn sign = new SignIn();
            sign.ShowDialog();
        }
    }
}