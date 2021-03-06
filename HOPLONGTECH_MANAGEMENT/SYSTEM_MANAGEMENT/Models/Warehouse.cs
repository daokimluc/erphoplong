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
    
    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            this.HOLD_PRODUCTS = new HashSet<HOLD_PRODUCTS>();
            this.PRODUCTS = new HashSet<PRODUCT>();
            this.RETURNING_PRODUCTS = new HashSet<RETURNING_PRODUCTS>();
            this.TRANSFER_WAREHOUSE_PRODUCTS = new HashSet<TRANSFER_WAREHOUSE_PRODUCTS>();
            this.TRANSFER_WAREHOUSE_PRODUCTS1 = new HashSet<TRANSFER_WAREHOUSE_PRODUCTS>();
        }
    
        public string MA_KHO { get; set; }
        public string TEN_KHO { get; set; }
        public string MO_TA { get; set; }
        public string COMPANY_ID { get; set; }
    
        public virtual COMPANY COMPANY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLD_PRODUCTS> HOLD_PRODUCTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RETURNING_PRODUCTS> RETURNING_PRODUCTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFER_WAREHOUSE_PRODUCTS> TRANSFER_WAREHOUSE_PRODUCTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFER_WAREHOUSE_PRODUCTS> TRANSFER_WAREHOUSE_PRODUCTS1 { get; set; }
    }
}
