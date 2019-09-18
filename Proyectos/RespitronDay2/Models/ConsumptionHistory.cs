using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RespitronDay2.Models
{
    public class ConsumptionHistory
    {
        public int Id { get; set; }

        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public DateTime? ConsumptionDate { get; set; }
        public int O2LitersConsumption { get; set; }
    }
}