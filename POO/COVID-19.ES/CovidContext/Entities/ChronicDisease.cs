using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class ChronicDisease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        
        //extra
        public ChronicDisease(string Name, int DuiCitizen)
        {
            this.Name = Name;
            this.DuiCitizen = DuiCitizen;
            
            //comparando virtual Citizen
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
