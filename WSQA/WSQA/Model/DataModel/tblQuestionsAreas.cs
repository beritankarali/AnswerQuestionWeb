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
    
    public partial class tblQuestionsAreas
    {
        public tblQuestionsAreas()
        {
            this.tblQuestionAreaType = new HashSet<tblQuestionAreaType>();
        }
    
        public int OuestionAreaID { get; set; }
        public string OuestionAreaName { get; set; }
    
        public virtual ICollection<tblQuestionAreaType> tblQuestionAreaType { get; set; }
    }
}
