using System;
using System.Collections.Generic;
using System.Linq;

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
        
        ///fun extra
        public Dose2(DateTime DateTime, int DuiCitizen)
        {
            this.DateTime = DateTime;
            this.DuiCitizen = DuiCitizen;
            
            //llenar virtual Citizen
            var db = new Vaccination_ManagementContext();
            List<Citizen> citizenlist = db.Citizens
                .ToList();
            
            foreach (var varA in citizenlist)
            {
                if (DuiCitizen == varA.Dui)
                {
                    this.DuiCitizenNavigation = varA;
                }
            }
        }
    }
}
