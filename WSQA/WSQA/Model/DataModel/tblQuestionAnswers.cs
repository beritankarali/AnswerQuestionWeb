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
    
    public partial class tblQuestionAnswers
    {
        public tblQuestionAnswers()
        {
            this.tblNotifications = new HashSet<tblNotifications>();
            this.tblQuestionAnwersAndDislike = new HashSet<tblQuestionAnwersAndDislike>();
        }
    
        public int QuestionAnserwsID { get; set; }
        public string AnswerText { get; set; }
        public int AnswerUserID { get; set; }
        public int Accuracy { get; set; }
        public int QuestionID { get; set; }
    
        public virtual ICollection<tblNotifications> tblNotifications { get; set; }
        public virtual tblQuestions tblQuestions { get; set; }
        public virtual tblUsers tblUsers { get; set; }
        public virtual ICollection<tblQuestionAnwersAndDislike> tblQuestionAnwersAndDislike { get; set; }
    }
}
