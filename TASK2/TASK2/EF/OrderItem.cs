//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TASK2.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItem
    {
        public int oi_id { get; set; }
        public Nullable<int> u_id { get; set; }
        public Nullable<int> o_id { get; set; }
        public Nullable<int> subtotal { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }
}
