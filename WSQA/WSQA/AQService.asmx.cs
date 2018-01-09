using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WSQA.Model.ViewModel;
using WSQA.BL;

namespace WSQA
{
    /// <summary>
    /// Summary description for AQService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AQService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Kaydol(Users u)
        {
            return KullaniciIslemleri.Kaydol(u);
        }

        [WebMethod]
        public Users GirisYap(LoginData d)
        {
            return KullaniciIslemleri.GirisYap(d.UserName, d.UserPassword);
        }
        [WebMethod]
        public string SoruSor(Questions q)
        {
            return SoruIslemleri.SoruSor(q);
        }
        [WebMethod]
        public string SoruSil(int id)
        {
            return SoruIslemleri.SoruSil(id);
        }
        [WebMethod]
        public List<Questions> SoruListele()
        {
            return SoruIslemleri.SoruListele();
        }

        [WebMethod]
        public List<Questions> SoruAra(string s)
        {
            return SoruIslemleri.SoruAra(s);
        }

        [WebMethod]
        public string SoruDuzenle(Questions q)
        {
            return SoruIslemleri.SoruDüzenle(q);
        }
        [WebMethod]
        public string SoruCevapla(QuestionAnswers q)
        {
            return SoruIslemleri.SoruCevapla(q);
        }

        [WebMethod]
        public List<QuestionAnswers> CevaplariGoster(int id)
        {
            return SoruIslemleri.CevaplariGoster(id);
        }
    }
}
