using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class WaitRow1
    {
        public int Id { get; set; }
        public DateTime? DateHour { get; set; }
        public int DuiAppointment1 { get; set; }

        public virtual Appointment1 DuiAppointment1Navigation { get; set; }

        //extra
        /*public WaitRow1(DateTime DateHour, int DuiAppointment1)
        {
            this.DateHour = DateHour;
            this.DuiAppointment1 = DuiAppointment1;
            
            //llenar virtual appointment1
            var db = new Vaccination_ManagementContext();
            List<Appointment1> citizenlist = db.Appointment1s
                .ToList();
            
            foreach (var varA in citizenlist)
            {
                if (DuiAppointment1 == varA.Id)
                {
                    this.DuiAppointment1Navigation = varA;
                }
            }
        }*/
    }
}
