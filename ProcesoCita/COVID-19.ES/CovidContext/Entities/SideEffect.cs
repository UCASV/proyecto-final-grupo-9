using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            Dose1xsideEffects = new HashSet<Dose1xsideEffect>();
            Dose2xsideEffects = new HashSet<Dose2xsideEffect>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Dose1xsideEffect> Dose1xsideEffects { get; set; }
        public virtual ICollection<Dose2xsideEffect> Dose2xsideEffects { get; set; }
    }
}
