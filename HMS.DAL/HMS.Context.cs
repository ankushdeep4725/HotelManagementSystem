﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HMS.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HMSEntities : DbContext
    {
        public HMSEntities()
            : base("name=HMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_RoomBooking> tbl_RoomBooking { get; set; }
        public virtual DbSet<tbl_RoomType> tbl_RoomType { get; set; }
        public virtual DbSet<tbl_Staff> tbl_Staff { get; set; }
        public virtual DbSet<tbl_StaffCategory> tbl_StaffCategory { get; set; }
        public virtual DbSet<ROLE> ROLES { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<tbl_Room> tbl_Room { get; set; }
    }
}
