using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Models;
using TeamCodingF4.Models.ApiModel;

namespace TeamCodingF4.Data
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleReply> ArticlesReply { get; set; }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<MemberLike> MemberLikes { get; set; }

        public DbSet<EstateImage> EstateImage { get; set; }

        public DbSet<EstateVideo> EstateVideo { get; set; }

        public DbSet<EstateModel> EstateModel { get; set; }

        //public IEnumerable<object> Artical { get; internal set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 1,
                Date = "2022/01/10",
                Publisher = "Jacky",
                Category = "心得分享",
                Content = "心得分享!",
                Title = "範例"
            });
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 2,
                Date = "2022/01/11",
                Publisher = "Amy",
                Category = "發文解惑",
                Content = "發文解惑~",
                Title = "範例"
            });
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 3,
                Date = "2022/01/12",
                Publisher = "Ken",
                Category = "閒聊專區",
                Content = "閒聊專區~",
                Title = "範例"
            });
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 4,
                Date = "2022/01/13",
                Publisher = "YO",
                Category = "抱怨專區",
                Content = "抱怨專區~",
                Title = "範例"
            });
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 5,
                Date = "2022/01/13",
                Publisher = "MIMI",
                Category = "找尋室友",
                Content = "找尋室友~",
                Title = "範例"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ReplyId = 1,
                ReplyDate = "2022/01/10",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好心得分享了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ReplyId = 2,
                ReplyDate = "2022/01/11",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好發文解惑了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ReplyId = 3,
                ReplyDate = "2022/01/12",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好閒聊專區了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ReplyId = 4,
                ReplyDate = "2022/01/13",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好抱怨專區了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ReplyId = 5,
                ReplyDate = "2022/01/13",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好找尋室友了~"
            });
        }




    }
}