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
    
    public partial class tblShares
    {
        public tblShares()
        {
            this.tblTags = new HashSet<tblTags>();
            this.tblSharesComment = new HashSet<tblSharesComment>();
            this.tblSharesLike = new HashSet<tblSharesLike>();
            this.tblSharesLike1 = new HashSet<tblSharesLike>();
        }
    
        public int SharingID { get; set; }
        public string SharingText { get; set; }
        public System.DateTime SharingDate { get; set; }
        public int UserID { get; set; }
        public string SharingImages { get; set; }
    
        public virtual ICollection<tblTags> tblTags { get; set; }
        public virtual tblUsers tblUsers { get; set; }
        public virtual ICollection<tblSharesComment> tblSharesComment { get; set; }
        public virtual ICollection<tblSharesLike> tblSharesLike { get; set; }
        public virtual ICollection<tblSharesLike> tblSharesLike1 { get; set; }
    }
}
