using System;
using System.Collections.Generic;

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
        }
    }
}
