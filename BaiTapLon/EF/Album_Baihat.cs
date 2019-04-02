namespace BaiTapLon.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Album_Baihat
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaBH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaAB { get; set; }

        public virtual AlBum AlBum { get; set; }

        public virtual BaiHat BaiHat { get; set; }
    }
}
