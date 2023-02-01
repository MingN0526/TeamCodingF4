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
                ArticleDate = "2022/01/10",
                ArticlePublisher = "Jacky",
                ArticleCategory = "心得分享",
                ArticleContent = "心得分享!",
                ArticleTitle = "範例"
            });
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 2,
                ArticleDate = "2022/01/10",
                ArticlePublisher = "Jacky",
                ArticleCategory = "發文解惑",
                ArticleContent = "發文解惑~",
                ArticleTitle = "範例"
            });
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 3,
                ArticleDate = "2022/01/10",
                ArticlePublisher = "Jacky",
                ArticleCategory = "閒聊專區",
                ArticleContent = "閒聊專區~",
                ArticleTitle = "範例"
            });
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 4,
                ArticleDate = "2022/01/10",
                ArticlePublisher = "Jacky",
                ArticleCategory = "抱怨專區",
                ArticleContent = "抱怨專區~",
                ArticleTitle = "範例"
            });
            modelBuilder.Entity<Article>().HasData(new Article
            {
                ArticleId = 5,
                ArticleDate = "2022/01/10",
                ArticlePublisher = "Jacky",
                ArticleCategory = "找尋室友",
                ArticleContent = "找尋室友~",
                ArticleTitle = "範例"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ArticleReplyId = 1,
                ReplyDate = "2022/01/10",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好心得分享了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ArticleReplyId = 2,
                ReplyDate = "2022/01/10",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好發文解惑了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ArticleReplyId = 3,
                ReplyDate = "2022/01/10",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好閒聊專區了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ArticleReplyId = 4,
                ReplyDate = "2022/01/10",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好抱怨專區了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                ArticleReplyId = 5,
                ReplyDate = "2022/01/10",
                ReplyPublisher = "Sam",
                ReplyContent = "終於快寫好找尋室友了~"
            });
        }

        


    }
}