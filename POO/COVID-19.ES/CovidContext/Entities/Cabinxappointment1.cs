using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Cabinxappointment1
    {
        public int IdCabin { get; set; }
        public int IdAppointment1 { get; set; }

        public virtual Appointment1 IdAppointment1Navigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
//extra
        public Cabinxappointment1 (int IdCabin, int IdAppointment1)
        {
            this.IdCabin = IdCabin;
            this.IdAppointment1 = IdAppointment1;
            
            //comparar virtual appointment
            var db = new Vaccination_ManagementContext();
            List<Appointment1> appointmentlist = db.Appointment1s
                .ToList();
            
            foreach (var varA in appointmentlist)
            {
                if (IdAppointment1 == varA.Id)
                {
                    this.IdAppointment1Navigation = varA;
                }
            }
            //comparar cabin
            List<Cabin> Cabinlist = db.Cabins
                .ToList();

            foreach (var varA in Cabinlist)
            {
                if (IdAppointment1 == varA.Id)
                {
                    this.IdCabinNavigation = varA;
                }
            }
        }
    }
}
