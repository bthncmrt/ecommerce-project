﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eticaretprojesiEntities : DbContext
    {
        public eticaretprojesiEntities()
            : base("name=eticaretprojesiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gizlilikİlkesi> Gizlilikİlkesi { get; set; }
        public virtual DbSet<Hakkimizda> Hakkimizda { get; set; }
        public virtual DbSet<İadeKosullari> İadeKosullari { get; set; }
        public virtual DbSet<KargoFirmasi> KargoFirmasi { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<MailAbone> MailAbone { get; set; }
        public virtual DbSet<MailAyarlari> MailAyarlari { get; set; }
        public virtual DbSet<musteri> musteri { get; set; }
        public virtual DbSet<OdemeYontemi> OdemeYontemi { get; set; }
        public virtual DbSet<Ozellik> Ozellik { get; set; }
        public virtual DbSet<Seo> Seo { get; set; }
        public virtual DbSet<SepetId> SepetId { get; set; }
        public virtual DbSet<Siparis> Siparis { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetay { get; set; }
        public virtual DbSet<SiparisDurumu> SiparisDurumu { get; set; }
        public virtual DbSet<SiparisGecmisi> SiparisGecmisi { get; set; }
        public virtual DbSet<Siteayarlari> Siteayarlari { get; set; }
        public virtual DbSet<SosyalMediya> SosyalMediya { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TeslimatBilgileri> TeslimatBilgileri { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<UrunVaryant> UrunVaryant { get; set; }
        public virtual DbSet<Uyesözleşmesi> Uyesözleşmesi { get; set; }
        public virtual DbSet<Varyant> Varyant { get; set; }
        public virtual DbSet<Yorumlar> Yorumlar { get; set; }
    }
}
