//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LouvreLIS_Client
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public System.Guid ID { get; set; }
        public System.Guid AccountID { get; set; }
        public System.DateTime VisitDateTime { get; set; }
        public decimal PriceEUR { get; set; }
        public string OrderNumber { get; set; }
        public string TicketNumber { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public string InternalserialNumber { get; set; }
        public byte TicketStatus { get; set; }
    
        public virtual Visitor Visitor { get; set; }
    }
}
