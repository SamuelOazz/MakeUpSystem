//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MakeUpId { get; set; }
        public int Quantity { get; set; }
    
        public virtual MakeUp MakeUp { get; set; }
        public virtual User User { get; set; }
    }
}
