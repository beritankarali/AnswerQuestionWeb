using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace WSQA
{
    [ServiceContract]
   public interface Iservice
    {
       [OperationContract]
       bool SoruSor(string soruBasligi, string soruIcerigi, int soruSahibi, DateTime soruTarihi, int favori);

       [OperationContract]
       bool cevapekle(string cevapBasligi, string cevapİcerigi, int cevapSahibi, int soruNo, int yorumID);

       
      
    }
}
