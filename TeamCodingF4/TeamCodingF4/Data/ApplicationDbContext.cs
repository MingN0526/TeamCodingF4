using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data.Entity;

namespace TeamCodingF4.Data
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }




        public DbSet<ArticleLike> ArticleLikes { get; set; }
        public DbSet<ArticleReply> ArticlesReply { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<EstateImage> EstateImages { get; set; }
        public DbSet<EstateLike> EstateLikes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }


        //public IEnumerable<object> Artical { get; internal set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                Id = 1,
                Date = new DateTime(2008, 3, 1, 7, 0, 1),
                PublisherId = 1,
                Category = "心得分享",
                Content = "心得分享!",
                Title = "範例"
            });
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                Id = 2,
                Date = new DateTime(2008, 3, 1, 7, 0, 2),
                PublisherId = 2,
                Category = "發文解惑",
                Content = "發文解惑~",
                Title = "範例"
            });
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                Id = 3,
                Date = new DateTime(2008, 3, 1, 7, 0, 3),
                PublisherId = 3,
                Category = "閒聊專區",
                Content = "閒聊專區~",
                Title = "範例"
            });
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                Id = 4,
                Date = new DateTime(2008, 3, 1, 7, 0, 4),
                PublisherId = 4,
                Category = "抱怨專區",
                Content = "抱怨專區~",
                Title = "範例"
            });
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                Id = 5,
                Date = new DateTime(2008, 3, 1, 7, 0, 4),
                PublisherId = 5,
                Category = "找尋室友",
                Content = "找尋室友~",
                Title = "範例"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                Id = 1,
                ArticleId= 1,
                Date = new DateTime(2008, 3, 1, 7, 0, 1),
                PublisherId = 1,
                Content = "終於快寫好心得分享了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                Id = 2,
                ArticleId= 2,
                Date = new DateTime(2008, 3, 1, 7, 0, 2),
                PublisherId = 2,
                Content = "終於快寫好發文解惑了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                Id = 3,
                ArticleId = 3,
                Date = new DateTime(2008, 3, 1, 7, 0, 3),
                PublisherId = 3,
                Content = "終於快寫好閒聊專區了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                Id = 4,
                ArticleId= 4,   
                Date = new DateTime(2008, 3, 1, 7, 0, 4),
                PublisherId = 4,
                Content = "終於快寫好抱怨專區了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                Id = 5,
                ArticleId= 5,
                Date = new DateTime(2008, 3, 1, 7, 0, 4),
                PublisherId = 5,
                Content = "終於快寫好找尋室友了~"
            });
        }




    }
}