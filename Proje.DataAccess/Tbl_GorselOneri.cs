//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_GorselOneri
    {
        public short GorselOnerid { get; set; }
        public string GorselOnerAd { get; set; }
        public string GorselOnerİcerik { get; set; }
        public string GorselOnerKategori { get; set; }
        public string GorselOnerKullanici { get; set; }
        public string GorselOnerMail { get; set; }
        public Nullable<short> GorselGeciciid { get; set; }
    
        public virtual Tbl_Gorsel Tbl_Gorsel { get; set; }
        public virtual Tbl_Profil Tbl_Profil { get; set; }
    }
}