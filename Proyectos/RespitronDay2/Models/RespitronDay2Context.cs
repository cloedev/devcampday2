using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RespitronDay2.Models
{
    public class RespitronDay2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RespitronDay2Context() : base("name=RespitronDay2Context")
        {
        }

        public System.Data.Entity.DbSet<RespitronDay2.Models.Gender> Genders { get; set; }

        public System.Data.Entity.DbSet<RespitronDay2.Models.Patient> Patients { get; set; }

        public System.Data.Entity.DbSet<RespitronDay2.Models.ConsumptionHistory> ConsumptionHistories { get; set; }

        public System.Data.Entity.DbSet<RespitronDay2.Models.City> Cities { get; set; }
    }
}
