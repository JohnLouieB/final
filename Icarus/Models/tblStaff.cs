//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Icarus.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblStaff
    {
        public int IDStaff { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string ContactNo { get; set; }
        public Nullable<System.DateTime> DateHired { get; set; }
        public Nullable<System.DateTime> DateTerminated { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string isADG { get; set; }
        public string isEDG { get; set; }
        public string isPG { get; set; }
        public string isAAG { get; set; }
    }
}
