﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPH_Lufthavn
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AirplaneEntities2 : DbContext
    {
        public AirplaneEntities2()
            : base("name=AirplaneEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Airplane> Airplanes { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<FlightCompany> FlightCompanies { get; set; }
    }
}
