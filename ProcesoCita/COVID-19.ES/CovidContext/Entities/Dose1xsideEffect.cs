using System;
using System.Collections.Generic;
using System.Linq;

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
        
        //extra
        public Dose1xsideEffect(int IdSideEffect, int IdDose1, string Time)
        {
            this.IdSideEffect = IdSideEffect;
            this.IdDose1 = IdDose1;
            this.Time = Time;
            
            //comparar virtual Dose1
            var db = new Vaccination_ManagementContext();
            List<Dose1> Doselist = db.Dose1s
                .ToList();
            
            foreach (var varA in Doselist)
            {
                if (IdDose1 == varA.Id)
                {
                    this.IdDose1Navigation = varA;
                }
            }
            //comparar sideEffectlist
            List<SideEffect> sideEffectlist = db.SideEffects
                .ToList();

            foreach (var varA in sideEffectlist)
            {
                if ( IdSideEffect == varA.Id)
                {
                    this.IdSideEffectNavigation = varA;
                }
            }
        }
    }
}
