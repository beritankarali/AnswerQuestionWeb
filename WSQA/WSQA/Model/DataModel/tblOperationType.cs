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
    
    public partial class tblOperationType
    {
        public tblOperationType()
        {
            this.tblJobOperationType = new HashSet<tblJobOperationType>();
        }
    
        public int OperationTypeID { get; set; }
        public string OperationTypeName { get; set; }
    
        public virtual ICollection<tblJobOperationType> tblJobOperationType { get; set; }
    }
}
