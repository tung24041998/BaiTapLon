namespace BaiTapLon.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinAll")]
    public partial class ThongTinAll
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinAll()
        {
            NgheSis = new HashSet<NgheSi>();
        }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string QueQuan { get; set; }

        public int? Tuoi { get; set; }

        [StringLength(200)]
        public string TieuSu { get; set; }

        [Key]
        [StringLength(10)]
        public string MaThongTin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NgheSi> NgheSis { get; set; }
    }
}
