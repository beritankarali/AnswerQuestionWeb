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
    
    public partial class tblUserType
    {
        public tblUserType()
        {
            this.tblUsers = new HashSet<tblUsers>();
        }
    
        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }
    
        public virtual ICollection<tblUsers> tblUsers { get; set; }
    }
}