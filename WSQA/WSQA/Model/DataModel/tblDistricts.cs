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
    
    public partial class tblDistricts
    {
        public tblDistricts()
        {
            this.tblJobs = new HashSet<tblJobs>();
            this.tblProfiles = new HashSet<tblProfiles>();
        }
    
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public int ProvinceID { get; set; }
    
        public virtual tblProvinces tblProvinces { get; set; }
        public virtual ICollection<tblJobs> tblJobs { get; set; }
        public virtual ICollection<tblProfiles> tblProfiles { get; set; }
    }
}
