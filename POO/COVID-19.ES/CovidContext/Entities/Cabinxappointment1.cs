using System;
using System.Collections.Generic;

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
        }
    }
}
