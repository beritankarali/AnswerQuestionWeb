//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSQA.Model.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProvinces
    {
        public tblProvinces()
        {
            this.tblDistricts = new HashSet<tblDistricts>();
        }
    
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public int CountryID { get; set; }
    
        public virtual tblCountries tblCountries { get; set; }
        public virtual ICollection<tblDistricts> tblDistricts { get; set; }
    }
}
