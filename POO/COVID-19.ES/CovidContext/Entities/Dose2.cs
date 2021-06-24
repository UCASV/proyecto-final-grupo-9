using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Dose2
    {
        public Dose2()
        {
            Dose2xsideEffects = new HashSet<Dose2xsideEffect>();
        }

        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public int DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual ICollection<Dose2xsideEffect> Dose2xsideEffects { get; set; }
    }
}
