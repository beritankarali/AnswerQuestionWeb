using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WSQA.Model.ViewModel
{
    public class QuestionData:Users
    {
        public string QuestionTitle { get; set; }
        public string QuestionText { get; set; }
    }
}