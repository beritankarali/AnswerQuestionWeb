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
    
    public partial class tblSkills
    {
        public tblSkills()
        {
            this.tblSkilsDetails = new HashSet<tblSkilsDetails>();
        }
    
        public int SkillID { get; set; }
        public string SkillsName { get; set; }
    
        public virtual ICollection<tblSkilsDetails> tblSkilsDetails { get; set; }
    }
}
