//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SYSTEM_MANAGEMENT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GHI_CHU_CONG_VIEC
    {
        public int NOTED_ID { get; set; }
        public int USER_ID { get; set; }
        public Nullable<System.DateTime> DATE_NOTED { get; set; }
        public string NOTED_NAME { get; set; }
        public string NOTED_INFO { get; set; }
        public Nullable<byte> IS_DONE { get; set; }
        public Nullable<System.DateTime> DATE_DONE { get; set; }
    
        public virtual USER USER { get; set; }
    }
}