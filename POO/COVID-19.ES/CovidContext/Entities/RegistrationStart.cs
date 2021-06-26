using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class RegistrationStart
    {
        public int IdManager { get; set; }
        public int IdCabin { get; set; }
        public DateTime? DateHour { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Manager IdManagerNavigation { get; set; }
        //func extra
        public RegistrationStart(int IdManager,int IdCabin, DateTime DateHour)
        {
            this.IdManager = IdManager;
            this.IdCabin = IdCabin;
            this.DateHour = DateHour;
            
            //comparar virtual appointment
            var db = new Vaccination_ManagementContext();
            List<Manager> appointmentlist = db.Managers
                .ToList();
            
            foreach (var varA in appointmentlist)
            {
                if (IdManager == varA.Id)
                {
                    this.IdManagerNavigation = varA;
                }
            }
            //comparar cabin
            List<Cabin> Cabinlist = db.Cabins
                .ToList();

            foreach (var varA in Cabinlist)
            {
                if (IdCabin == varA.Id)
                {
                    this.IdCabinNavigation = varA;
                }
            }
        }
    }
}
