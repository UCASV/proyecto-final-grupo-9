using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Dose2xsideEffect
    {
        public int IdSideEffect { get; set; }
        public int IdDose2 { get; set; }
        public string Time { get; set; }

        public virtual Dose2 IdDose2Navigation { get; set; }
        public virtual SideEffect IdSideEffectNavigation { get; set; }
        
        
    }
}
