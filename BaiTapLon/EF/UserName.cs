namespace BaiTapLon.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserName")]
    public partial class UserName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserName()
        {
            BaiHats = new HashSet<BaiHat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Required(ErrorMessage = "Ban chua nhap ten ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ban chua nhap ten ")]
        [StringLength(50)]

        public string Name { get; set; }
        [Required(ErrorMessage = "Ban chua nhap dia chi ")]
        [StringLength(50)]

        public string address { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Ban nhap chua dung email ")]
        [StringLength(50)]

        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiHat> BaiHats { get; set; }
    }
}
