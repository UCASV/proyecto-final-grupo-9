using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Appointment2
    {
        public Appointment2()
        {
            Cabinxappointment2s = new HashSet<Cabinxappointment2>();
            WaitRow2s = new HashSet<WaitRow2>();
        }

        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public string Place { get; set; }
        public int DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual ICollection<Cabinxappointment2> Cabinxappointment2s { get; set; }
        public virtual ICollection<WaitRow2> WaitRow2s { get; set; }
        
        public Appointment2( DateTime DateTime, string Place, int DuiCitizen)
        {
            this.DateTime = DateTime;
            this.Place = Place;
            this.DuiCitizen = DuiCitizen;
        }
    }
}
