//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eticaretproje1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunVaryant
    {
        public int Id { get; set; }
        public Nullable<int> UrunId { get; set; }
        public Nullable<int> VaryantId { get; set; }
        public Nullable<int> Miktar { get; set; }
        public Nullable<int> OzelliklerId { get; set; }
    
        public virtual Ozellik Ozellik { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual Varyant Varyant { get; set; }
    }
}
