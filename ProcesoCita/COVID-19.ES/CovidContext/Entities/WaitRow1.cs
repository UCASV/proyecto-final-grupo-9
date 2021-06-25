using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class WaitRow1
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public int DuiAppointment1 { get; set; }

        public virtual Appointment1 DuiAppointment1Navigation { get; set; }
    }
}
