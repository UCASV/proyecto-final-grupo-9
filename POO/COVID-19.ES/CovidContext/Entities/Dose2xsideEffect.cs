using System;
using System.Collections.Generic;

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
        
        //extra
        public Dose2xsideEffect(int IdSideEffect, int IdDose2, string Time)
        {
            this.IdSideEffect = IdSideEffect;
            this.IdDose2 = IdDose2;
            this.Time = Time;
        }
    }
}
