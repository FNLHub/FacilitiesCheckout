//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportationDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class DriverGroup
    {
        public int DriverGroupId { get; set; }
        public int TranRequestId { get; set; }
        public int UserId { get; set; }
        public int VehicleTypeId { get; set; }
        public Nullable<int> VehicleAddOnId { get; set; }
        public Nullable<bool> NeedGasCard { get; set; }
    
        public virtual User User { get; set; }
    }
}