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

        private void Login_Load(object sender, EventArgs e)
        {
/* Prueba para saber si la BD esta bien conectada
//////////////cambiar base de datos a auto incrementable
var db = new Vaccination_ManagementContext();
List<Manager> managerlist = db.Managers.ToList();
Manager one = new Manager(34,"735t1", "micorreo@gmail.com", "bulebar 1", "Jefe", "Rian Carlos");
db.Add(one);
db.SaveChanges();
*/
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}