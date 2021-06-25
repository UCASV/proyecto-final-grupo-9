using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Dose1xsideEffect
    {
        public int IdSideEffect { get; set; }
        public int IdDose1 { get; set; }
        public string Time { get; set; }

        public virtual Dose1 IdDose1Navigation { get; set; }
        public virtual SideEffect IdSideEffectNavigation { get; set; }
    }
}
