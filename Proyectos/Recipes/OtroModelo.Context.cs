﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Recipes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RecipesEntities1 : DbContext
    {
        public RecipesEntities1()
            : base("name=RecipesEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<RecipeIngredients> RecipeIngredients { get; set; }
        public virtual DbSet<Recipes> Recipes { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<Scores> Scores { get; set; }
    }
}
