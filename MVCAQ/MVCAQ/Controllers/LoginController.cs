using MVCAQ.ServiceReferansimiz2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAQ.Controllers
{
    public class LoginController : Controller
    {
        AQServiceSoapClient sc = new AQServiceSoapClient();

        //
        // GET: /Login/
        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult GirisYap(string kulAd, string parola)
        //{
        //    //int id = sc.(kulAd, parola);
        //    Users suankiuye = sc.uyebilgileri(id);

        //    Session["id"] = suankiuye.UyeID;
        //    Session["kullaniciadi"] = suankiuye.kuladi;
        //    Session["adi"] = suankiuye.adi;
        //    Session["soyadi"] = suankiuye.soyadi;
        //    Session["eposta"] = suankiuye.eposta;
        //    Session["kayittarihi"] = suankiuye.kayittarihi;
        //    Session["kullaniciresmi"] = suankiuye.kullaniciresmi;
        //    Session["meslek"] = suankiuye.meslek;
        //    var jsonModel = new
        //    {
        //        basari = Session["id"]
        //    };
        //    return Json(jsonModel, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult Login()
        {

            return View();
        }

        //public JsonResult KayitOl(string ad, string soyad, string kullaniciadi, string eposta, string parola, string parolatekrari, HttpPostedFileWrapper kullaniciresmi, string meslek)
        //{
        //    string resimyolu;
        //    if (kullaniciresmi == null)
        //    {
        //        resimyolu = Server.MapPath("/Images/yzmbiz.jpg");
        //    }
        //    else
        //    {
        //        var img = Image.FromStream(kullaniciresmi.InputStream);
        //        resimyolu = "/Images/" + System.IO.Path.GetRandomFileName() + ".jpg";
        //        img.Save(Server.MapPath(resimyolu), ImageFormat.Jpeg);
        //    }
        //}

            
           

            
            //unicidüretme


        //     int id = sc.kayit(kullaniciadi, ad, soyad, parola, eposta, resimyolu,meslek);
        //    Session["id"] = id;
           
        //    var jsonModel = new
        //    {
        //        basari = 1
        //    };
        //    return Json(jsonModel,JsonRequestBehavior.AllowGet);
        //}
        public ActionResult Register()
        {
            return View();
        }
 
        public ActionResult LockScreen()
        {
            return View();
        }
    
	}

}