using System;
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
            var db = new Vaccination_ManagementContext();
            /* public UserCreation()
        {
            InitializeComponent();
            
            var db = new ClinicaContext();
            List<Question> save = db.Questions
                .OrderBy(c => c.Id)
                .ToList();

            for (int i = 0; i < save.Count; i++)
            {
                comboBox1.Items.Add("" + save[i].Ques);
                
            }
        } */
            //TODO: INGRESAR DATOS DE TextBoxes A BD
        }
    }
}