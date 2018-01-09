using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;
using WSQA.Model.ViewModel;

namespace WSQA.BL
{
    public class KullaniciIslemleri
    {
        public static string Kaydol(Users u)
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();

                db.tblUsers.Add(Users.MapData(u));//arayüzden gelen bilgiyi userstaki mapdataya gönder o da formatlar tabloya ekler
                db.SaveChanges();

                return "işlem başarılı";
            }
            catch (Exception ex)
            {
                
                return "İşlem başarısız" + ex.Message;
            }
        }

        public static Users GirisYap(string kulAd,string parola)
        {
            try
            {
                DB_A151C9_beritankEntities db = new DB_A151C9_beritankEntities();
                var kul = (from k in db.tblUsers
                           where k.UserName == kulAd && k.UserPassword == parola
                           select k ).SingleOrDefault();

                if (kul == null)
                {
                    return null;
                }
                else
                {
                    tblUsers u = new tblUsers();
                    u.UserName = kul.UserName;
                    u.UserPassword = kul.UserPassword;
                    db.tblUsers.Add(u);
                    db.SaveChanges();
                
                }
                    return Users.MapData(kul);




            }
            catch (Exception )
            {

                return null;
            }


        }


    }
}