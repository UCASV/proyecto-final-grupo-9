using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InstID { get; set; }
        public int DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        
        //fun extra
    }
}
