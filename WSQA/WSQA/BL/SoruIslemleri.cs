using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;
using WSQA.Model.ViewModel;

namespace WSQA.BL
{
    public class SoruIslemleri
    {

        public static string SoruSor(Questions q)
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();
                db.tblQuestions.Add(Questions.MapData(q));//questiona gönderip ordaki mapdata ile formatlayıp ekliycek
                db.SaveChanges();//veri tabanındaki yaptığın değişiklikleri kaydeder

                return "işlem başarılı";
            }
            catch (Exception ex)
            {

                return "İşlem başarısız!" + ex.Message;
            }


        }

        public static List<Questions> SoruAra(string s)
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();

                var liste = (db.Database.SqlQuery<tblQuestions>("SELECT *FROM tblQuestion WHERE (UserID+QuestionTitle+QuestionText+QuestionImage) LIKE '%'+s+'%'")).ToList();
                return Questions.MapData(liste);
            }
            catch (Exception ex)
            {

                return null;
            }

        }



        public static string SoruDüzenle(Questions q)
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();
                var soru = (from gon in db.tblQuestions
                            where gon.QuestionID == q.QuestionID
                            select gon).SingleOrDefault();

                soru.QuestionText = q.QuestionText;
                db.SaveChanges();
                return "İslem Başarılı";


            }
            catch (Exception ex)
            {

                return "İşlem başarısız!" + ex.Message;
            }

        }
        public static string SoruSil(int id)
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();
                var soru = (from t in db.tblQuestions
                            where t.QuestionID == id
                            select t
                              ).SingleOrDefault();

                if (soru == null)
                {
                    return "Soru Bulunamadı!";
                }
                else
                {
                    db.tblQuestions.Remove(soru);
                    db.SaveChanges();
                    return "İşlem Başarılı";
                }


            }
            catch (Exception ex)
            {

                return "İşlem başarısız!" + ex.Message;
            }
        }


        public static List<Questions> SoruListele()
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();

                return Questions.MapData(db.tblQuestions.ToList());

            }
            catch (Exception)
            {

                return null;
            }

        }


        public static string SoruCevapla(QuestionAnswers q)
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();

                tblQuestionAnswers x = new tblQuestionAnswers() { QuestionID = q.QuestionID, AnswerUserID = q.AnswerUserID, AnswerText = q.AnswerText };

                db.tblQuestionAnswers.Add(x);

                //var cevap = (from c in db.tblQuestionAnswers//gelen verinin içinde sorunun id sini kullanarak o soruya cevap ekledim
                //             where c.QuestionID == q.QuestionID
                //             select c
                //               ).SingleOrDefault();

                //cevap.AnswerText = q.AnswerText;//Yorum kaydettim
                //cevap.AnswerUserID = q.AnswerUserID;//yorum yazan kişiyi kaydettim
                //cevap.Accuracy = q.Accuracy;



                db.SaveChanges();
                return "İşlem Başarılı";

            }
            catch (Exception)
            {
                return "İşlem Başarılı";
            }


        }

        public static List<QuestionAnswers> CevaplariGoster(int id)
        {
            DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();

            var cevaplar = db.tblQuestionAnswers.Where(q => q.QuestionID == id).ToList();
            var questionList = new List<QuestionAnswers>();
            foreach (var item in cevaplar)
            {
                questionList.Add(new QuestionAnswers()
                {

                    QuestionID = item.QuestionID,
                    AnswerUserID = item.AnswerUserID,
                    AnswerText = item.AnswerText

                });
            }

            return questionList;
        }


        public static string CevapBegen(QuestionLikeAndDislike q)
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();

                var cevap = (from s in db.tblQuestionLikeAndDislike
                             where s.QuestionID == q.QuestionID
                             select s
                              ).SingleOrDefault();
                db.tblQuestionLikeAndDislike.Add(QuestionLikeAndDislike.MapData(q));
                db.SaveChanges();
                return "İşlem Başarılı";


            }
            catch (Exception)
            {

                return "İşlem Başarısız";
            }

        }








        internal static List<Questions> SoruListele(string p1, string p2)
        {
            throw new NotImplementedException();
        }
    }
}