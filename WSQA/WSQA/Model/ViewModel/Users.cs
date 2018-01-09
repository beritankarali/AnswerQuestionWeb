using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;
namespace WSQA.Model.ViewModel
{
    public class Users
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string TelNumber { get; set; }
        public int UserTypeID { get; set; }


        public static Users MapData(tblUsers k)
        {
            Users kul = new Users()
            {
                 Email = k.Email,
                 TelNumber = k.TelNumber,
                UserName = k.UserName,
                UserPassword = k.UserPassword,
                 UserSurname = k.UserSurname,
                 UserID = k.UserID,
                  UserTypeID=k.UserTypeID
                //tablodakileri sınıflara attık

            };
            return kul;
        }

        public static tblUsers MapData(Users k)
        {
            tblUsers tk = new tblUsers()
            {

                Email = k.Email,
                TelNumber = k.TelNumber,
                UserName = k.UserName,
                UserPassword = k.UserPassword,
                UserSurname = k.UserSurname,
                UserID = k.UserID,
                UserTypeID = k.UserTypeID

            };
            return tk;
        }

        public static List<Users> MapData(List<tblUsers> List)
        {
            List<Users> liste = new List<Users>();
            foreach (var k in List)
            {
                liste.Add(MapData(k));

            }
            return liste;
        }

        public static List<tblUsers> MapData(List<Users> List)
        {
            List<tblUsers> liste = new List<tblUsers>();

            foreach (var k in List)
            {
                liste.Add(MapData(k));
            }
            return liste;

        }
    }
}