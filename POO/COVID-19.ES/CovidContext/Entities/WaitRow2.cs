using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class WaitRow2
    {
        public int Id { get; set; }
        public DateTime? DateHour { get; set; }
        public int DuiAppointment2 { get; set; }

        public virtual Appointment2 DuiAppointment2Navigation { get; set; }
        //extra
        public WaitRow2(DateTime DateHour, int DuiAppointment2)
        {
            this.DateHour = DateHour;
            this.DuiAppointment2 = DuiAppointment2;
        }
    }
}
