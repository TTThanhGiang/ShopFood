//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShipFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbKhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbKhachHang()
        {
            this.tbTinNhan = new HashSet<tbTinNhan>();
            this.tbThongTinDatHang = new HashSet<tbThongTinDatHang>();
        }
    
        public int? userid { get; set; }
        public string tenkh { get; set; }
    
        public virtual tbUser tbUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTinNhan> tbTinNhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbThongTinDatHang> tbThongTinDatHang { get; set; }
    }
}
