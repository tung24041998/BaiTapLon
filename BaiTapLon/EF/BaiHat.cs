namespace BaiTapLon.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiHat")]
    public partial class BaiHat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiHat()
        {
            Album_Baihat = new HashSet<Album_Baihat>();
            TheLoais = new HashSet<TheLoai>();
            CaSis = new HashSet<CaSi>();
        }

        [Key]
        [StringLength(10)]
        public string MaBH { get; set; }

        [StringLength(50)]
        public string TenBH { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNS { get; set; }

        [Required]
        [StringLength(10)]
        public string MaCS { get; set; }

        [StringLength(10)]
        public string MaAB { get; set; }

        [Required]
        [StringLength(10)]
        public string MaTL { get; set; }

        public int? LuotNghe { get; set; }

        public int? Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album_Baihat> Album_Baihat { get; set; }

        public virtual NgheSi NgheSi { get; set; }

        public virtual UserName UserName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheLoai> TheLoais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaSi> CaSis { get; set; }
    }
}
