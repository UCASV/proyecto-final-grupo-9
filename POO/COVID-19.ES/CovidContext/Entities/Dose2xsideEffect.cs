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
        
        //extra
        public Dose2xsideEffect(int IdSideEffect, int IdDose2, string Time)
        {
            this.IdSideEffect = IdSideEffect;
            this.IdDose2 = IdDose2;
            this.Time = Time;
            
            //comparar virtual Dose1
            var db = new Vaccination_ManagementContext();
            List<Dose2> Doselist = db.Dose2s
                .ToList();
            
            foreach (var varA in Doselist)
            {
                if (IdDose2 == varA.Id)
                {
                    this.IdDose2Navigation = varA;
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
