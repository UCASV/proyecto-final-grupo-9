using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class RegistrationStart
    {
        public int IdManager { get; set; }
        public int IdCabin { get; set; }
        public DateTime? DateTime { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Manager IdManagerNavigation { get; set; }
    }
}
