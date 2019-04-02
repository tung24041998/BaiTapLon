namespace BaiTapLon.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Online_Music : DbContext
    {
        public Online_Music()
            : base("name=Online_Music")
        {
        }

        public virtual DbSet<AlBum> AlBums { get; set; }
        public virtual DbSet<Album_Baihat> Album_Baihat { get; set; }
        public virtual DbSet<BaiHat> BaiHats { get; set; }
        public virtual DbSet<CaSi> CaSis { get; set; }
        public virtual DbSet<NgheSi> NgheSis { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<ThongTinAll> ThongTinAlls { get; set; }
        public virtual DbSet<UserName> UserNames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlBum>()
                .HasMany(e => e.Album_Baihat)
                .WithRequired(e => e.AlBum)
                .HasForeignKey(e => e.MaBH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BaiHat>()
                .HasMany(e => e.Album_Baihat)
                .WithRequired(e => e.BaiHat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BaiHat>()
                .HasMany(e => e.TheLoais)
                .WithMany(e => e.BaiHats)
                .Map(m => m.ToTable("BaiHat_TheLoai").MapLeftKey("MaBH").MapRightKey("MaTL"));

            modelBuilder.Entity<BaiHat>()
                .HasMany(e => e.CaSis)
                .WithMany(e => e.BaiHats)
                .Map(m => m.ToTable("CaSi_BaiHat").MapLeftKey("MaBH").MapRightKey("MaCS"));

            modelBuilder.Entity<NgheSi>()
                .HasMany(e => e.BaiHats)
                .WithRequired(e => e.NgheSi)
                .WillCascadeOnDelete(false);
        }
    }
}
