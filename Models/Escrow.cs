//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnarkRE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Escrow
    {
        public System.Guid EscrowId { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public string BuyerPubkey { get; set; }
        public string BuyerPrivkey { get; set; }
        public string EicA { get; set; }
        public string EicB { get; set; }
        public int State { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> SellerReleaseDt { get; set; }
        public Nullable<System.DateTime> BuyerReleaseDt { get; set; }
        public Nullable<int> AcceptId { get; set; }
        public Nullable<int> SellerFeedbackId { get; set; }
        public Nullable<int> BuyerFeedbackId { get; set; }
        public Nullable<System.DateTime> ClosedDt { get; set; }
        public Nullable<int> ClosedBy { get; set; }
        public System.Guid ListingId { get; set; }
        public Nullable<System.DateTime> BuyerDeleteDt { get; set; }
        public Nullable<System.DateTime> SellerDeleteDt { get; set; }
        public string ShippingName { get; set; }
        public Nullable<decimal> ShippingPrice { get; set; }
        public string VariationName { get; set; }
        public Nullable<int> Qty { get; set; }
    
        public virtual EscrowAccept EscrowAccept { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual User UserBuyer { get; set; }
        public virtual User UserSeller { get; set; }
    }
}
