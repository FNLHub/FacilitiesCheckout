﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Transportation
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class FacilitiesDBEntities : DbContext
{
    public FacilitiesDBEntities()
        : base("name=FacilitiesDBEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Campus> Campuses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<GasCard> GasCards { get; set; }

    public virtual DbSet<GasCardStatus> GasCardStatuses { get; set; }

    public virtual DbSet<Key> Keys { get; set; }

    public virtual DbSet<SignOut> SignOuts { get; set; }

    public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

    public virtual DbSet<TransporationRequest> TransporationRequests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserStatus> UserStatuses { get; set; }

    public virtual DbSet<VehicleAddon> VehicleAddons { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleStatus> VehicleStatuses { get; set; }

    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

    public virtual DbSet<Admin_Create_GasCard> Admin_Create_GasCard { get; set; }

    public virtual DbSet<Admin_Create_User> Admin_Create_User { get; set; }

    public virtual DbSet<Admin_Create_Vehicle> Admin_Create_Vehicle { get; set; }

    public virtual DbSet<Admin_Transportation_Approval> Admin_Transportation_Approval { get; set; }

    public virtual DbSet<Transportation_SignedOutView> Transportation_SignedOutView { get; set; }

    public virtual DbSet<Transportation_View> Transportation_View { get; set; }

    public virtual DbSet<Transportation_ViewAll> Transportation_ViewAll { get; set; }

    public virtual DbSet<User_Transportation_Log> User_Transportation_Log { get; set; }

}

}

