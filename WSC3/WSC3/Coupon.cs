//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSC3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coupon()
        {
            this.AddonServices = new HashSet<AddonService>();
            this.Bookings = new HashSet<Booking>();
        }
    
        public long ID { get; set; }
        public System.Guid GUID { get; set; }
        public string CouponCode { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal MaximimDiscountAmount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddonService> AddonServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
