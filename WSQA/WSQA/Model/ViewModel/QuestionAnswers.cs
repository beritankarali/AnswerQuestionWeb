using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;


namespace WSQA.Model.ViewModel
{
    public class QuestionAnswers
    {
        public int QuestionAnserwsID { get; set; }
        public string AnswerText { get; set; }
        public int AnswerUserID { get; set; }
        public int Accuracy { get; set; }
        public int QuestionID { get; set; }

        public static QuestionAnswers MapData(tblQuestionAnswers k)
        {
            QuestionAnswers qa = new QuestionAnswers()
            {
                AnswerUserID = k.AnswerUserID,
                Accuracy = k.Accuracy,
                AnswerText = k.AnswerText,
                QuestionAnserwsID = k.QuestionAnserwsID,
                QuestionID = k.QuestionID//veritabanından gelen veriyi listeye çevirme
            };

            return qa;
        }

       public static tblQuestionAnswers MapData(QuestionAnswers k)
        {
            tblQuestionAnswers tk = new tblQuestionAnswers()
            {
                AnswerUserID = k.AnswerUserID,
                Accuracy = k.Accuracy,
                AnswerText = k.AnswerText,
                QuestionAnserwsID = k.QuestionAnserwsID,
                QuestionID = k.QuestionID

            };
            return tk;//sınıftan gelen veriyi veritabanına gönderiyoruz formatlıyoruz veritabınına göre

        }

       public static List<QuestionAnswers> MapData(List<tblQuestionAnswers> List)
       {
           List<QuestionAnswers> liste = new List<QuestionAnswers>();
           foreach (var k in List)
           {
               liste.Add(MapData(k));//Tablodan gelen listeyi ap data fonksiyonuyla tek tek cevirerek listeyi formatlıyoruz
               //tablo listeye Çevriliyor
           }
           return liste;
       }

       public static List<tblQuestionAnswers> MapData(List<QuestionAnswers> List)
       {
           List<tblQuestionAnswers> liste = new List<tblQuestionAnswers>();
           foreach (var k in List)
           {
               liste.Add(MapData(k));
           }
           return liste;
       }
        




    }
}