using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Appointment1
    {
        public Appointment1()
        {
            Cabinxappointment1s = new HashSet<Cabinxappointment1>();
            WaitRow1s = new HashSet<WaitRow1>();
        }

        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public string Place { get; set; }
        public int DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual ICollection<Cabinxappointment1> Cabinxappointment1s { get; set; }
        public virtual ICollection<WaitRow1> WaitRow1s { get; set; }
    }
}
