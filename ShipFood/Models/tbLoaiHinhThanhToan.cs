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
    
    public partial class tbLoaiHinhThanhToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbLoaiHinhThanhToan()
        {
            this.tbDonHang = new HashSet<tbDonHang>();
        }
    
        public int mahttt { get; set; }
        public string tenhinhthuc { get; set; }
        public string mota { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDonHang> tbDonHang { get; set; }
    }
}
