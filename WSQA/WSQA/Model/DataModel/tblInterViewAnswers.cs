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
    
    public partial class tblInterViewAnswers
    {
        public int InterViewAnswersID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string InterViewAnswers { get; set; }
        public Nullable<int> InterviewID { get; set; }
        public Nullable<System.DateTime> QuesAnswersStart { get; set; }
        public Nullable<System.DateTime> QuesAnswersFinish { get; set; }
        public string InterviweFileExtends { get; set; }
    
        public virtual tblInterView tblInterView { get; set; }
        public virtual tblUsers tblUsers { get; set; }
    }
}