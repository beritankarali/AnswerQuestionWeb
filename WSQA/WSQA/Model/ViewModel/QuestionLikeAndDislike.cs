using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;

namespace WSQA.Model.ViewModel
{
    public class QuestionLikeAndDislike
    {
        public int QuestionLikeAndDislikeID { get; set; }
        public int QuestionID { get; set; }
        public int UserID { get; set; }
        public Nullable<bool> QuestionLike { get; set; }

        public static QuestionLikeAndDislike MapData(tblQuestionLikeAndDislike k)
        {
            QuestionLikeAndDislike kul = new QuestionLikeAndDislike()
            {
                QuestionID  = k.QuestionID,
                 QuestionLike  = k.QuestionLike,
                UserID  = k.UserID,
                QuestionLikeAndDislikeID=k.QuestionLikeAndDislikeID,

                //tablodakileri sınıflara attık

            };
            return kul;
        }

        public static tblQuestionLikeAndDislike MapData(QuestionLikeAndDislike k)
        {
            tblQuestionLikeAndDislike tk = new tblQuestionLikeAndDislike()
            {

                QuestionID = k.QuestionID,
                QuestionLike = k.QuestionLike,
                UserID = k.UserID,
                QuestionLikeAndDislikeID = k.QuestionLikeAndDislikeID,

            };
            return tk;
        }

        public static List<QuestionLikeAndDislike> MapData(List<tblQuestionLikeAndDislike> List)
        {
            List<QuestionLikeAndDislike> liste = new List<QuestionLikeAndDislike>();
            foreach (var k in List)
            {
                liste.Add(MapData(k));

            }
            return liste;
        }

        public static List<tblQuestionLikeAndDislike> MapData(List<QuestionLikeAndDislike> List)
        {
            List<tblQuestionLikeAndDislike> liste = new List<tblQuestionLikeAndDislike>();

            foreach (var k in List)
            {
                liste.Add(MapData(k));
            }
            return liste;

        }







    }
}