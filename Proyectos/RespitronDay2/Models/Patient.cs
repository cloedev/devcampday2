using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RespitronDay2.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; } // Nav
        public int GenderId { get; set; } // FK
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfDecease { get; set; }
        public bool Smoker { get; set; }
        public int CigarrettesDailyConsumption { get; set; }
        public City City { get; set; } // Nav
        public int CityId { get; set; } // FK
    }
}