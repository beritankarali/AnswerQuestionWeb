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
    
    public partial class tblSharesComment
    {
        public tblSharesComment()
        {
            this.tblNotifications = new HashSet<tblNotifications>();
        }
    
        public int SharesCommentID { get; set; }
        public System.DateTime SharesCommentDate { get; set; }
        public int SharesCommentUsersID { get; set; }
        public string SharesCommentText { get; set; }
        public int SharingID { get; set; }
    
        public virtual ICollection<tblNotifications> tblNotifications { get; set; }
        public virtual tblShares tblShares { get; set; }
        public virtual tblUsers tblUsers { get; set; }
    }
}