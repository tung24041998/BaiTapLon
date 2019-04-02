namespace BaiTapLon.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AlBum")]
    public partial class AlBum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AlBum()
        {
            Album_Baihat = new HashSet<Album_Baihat>();
        }

        [Key]
        [StringLength(10)]
        public string MaAB { get; set; }

        [StringLength(50)]
        public string TenAlBum { get; set; }

        [StringLength(200)]
        public string Anh { get; set; }

        public int? LuotNghe { get; set; }

        public int? LuotYThich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album_Baihat> Album_Baihat { get; set; }
    }
}
