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
    
    public partial class tblSkilsDetails
    {
        public tblSkilsDetails()
        {
            this.tblJobsSkils = new HashSet<tblJobsSkils>();
            this.tblUserSkills = new HashSet<tblUserSkills>();
        }
    
        public int SkilsDetailsID { get; set; }
        public string SkilsDetailsName { get; set; }
        public int SkillID { get; set; }
    
        public virtual ICollection<tblJobsSkils> tblJobsSkils { get; set; }
        public virtual tblSkills tblSkills { get; set; }
        public virtual ICollection<tblUserSkills> tblUserSkills { get; set; }
    }
}
