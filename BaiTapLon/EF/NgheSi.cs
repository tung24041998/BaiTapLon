namespace BaiTapLon.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NgheSi")]
    public partial class NgheSi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NgheSi()
        {
            BaiHats = new HashSet<BaiHat>();
        }

        [Key]
        [StringLength(10)]
        public string MaNS { get; set; }

        [Column("NgheSi")]
        [StringLength(50)]
        public string NgheSi1 { get; set; }

        [StringLength(10)]
        public string MaThongTin { get; set; }

        [StringLength(200)]
        public string Anh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiHat> BaiHats { get; set; }

        public virtual ThongTinAll ThongTinAll { get; set; }
    }
}
