using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Models;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Data
{
    public class ApplicationDbContext : IdentityDbContext<MemberModel,IdentityRole<int>,int>
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<MemberLike> MemberLikes { get; set; }

        public DbSet<EstateImage> EstateImage { get; set; }

        public DbSet<EstateModel> EstateModel { get; set; }

        public IEnumerable<object> Artical { get; internal set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 1,
                ArticleDate = "2022/01/10",
                ArticlePublisher = "Jacky",
                ArticleCategory = "心得分享",
                ArticleContent = "加油!",
                ArticleTitle = "範例"
            });
        }


    }
}