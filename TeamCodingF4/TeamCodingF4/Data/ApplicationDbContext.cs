using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Models;

namespace TeamCodingF4.Data
{
    public class ApplicationDbContext : IdentityDbContext<MemberModel,IdentityRole<int>,int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Artical> ArticalModel { get; set; }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<MemberLike> MemberLikes { get; set; }

        public DbSet<EstateImage> EstateImage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Artical>().HasData(new Artical
            {
                ArticalId=1,
                AriticalDate="2022/01/10",
                ArticlePublisher="Jacky",
                ArticleCategory="心得分享",
                ArticleContent="加油!"
            });
        }

    }
}