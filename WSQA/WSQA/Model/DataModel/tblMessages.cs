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
    
    public partial class tblMessages
    {
        public int MessageID { get; set; }
        public int MessagePostID { get; set; }
        public int UserID { get; set; }
        public string MessageText { get; set; }
        public System.DateTime MessageDate { get; set; }
        public Nullable<bool> Seen { get; set; }
    
        public virtual tblUsers tblUsers { get; set; }
    }
}