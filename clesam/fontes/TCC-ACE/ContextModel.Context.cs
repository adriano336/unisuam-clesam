﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCC_ACE
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ContextEntities : DbContext
    {
        public ContextEntities()
            : base("name=ContextEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Recurso> Recurso { get; set; }
        public DbSet<TipoRecurso> TipoRecurso { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
