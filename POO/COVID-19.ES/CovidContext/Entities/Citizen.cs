using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointment1s = new HashSet<Appointment1>();
            Appointment2s = new HashSet<Appointment2>();
            ChronicDiseases = new HashSet<ChronicDisease>();
            Dose1s = new HashSet<Dose1>();
            Dose2s = new HashSet<Dose2>();
            Institutions = new HashSet<Institution>();
            PriorityGroups = new HashSet<PriorityGroup>();
        }

        public int Dui { get; set; }
        public string Name { get; set; }
        public string Direction { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<Appointment1> Appointment1s { get; set; }
        public virtual ICollection<Appointment2> Appointment2s { get; set; }
        public virtual ICollection<ChronicDisease> ChronicDiseases { get; set; }
        public virtual ICollection<Dose1> Dose1s { get; set; }
        public virtual ICollection<Dose2> Dose2s { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
        public virtual ICollection<PriorityGroup> PriorityGroups { get; set; }
        
        //funcion agregada
        
        public Citizen(int Dui, string Name, string Direction, string Phone, string Mail)
        {
            this.Dui = Dui;
            this.Name = Name;
            this.Direction = Direction;
            this.Phone = Phone;
            this.Mail = Mail;
        }
    }
}
