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
    
    public partial class tblSkillsValidation
    {
        public tblSkillsValidation()
        {
            this.tblNotifications = new HashSet<tblNotifications>();
        }
    
        public int SkillsValidationID { get; set; }
        public int UserSkillsID { get; set; }
        public int UserID { get; set; }
    
        public virtual ICollection<tblNotifications> tblNotifications { get; set; }
        public virtual tblUsers tblUsers { get; set; }
        public virtual tblUserSkills tblUserSkills { get; set; }
    }
}
