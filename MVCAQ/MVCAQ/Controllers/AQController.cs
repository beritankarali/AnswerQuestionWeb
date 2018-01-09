using MVCAQ.ServiceReferansimiz2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAQ.Controllers
{
    public class AQController : Controller
    {
        
        //
        public ActionResult Index()
        {
           
            return View();
        }

        // GET: /AQ/
        public ActionResult Giris()
        {
            return View();
        }
     
        [HttpPost]
       public ActionResult GirisYap(ServiceReferansimiz2.LoginData d)
        {
            ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();

            ServiceReferansimiz2.Users kul = t.GirisYap(d);

            if (kul != null)
            {
                Response.Cookies["UserID"].Value = kul.UserID.ToString();
                Response.Cookies["UserName"].Value = kul.UserName.ToString();
                  Response.Cookies["UserPassword"].Value = kul.UserPassword.ToString();

                HttpCookie aCookie = new HttpCookie("lastVisit");
                Response.Cookies.Add(aCookie);
                return RedirectToAction("Index");

            }
            else
                return View();
        }
        public JsonResult Kaydol(ServiceReferansimiz2.Users kul)
        {
           
            ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
            return Json(t.Kaydol(kul));
        }


        public ActionResult SoruListele()
        {            
            return View();
        }
        [HttpPost]
        public JsonResult x()
        {
         ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
         object sorular = t.SoruListele();
         
          return Json(sorular);
        }

        [HttpPost]
        public JsonResult xSayi()
        {
            ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
            var sorular = t.SoruListele();
            int soruSayisi = sorular.Length;
            return Json(soruSayisi);
        }


        [HttpPost]
        public JsonResult xCevap(int id)
        {
            ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
            var cevaplar = t.CevaplariGoster(id);
            int soruSayisi = cevaplar.Length;
            return Json(soruSayisi);
        }

        public JsonResult CevapGoster(int id)
        {
            ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
            var cevaplar = t.CevaplariGoster(id);
            return Json(cevaplar);
        }

        [HttpPost]
        public JsonResult CevapEkle(int id, string message)
        {
            ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
            var turningMessage = t.SoruCevapla(new QuestionAnswers() { QuestionID=id, AnswerText=message, AnswerUserID=7});

            return Json(turningMessage);
        }
        
        //[HttpPost]
        //public JsonResult CevaplariGetir(int SoruID)
        //{
        //    ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
          
        //}



        //[HttpPost]
        //public JsonResult SoruListele(ServiceReferansimiz2.Question d)
        //{
        //    ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();

           

        //    ServiceReferansimiz2.Questions q = t.SoruListele(d.QuestionTitle,d.QuestionText);

        //    return Json(t.SoruListele(q));
        //}


        //public ActionResult SORULAR()
        //{
        //    ServiceReferansimiz2.AQServiceSoapClient t=new ServiceReferansimiz2.AQServiceSoapClient();
        //return Json(t.SoruListele());
          
        //}
      
        public ActionResult SoruSor()
        {
            
            return View();
        }
        [HttpPost]
        public JsonResult SoruSor(ServiceReferansimiz2.Questions tw)
        {
            ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
            //int id = int.Parse(Request.Cookies["UserID"].Value.ToString())
            return Json(t.SoruSor(tw));
        }



        //public ActionResult SoruSor(ServiceReferansimiz2.QuestionData q)
        //{
        //    ServiceReferansimiz2.AQServiceSoapClient t = new ServiceReferansimiz2.AQServiceSoapClient();
        //    return View(t.SoruSor(q));

        //    ////int id = int.Parse(Request.Cookies["UserID"].Value.ToString());
        //    ////q.UserID = id;
        //    ////q.Zaman = DateTime.Now;
        //    //return Json(t.SoruSor(q));
        //    ////ServiceReferansimiz2.Questions sor = t.SoruSor(q);
         
        //}
        //ServiceReferansimiz.Service1Client service = new ServiceReferansimiz.Service1Client();
        public JsonResult Cikis()
        {
            Response.Cookies["UserID"].Value = null;
            //Response.Cookies["UserID"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["UserName"].Value = null;
            //Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);

            HttpCookie aCookie = new HttpCookie("lastVisit");
            //aCookie.Value = DateTime.Now.ToString();
            //aCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(aCookie);
            return Json("+");

        }
        //[HttpPost]
        //public ActionResult SoruSor(ServiceReferansimiz2.QuestionData q)
        //{
        //    ServiceReferansimiz2.AQServiceSoapClient a = new ServiceReferansimiz2.AQServiceSoapClient();
        //    ServiceReferansimiz2.Questions questions =a.SoruSor(q);
        //    int id = int.Parse(Request.Cookies["UserID"].Value.ToString());
        //    q.UserID = id;
        //    //q.Zaman = DateTime.Now;
        //    return RedirectToAction("Index");
           
        //}

        //ServiceReferansimiz2.Users kul = t.GirisYap(d);
      //MVCAQ.ServiceReferansimiz2.SoruSorRequest inValue = new MVCAQ.ServiceReferansimiz2.SoruSorRequest();
      //      inValue.Body = new MVCAQ.ServiceReferansimiz2.SoruSorRequestBody();
      //      inValue.Body.q = q;
      //      MVCAQ.ServiceReferansimiz2.SoruSorResponse retVal = ((MVCAQ.ServiceReferansimiz2.AQServiceSoap)(this)).SoruSor(inValue);
      //      return retVal.Body.SoruSorResult;

	}
}