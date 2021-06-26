using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        
        //fun extra
        public Institution(int Id,string Name, int DuiCitizen)
        {
            this.Id = Id;
            this.Name = Name;
            this.DuiCitizen = DuiCitizen;
        }
    }
}
