//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSQA.Model.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblJobApplications
    {
        public int JobApplicationsID { get; set; }
        public int JobID { get; set; }
        public int UserID { get; set; }
        public string ApplicationText { get; set; }
    
        public virtual tblJobs tblJobs { get; set; }
        public virtual tblUsers tblUsers { get; set; }
    }
}
