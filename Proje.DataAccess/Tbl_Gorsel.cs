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
    
    public partial class Tbl_Gorsel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Gorsel()
        {
            this.Tbl_GorselOneri = new HashSet<Tbl_GorselOneri>();
        }
    
        public short Gorselid { get; set; }
        public string GorselAd { get; set; }
        public string Gorselİcerik { get; set; }
        public string GorselKategori { get; set; }
        public string GorselAciklama { get; set; }
        public Nullable<System.DateTime> GorselEklenmeTarih { get; set; }
        public Nullable<short> Kategoriid { get; set; }
    
        public virtual Tbl_Kategori Tbl_Kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_GorselOneri> Tbl_GorselOneri { get; set; }
    }
}
