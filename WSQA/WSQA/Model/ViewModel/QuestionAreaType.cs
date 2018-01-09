using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;

namespace WSQA.Model.ViewModel
{
    public class QuestionAreaType
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int AreaID { get; set; }



        public static QuestionAreaType MapData(tblQuestionAreaType k)
        {
            QuestionAreaType kul = new QuestionAreaType()
            {
                SubjectID = k.SubjectID,
                SubjectName = k.SubjectName,
                AreaID = k.AreaID
                
                //tablodakileri sınıflara attık

            };
            return kul;
        }

        public static tblQuestionAreaType MapData(QuestionAreaType k)
        {
            tblQuestionAreaType tk = new tblQuestionAreaType()
            {

                SubjectID = k.SubjectID,
                SubjectName = k.SubjectName,
                AreaID = k.AreaID

            };
            return tk;
        }

        public static List<QuestionAreaType> MapData(List<tblQuestionAreaType> List)
        {
            List<QuestionAreaType> liste = new List<QuestionAreaType>();
            foreach (var k in List)
            {
                liste.Add(MapData(k));

            }
            return liste;
        }

        public static List<tblQuestionAreaType> MapData(List<QuestionAreaType> List)
        {
            List<tblQuestionAreaType> liste = new List<tblQuestionAreaType>();

            foreach (var k in List)
            {
                liste.Add(MapData(k));
            }
            return liste;

        }






    }
}