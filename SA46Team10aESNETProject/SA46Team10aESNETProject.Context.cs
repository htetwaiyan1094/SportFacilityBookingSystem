﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA46Team10ASportsFacilityBookingSystem
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SA46Team10aESNETProjectEntities : DbContext
    {
        public SA46Team10aESNETProjectEntities()
            : base("name=SA46Team10aESNETProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Timing> Timings { get; set; }
        public virtual DbSet<ViewBookingCount> ViewBookingCounts { get; set; }
        public virtual DbSet<viewMemRpt> viewMemRpts { get; set; }
        public virtual DbSet<viewOccu> viewOccus { get; set; }
        public virtual DbSet<viewAgeCount> viewAgeCounts { get; set; }
        public virtual DbSet<viewBookRec> viewBookRecs { get; set; }
    }
}
