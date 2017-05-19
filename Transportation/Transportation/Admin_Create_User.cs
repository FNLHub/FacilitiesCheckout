//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System.ComponentModel.DataAnnotations;

namespace Transportation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin_Create_User
    {
        [Required]
        [MinLength(8)]
        [MaxLength(8)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Please enter your 8 digit BannerId")]
        public string BannerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DepartmentName { get; set; }
        public string StatusName { get; set; }
    }
}
