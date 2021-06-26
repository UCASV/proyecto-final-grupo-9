using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Cabinxappointment2
    {
        public int IdCabin { get; set; }
        public int IdAppointment2 { get; set; }

        public virtual Appointment2 IdAppointment2Navigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
        public Cabinxappointment2(int IdCabin, int IdAppointment2)
        {
            this.IdCabin = IdCabin;
            this.IdAppointment2 = IdAppointment2;
            
            //comparar virtual appointment
            var db = new Vaccination_ManagementContext();
            List<Appointment2> appointmentlist = db.Appointment2s
                .ToList();
            
            foreach (var varA in appointmentlist)
            {
                if (IdAppointment2 == varA.Id)
                {
                    this.IdAppointment2Navigation = varA;
                }
            }
            //comparar cabin
            List<Cabin> Cabinlist = db.Cabins
                .ToList();

            foreach (var varA in Cabinlist)
            {
                if (IdAppointment2 == varA.Id)
                {
                    this.IdCabinNavigation = varA;
                }
            }
        }
    }
}
