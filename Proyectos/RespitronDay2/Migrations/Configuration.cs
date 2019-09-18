namespace RespitronDay2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RespitronDay2.Models.RespitronDay2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RespitronDay2.Models.RespitronDay2Context context)
        {
            context.Cities.AddOrUpdate(x => x.Id,
                 new Models.City() { Name = "�lava" },
                 new Models.City() { Name = "Albacete" },
                 new Models.City() { Name = "Alicante" },
                 new Models.City() { Name = "Almer�a" },
                 new Models.City() { Name = "Asturias" },
                 new Models.City() { Name = "�vila" },
                 new Models.City() { Name = "Badajoz" },
                 new Models.City() { Name = "Barcelona" },
                 new Models.City() { Name = "Burgos" },
                 new Models.City() { Name = "C�ceres" },
                 new Models.City() { Name = "C�diz" },
                 new Models.City() { Name = "Cantabria" },
                 new Models.City() { Name = "Castell�n" },
                 new Models.City() { Name = "Ceuta" },
                 new Models.City() { Name = "Ciudad Real" },
                 new Models.City() { Name = "C�rdoba" },
                 new Models.City() { Name = "Cuenca" },
                 new Models.City() { Name = "Gerona" },
                 new Models.City() { Name = "Granada" },
                 new Models.City() { Name = "Guadalajara" },
                 new Models.City() { Name = "Guip�zcoa" },
                 new Models.City() { Name = "Huelva" },
                 new Models.City() { Name = "Huesca" },
                 new Models.City() { Name = "Islas Baleares" },
                 new Models.City() { Name = "Ja�n" },
                 new Models.City() { Name = "La Coru�a" },
                 new Models.City() { Name = "La Rioja" },
                 new Models.City() { Name = "Las Palmas" },
                 new Models.City() { Name = "Le�n" },
                 new Models.City() { Name = "L�rida" },
                 new Models.City() { Name = "Lugo" },
                 new Models.City() { Name = "Madrid" },
                 new Models.City() { Name = "M�laga" },
                 new Models.City() { Name = "Melilla" },
                 new Models.City() { Name = "Murcia" },
                 new Models.City() { Name = "Navarra" },
                 new Models.City() { Name = "Orense" },
                 new Models.City() { Name = "Palencia" },
                 new Models.City() { Name = "Pontevedra" },
                 new Models.City() { Name = "Salamanca" },
                 new Models.City() { Name = "Santa Cruz de Tenerife" },
                 new Models.City() { Name = "Segovia" },
                 new Models.City() { Name = "Sevilla" },
                 new Models.City() { Name = "Soria" },
                 new Models.City() { Name = "Tarragona" },
                 new Models.City() { Name = "Teruel" },
                 new Models.City() { Name = "Toledo" },
                 new Models.City() { Name = "Valencia" },
                 new Models.City() { Name = "Valladolid" },
                 new Models.City() { Name = "Vizcaya" },
                 new Models.City() { Name = "Zamora" },
                 new Models.City() { Name = "Zaragoza" }
             );

            context.Genders.AddOrUpdate(x => x.Id,
                new Models.Gender() { Description = "Female" },
                new Models.Gender() { Description = "Male" }
            );

        }
    }
}
