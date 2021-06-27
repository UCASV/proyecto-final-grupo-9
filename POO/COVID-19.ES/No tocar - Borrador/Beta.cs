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
                Manager one = new Manager(210, "735t1", "micorreo@gmail.com", "bulebar 1", "Jefe", "Rian Carlos");
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
            
            //dose1
            if (false)
            {
                DateTime varDateTime = Convert.ToDateTime("2020-01-01 13:30:15");
                var db = new Vaccination_ManagementContext();
                List<Dose1> cabinlist = db.Dose1s.ToList();
                Dose1 one = new Dose1(varDateTime, 34);
                db.Add(one);
                db.SaveChanges();
            }
            
            //dose2
            if (false)
            {
                DateTime varDateTime = Convert.ToDateTime("2020-01-01 13:30:15");
                var db = new Vaccination_ManagementContext();
                List<Dose2> cabinlist = db.Dose2s.ToList();
                Dose2 one = new Dose2(varDateTime, 34);
                db.Add(one);
                db.SaveChanges();
            }
            
            
            //Dose1xsideEffect
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<Dose1xsideEffect> cabinlist = db.Dose1xsideEffects.ToList();
                Dose1xsideEffect one = new Dose1xsideEffect(1,1,"20");
                db.Add(one);
                db.SaveChanges();
            }
            
            //Dose2xsideEffect
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<Dose2xsideEffect> cabinlist = db.Dose2xsideEffects.ToList();
                Dose2xsideEffect one = new Dose2xsideEffect(1,1,"20");
                db.Add(one);
                db.SaveChanges();
            }
            
            //Cabinxappointment1
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<Cabinxappointment1> cabinxappointment1list = db.Cabinxappointment1s.ToList();
                Cabinxappointment1 one = new Cabinxappointment1(1,1);
                db.Add(one);
                db.SaveChanges();
            }
            //Cabinxappointment2
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<Cabinxappointment2> cabinxappointment1list = db.Cabinxappointment2s.ToList();
                Cabinxappointment2 one = new Cabinxappointment2(1,1);
                db.Add(one);
                db.SaveChanges();
            }
            
            //PriorityGroup
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<PriorityGroup> cabinxappointment1list = db.PriorityGroups.ToList();
                PriorityGroup one = new PriorityGroup("Grupo 1",1);
                db.Add(one);
                db.SaveChanges();
            }
            
            //PriorityGroup
            if (false)
            {
                var db = new Vaccination_ManagementContext();
                List<PriorityGroup> cabinxappointment1list = db.PriorityGroups.ToList();
                PriorityGroup one = new PriorityGroup("Grupo 1",1);
                db.Add(one);
                db.SaveChanges();
            }
            
            
            //RegistrationStart 
            if (false)
            {
                DateTime varDateTime = Convert.ToDateTime("2020-01-01 13:30:15");
                var db = new Vaccination_ManagementContext();
                List<RegistrationStart> cabinlist = db.RegistrationStarts.ToList();
                var one = new RegistrationStart()
                {
                    IdCabin = 1,
                    IdManager = 1,
                    DateTime = varDateTime
                };
                //WaitRow1 one = new WaitRow1( varDateTime,1);
                db.Add(one);
                db.SaveChanges();
            }
            
            //WaitRow1
            if (false)
            {
                DateTime varDateTime = Convert.ToDateTime("2020-01-01 13:30:15");
                var db = new Vaccination_ManagementContext();
                List<WaitRow1> cabinlist = db.WaitRow1s.ToList();
                var one = new WaitRow1()
                {
                    DateTime = varDateTime,
                    DuiAppointment1 = 1
                };
                //WaitRow1 one = new WaitRow1( varDateTime,1);
                db.Add(one);
                db.SaveChanges();
            }
            
            //WaitRow2
            if (false)
            {
                DateTime varDateTime = Convert.ToDateTime("2020-01-01 13:30:15");
                var db = new Vaccination_ManagementContext();
                List<WaitRow2> cabinlist = db.WaitRow2s.ToList();
                var one = new WaitRow2()
                {
                    DateTime = varDateTime,
                    DuiAppointment2 = 1
                };
                db.Add(one);
                db.SaveChanges();
            }
        }
    }
}