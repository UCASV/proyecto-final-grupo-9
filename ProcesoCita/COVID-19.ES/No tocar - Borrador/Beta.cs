using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COVID_19.ES.CovidContext;

namespace COVID_19.ES
{
    public partial class Beta : Form
    {
        public Beta()
        {
            InitializeComponent();
        }

        private void Beta_Load(object sender, EventArgs e)
        {
            //las formas de ingrsar datos estan dentro de los if
            
            //////////////como ingresar un manager (gestor)
            if(false){
                var db = new Vaccination_ManagementContext();
                List<Manager> managerlist = db.Managers.ToList();
                Manager one = new Manager(01, "735t1", "micorreo@gmail.com", "bulebar 1", "Jefe", "Rian Carlos");
                db.Add(one);
                db.SaveChanges();
            }
            /////////////como ingresar un citizen
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<Citizen> citizenlist = db.Citizens.ToList();
                Citizen one = new Citizen(01, "Pedro Arturo", "bulebar 1", "7759-0000", "@correo.com");
                db.Add(one);
                db.SaveChanges();
            }
            
            ///////////// como ingresar cabin
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<Cabin> cabinlist = db.Cabins.ToList();
                Cabin one = new Cabin(02, "5° Av. Norte", "2451-1702", "Juan Rosa Chavez", "@correo.com");
                db.Add(one);
                db.SaveChanges();
            }
            
            ///////// como ingresar datos a sideEffects
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<SideEffect> cabinlist = db.SideEffects.ToList();
                SideEffect one = new SideEffect("COvid");
                db.Add(one);
                db.SaveChanges();
            }
            
            ////Appointment1
            if (false)
            {
                DateTime varDateTime = Convert.ToDateTime("2020-01-01 13:30:15");
                var db = new Vaccination_ManagementContext();
                List<Appointment1> cabinlist = db.Appointment1s.ToList();
                Appointment1 one = new Appointment1(varDateTime, "Sonsonate",34);
                db.Add(one);
                db.SaveChanges();
            }
            
            ////Appointment2
            if (false)
            {
                DateTime varDateTime = Convert.ToDateTime("2020-01-01 13:30:15");
                var db = new Vaccination_ManagementContext();
                List<Appointment2> cabinlist = db.Appointment2s.ToList();
                Appointment2 one = new Appointment2(varDateTime, "Sonsonate",34);
                db.Add(one);
                db.SaveChanges();
            }
        }
    }
}