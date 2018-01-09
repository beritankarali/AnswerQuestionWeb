using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;
namespace WSQA.Model.ViewModel
{
    public class QuestionAnswersAndDislike
    {
        public int QuestionAnwersAndDislikeID { get; set; }
        public int QuestionAnserwsID { get; set; }
        public int UsersID { get; set; }
        public Nullable<bool> QuestionAnserwsLike { get; set; }

        public static QuestionAnswersAndDislike MapData(tblQuestionAnwersAndDislike k)
        {
            QuestionAnswersAndDislike kul = new QuestionAnswersAndDislike()
            {
                QuestionAnserwsLike=k.QuestionAnserwsLike,
                 QuestionAnserwsID=k.QuestionAnserwsID,
                 QuestionAnwersAndDislikeID=k.QuestionAnserwsID,
                 UsersID=k.UsersID
                 //tablodakileri sınıflara attık

            };
            return kul;
        }

        public static tblQuestionAnwersAndDislike MapData(QuestionAnswersAndDislike k)
        {
            tblQuestionAnwersAndDislike tk=new tblQuestionAnwersAndDislike(){

                QuestionAnserwsLike=k.QuestionAnserwsLike,
                QuestionAnserwsID=k.QuestionAnserwsID,
                QuestionAnwersAndDislikeID=k.QuestionAnwersAndDislikeID,
                UsersID=k.UsersID,
                 


            };
            return tk;
        }

        public static List<QuestionAnswersAndDislike> MapData(List<tblQuestionAnwersAndDislike> List)
        {
            List<QuestionAnswersAndDislike> liste = new List<QuestionAnswersAndDislike>();
            foreach (var k in List)
            {
                liste.Add(MapData(k));
                
            }
            return liste;
        }

        public static List<tblQuestionAnwersAndDislike> MapData(List<QuestionAnswersAndDislike> List)
        {
            List<tblQuestionAnwersAndDislike> liste = new List<tblQuestionAnwersAndDislike>();

            foreach (var k in List)
	{
		 liste.Add(MapData(k));
	}
            return liste;

        }




    }
}