using System;
using System.Collections.Generic;
using System.Linq;

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
            
            //llenar virtual appointment1
            var db = new Vaccination_ManagementContext();
            List<Appointment2> citizenlist = db.Appointment2s
                .ToList();
            
            foreach (var varA in citizenlist)
            {
                if (DuiAppointment2 == varA.Id)
                {
                    this.DuiAppointment2Navigation = varA;
                }
            }
        }
    }
}
