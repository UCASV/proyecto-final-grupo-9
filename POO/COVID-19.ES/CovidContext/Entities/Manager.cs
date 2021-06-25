using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Manager
    {
        public Manager()
        {
            RegistrationStarts = new HashSet<RegistrationStart>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public string InstitutionalMail { get; set; }
        public string HomeDirection { get; set; }
        public string EmployeeType { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RegistrationStart> RegistrationStarts { get; set; }

        //funcion extra 
        public Manager(int Id, string Password, string InstitutionalMail, string HomeDirection, string EmployeeType, string Name)
        {
            this.Id = Id;
            this.Password = Password;
            this.InstitutionalMail = InstitutionalMail;
            this.HomeDirection = HomeDirection;
            this.EmployeeType = EmployeeType;
            this.Name = Name;
        }
    }
}
