using System;
using System.Collections.Generic;

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
        }
    }
}
