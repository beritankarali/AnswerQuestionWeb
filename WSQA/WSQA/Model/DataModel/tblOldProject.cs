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
    
    public partial class tblOldProject
    {
        public int OldProjectID { get; set; }
        public string OldProjectName { get; set; }
        public int UsersID { get; set; }
        public string OldProjectDesc { get; set; }
        public string Teknolojis { get; set; }
        public Nullable<int> WorksID { get; set; }
    
        public virtual tblUsers tblUsers { get; set; }
        public virtual tblWorks tblWorks { get; set; }
    }
}
