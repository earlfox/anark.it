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
    
    public partial class Catagory
    {
        public Catagory()
        {
            this.Listings = new HashSet<Listing>();
        }
    
        public short CatId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Listing> Listings { get; set; }
    }
}