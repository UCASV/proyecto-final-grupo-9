using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class WaitRow2
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public int DuiAppointment2 { get; set; }

        public virtual Appointment2 DuiAppointment2Navigation { get; set; }
        //extra
        
    }
}
