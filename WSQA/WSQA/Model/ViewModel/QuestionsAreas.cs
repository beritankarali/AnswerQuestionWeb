using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSQA.Model.DataModel;

namespace WSQA.Model.ViewModel
{
    public class QuestionsAreas
    {
        public int OuestionAreaID { get; set; }
        public string OuestionAreaName { get; set; }

        public static QuestionsAreas MapData(tblQuestionsAreas k)
        {
            QuestionsAreas kul = new QuestionsAreas()
            {
                 OuestionAreaID = k.OuestionAreaID,
                 OuestionAreaName = k.OuestionAreaName,
            
                //tablodakileri sınıflara attık

            };
            return kul;
        }

        public static tblQuestionsAreas MapData(QuestionsAreas k)
        {
            tblQuestionsAreas tk = new tblQuestionsAreas()
            {

                OuestionAreaID = k.OuestionAreaID,
                OuestionAreaName = k.OuestionAreaName,

            };
            return tk;
        }

        public static List<QuestionsAreas> MapData(List<tblQuestionsAreas> List)
        {
            List<QuestionsAreas> liste = new List<QuestionsAreas>();
            foreach (var k in List)
            {
                liste.Add(MapData(k));

            }
            return liste;
        }

        public static List<tblQuestionsAreas> MapData(List<QuestionsAreas> List)
        {
            List<tblQuestionsAreas> liste = new List<tblQuestionsAreas>();

            foreach (var k in List)
            {
                liste.Add(MapData(k));
            }
            return liste;

        }

        
    }
}