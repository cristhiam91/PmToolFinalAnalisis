//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PmTool.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factories
    {
        public int Factory_request_id { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Factory_requestor_id { get; set; }
        public Nullable<int> Assigned_pm { get; set; }
        public string Site_name { get; set; }
        public string Program_name { get; set; }
        public string Project_name { get; set; }
        public Nullable<int> Project_phase { get; set; }
        public Nullable<System.DateTime> Request_date { get; set; }
        public Nullable<System.DateTime> Expected_date { get; set; }
        public Nullable<double> Project_budget { get; set; }
        public Nullable<int> Project_type { get; set; }
        public string Factory_name { get; set; }
        public Nullable<int> Total_number_bays { get; set; }
        public Nullable<int> Total_number_ports_per_bay { get; set; }
        public Nullable<int> Total_number_copper_ports_per_bay { get; set; }
        public Nullable<int> Total_number_fiber_ports_per_bay { get; set; }
        public Nullable<int> Speed_connection { get; set; }
        public Nullable<int> Fab_type { get; set; }
        public Nullable<double> Square_footage { get; set; }
        public string Project_description { get; set; }
        public Nullable<int> Scope { get; set; }
    
        public virtual FabScopes FabScopes { get; set; }
        public virtual PhaseTypes PhaseTypes { get; set; }
        public virtual ProjectTypes ProjectTypes { get; set; }
        public virtual SpeedConnectionTypes SpeedConnectionTypes { get; set; }
        public virtual Users Users { get; set; }
    }
}
