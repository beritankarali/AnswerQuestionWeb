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
    
    public partial class tblCourseKeyword
    {
        public tblCourseKeyword()
        {
            this.tblCourseKeywords = new HashSet<tblCourseKeywords>();
        }
    
        public int CourseKeywordID { get; set; }
        public string CourseKeyword { get; set; }
    
        public virtual ICollection<tblCourseKeywords> tblCourseKeywords { get; set; }
    }
}
