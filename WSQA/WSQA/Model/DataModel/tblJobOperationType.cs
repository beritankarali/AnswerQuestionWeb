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
    
    public partial class tblJobOperationType
    {
        public int JobOperationTypeID { get; set; }
        public int OperationTypeID { get; set; }
        public int JobID { get; set; }
    
        public virtual tblJobs tblJobs { get; set; }
        public virtual tblOperationType tblOperationType { get; set; }
    }
}