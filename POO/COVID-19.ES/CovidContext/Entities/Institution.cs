﻿using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace COVID_19.ES.CovidContext
{
    public partial class Institution
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DuiCitizen { get; set; }

        public virtual Citizen DuiCitizenNavigation { get; set; }
        
        //fun extra
        public Institution(int Id,string Name, int DuiCitizen)
        {
            this.Id = Id;
            this.Name = Name;
            this.DuiCitizen = DuiCitizen;
            
            //revisar posible error
            //llenar virtual Citizen
            var db = new Vaccination_ManagementContext();
            List<Citizen> citizenlist = db.Citizens
                .ToList();
            
            var dataEntered = citizenlist.Where(
                U => U.Dui.Equals(DuiCitizen) 
            ).ToList();

            this.DuiCitizenNavigation = dataEntered.First();
        }
    }
}