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
    
    public partial class tblUsers
    {
        public tblUsers()
        {
            this.tblCompanies = new HashSet<tblCompanies>();
            this.tblConferenceCourses = new HashSet<tblConferenceCourses>();
            this.tblCourseComment = new HashSet<tblCourseComment>();
            this.tblCourseRate = new HashSet<tblCourseRate>();
            this.tblFollowing = new HashSet<tblFollowing>();
            this.tblFollowRequest = new HashSet<tblFollowRequest>();
            this.tblHobbies = new HashSet<tblHobbies>();
            this.tblInterViewAnswers = new HashSet<tblInterViewAnswers>();
            this.tblJobApplications = new HashSet<tblJobApplications>();
            this.tblMessages = new HashSet<tblMessages>();
            this.tblNotifications = new HashSet<tblNotifications>();
            this.tblOldProject = new HashSet<tblOldProject>();
            this.tblPersonelEducation = new HashSet<tblPersonelEducation>();
            this.tblProfiles = new HashSet<tblProfiles>();
            this.tblProjectAds = new HashSet<tblProjectAds>();
            this.tblQuestionAnswers = new HashSet<tblQuestionAnswers>();
            this.tblQuestionAnwersAndDislike = new HashSet<tblQuestionAnwersAndDislike>();
            this.tblQuestionLikeAndDislike = new HashSet<tblQuestionLikeAndDislike>();
            this.tblQuestions = new HashSet<tblQuestions>();
            this.tblReferences = new HashSet<tblReferences>();
            this.tblShares = new HashSet<tblShares>();
            this.tblSharesComment = new HashSet<tblSharesComment>();
            this.tblSharesLike = new HashSet<tblSharesLike>();
            this.tblSharesLike1 = new HashSet<tblSharesLike>();
            this.tblSkillsValidation = new HashSet<tblSkillsValidation>();
            this.tblUserLanguages = new HashSet<tblUserLanguages>();
            this.tblUsersCourses = new HashSet<tblUsersCourses>();
            this.tblUserSkills = new HashSet<tblUserSkills>();
        }
    
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public int UserTypeID { get; set; }
    
        public virtual ICollection<tblCompanies> tblCompanies { get; set; }
        public virtual ICollection<tblConferenceCourses> tblConferenceCourses { get; set; }
        public virtual ICollection<tblCourseComment> tblCourseComment { get; set; }
        public virtual ICollection<tblCourseRate> tblCourseRate { get; set; }
        public virtual ICollection<tblFollowing> tblFollowing { get; set; }
        public virtual ICollection<tblFollowRequest> tblFollowRequest { get; set; }
        public virtual ICollection<tblHobbies> tblHobbies { get; set; }
        public virtual ICollection<tblInterViewAnswers> tblInterViewAnswers { get; set; }
        public virtual ICollection<tblJobApplications> tblJobApplications { get; set; }
        public virtual ICollection<tblMessages> tblMessages { get; set; }
        public virtual ICollection<tblNotifications> tblNotifications { get; set; }
        public virtual ICollection<tblOldProject> tblOldProject { get; set; }
        public virtual ICollection<tblPersonelEducation> tblPersonelEducation { get; set; }
        public virtual ICollection<tblProfiles> tblProfiles { get; set; }
        public virtual ICollection<tblProjectAds> tblProjectAds { get; set; }
        public virtual tblProjectApplications tblProjectApplications { get; set; }
        public virtual ICollection<tblQuestionAnswers> tblQuestionAnswers { get; set; }
        public virtual ICollection<tblQuestionAnwersAndDislike> tblQuestionAnwersAndDislike { get; set; }
        public virtual ICollection<tblQuestionLikeAndDislike> tblQuestionLikeAndDislike { get; set; }
        public virtual ICollection<tblQuestions> tblQuestions { get; set; }
        public virtual ICollection<tblReferences> tblReferences { get; set; }
        public virtual ICollection<tblShares> tblShares { get; set; }
        public virtual ICollection<tblSharesComment> tblSharesComment { get; set; }
        public virtual ICollection<tblSharesLike> tblSharesLike { get; set; }
        public virtual ICollection<tblSharesLike> tblSharesLike1 { get; set; }
        public virtual ICollection<tblSkillsValidation> tblSkillsValidation { get; set; }
        public virtual ICollection<tblUserLanguages> tblUserLanguages { get; set; }
        public virtual tblUserType tblUserType { get; set; }
        public virtual ICollection<tblUsersCourses> tblUsersCourses { get; set; }
        public virtual ICollection<tblUserSkills> tblUserSkills { get; set; }
    }
}
