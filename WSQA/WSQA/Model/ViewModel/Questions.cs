using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;

namespace WSQA.Model.ViewModel
{
    public class Questions
    {
        public int QuestionID { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionText { get; set; }
        public int UserID { get; set; }
        public int SubjectID { get; set; }
        public string QuestionImage { get; set; }

        public static Questions MapData(tblQuestions k)
        {
            Questions kul = new Questions()
            {
                QuestionID = k.QuestionID,
                QuestionImage = k.QuestionImage,
                QuestionText = k.QuestionText,
                QuestionTitle = k.QuestionTitle,
                SubjectID = k.SubjectID,
                UserID = k.UserID
                //tablodakileri sınıflara attık

            };
            return kul;
        }

        public static tblQuestions MapData(Questions k)
        {
            tblQuestions tk = new tblQuestions()
            {

                QuestionID = k.QuestionID,
                QuestionImage = k.QuestionImage,
                QuestionText = k.QuestionText,
                QuestionTitle = k.QuestionTitle,
                SubjectID = k.SubjectID,
                UserID = k.UserID

            };
            return tk;
        }

        public static List<Questions> MapData(List<tblQuestions> List)
        {
            List<Questions> liste = new List<Questions>();
            foreach (var k in List)
            {
                liste.Add(MapData(k));

            }
            return liste;
        }

        public static List<tblQuestions> MapData(List<Questions> List)
        {
            List<tblQuestions> liste = new List<tblQuestions>();

            foreach (var k in List)
            {
                liste.Add(MapData(k));
            }
            return liste;

        }





    }
}