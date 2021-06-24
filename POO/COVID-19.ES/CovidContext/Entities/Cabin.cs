﻿using System;
using System.Collections.Generic;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            Cabinxappointment1s = new HashSet<Cabinxappointment1>();
            Cabinxappointment2s = new HashSet<Cabinxappointment2>();
            RegistrationStarts = new HashSet<RegistrationStart>();
        }

        public int Id { get; set; }
        public string Direction { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<Cabinxappointment1> Cabinxappointment1s { get; set; }
        public virtual ICollection<Cabinxappointment2> Cabinxappointment2s { get; set; }
        public virtual ICollection<RegistrationStart> RegistrationStarts { get; set; }
    }
}
