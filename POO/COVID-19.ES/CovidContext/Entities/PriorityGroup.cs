using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class PriorityGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        
        //extra
        
    }
}
