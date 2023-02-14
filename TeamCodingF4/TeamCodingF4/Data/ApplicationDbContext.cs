using Microsoft.EntityFrameworkCore;
using TeamCodingF4.Data.Entity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasMany(x => x.ArticleLikes)
                    .WithOne(p => p.Member)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);


                entity.HasMany(d => d.EstateLikes)
                    .WithOne(p => p.Member)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                ArticleId = 1,
                Date = new DateTime(2008, 3, 1, 7, 0, 1),
                PublisherId = 1,
                Category = "心得分享",
                Content = "心得分享!",
                Title = "範例"
            });
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                ArticleId = 2,
                Date = new DateTime(2008, 3, 1, 7, 0, 2),
                PublisherId = 2,
                Category = "發文解惑",
                Content = "發文解惑~",
                Title = "範例"
            });
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                ArticleId = 3,
                Date = new DateTime(2008, 3, 1, 7, 0, 3),
                PublisherId = 3,
                Category = "閒聊專區",
                Content = "閒聊專區~",
                Title = "範例"
            });
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                ArticleId = 4,
                Date = new DateTime(2008, 3, 1, 7, 0, 4),
                PublisherId = 4,
                Category = "抱怨專區",
                Content = "抱怨專區~",
                Title = "範例"
            });
            modelBuilder.Entity<Articles>().HasData(new Articles
            {
                ArticleId = 5,
                Date = new DateTime(2008, 3, 1, 7, 0, 4),
                PublisherId = 5,
                Category = "找尋室友",
                Content = "找尋室友~",
                Title = "範例"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                Id = 1,
                ArticleId = 1,
                Date = new DateTime(2008, 3, 1, 7, 0, 1),
                PublisherId = 1,
                Content = "終於快寫好心得分享了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                Id = 2,
                ArticleId = 2,
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
                ArticleId = 4,
                Date = new DateTime(2008, 3, 1, 7, 0, 4),
                PublisherId = 4,
                Content = "終於快寫好抱怨專區了~"
            });
            modelBuilder.Entity<ArticleReply>().HasData(new ArticleReply
            {
                Id = 5,
                ArticleId = 5,
                Date = new DateTime(2008, 3, 1, 7, 0, 4),
                PublisherId = 5,
                Content = "終於快寫好找尋室友了~"
            });
            modelBuilder.Entity<Member>().HasData(new Member
            {
                Id = 1,
                Role = "Admin",
                Name = "ken",
                Phone = "0900000001",
                Account = "Admin001",
                Password = "1111",
                PasswordHash = "1111",
                Email = "admin001@gmail.com",
                Identity = "A123456789",
                BirthDate = new DateTime(1990, 3, 1, 7, 0, 1),
                Gender = 1,
                Rate = 5,
                Job = "工程師",
                PicturePath = "111",
            });
            modelBuilder.Entity<Member>().HasData(new Member
            {
                Id = 2,
                Role = "User",
                Name = "jack",
                Phone = "0900000002",
                Account = "User002",
                Password = "2222",
                PasswordHash = "2222",
                Email = "user002@gmail.com",
                Identity = "A123456780",
                BirthDate = new DateTime(1991, 3, 1, 7, 0, 2),
                Gender = 1,
                Rate = 4,
                Job = "老師",
                PicturePath = "222",
            });
            modelBuilder.Entity<Member>().HasData(new Member
            {
                Id = 3,
                Role = "User",
                Name = "mark",
                Phone = "0900000003",
                Account = "User003",
                Password = "3333",
                PasswordHash = "3333",
                Email = "user003@gmail.com",
                Identity = "A123456781",
                BirthDate = new DateTime(1992, 3, 1, 7, 0, 3),
                Gender = 1,
                Rate = 3,
                Job = "歌手",
                PicturePath = "333",
            }); modelBuilder.Entity<Member>().HasData(new Member
            {
                Id = 4,
                Role = "User",
                Name = "rose",
                Phone = "0900000004",
                Account = "User004",
                Password = "4444",
                PasswordHash = "4444",
                Email = "user004@gmail.com",
                Identity = "A123456782",
                BirthDate = new DateTime(1993, 3, 1, 7, 0, 4),
                Gender = 2,
                Rate = 2,
                Job = "銀行員",
                PicturePath = "444",
            }); modelBuilder.Entity<Member>().HasData(new Member
            {
                Id = 5,
                Role = "User",
                Name = "vivian",
                Phone = "0900000005",
                Account = "User005",
                Password = "5555",
                PasswordHash = "5555",
                Email = "user005@gmail.com",
                Identity = "A123456783",
                BirthDate = new DateTime(1994, 3, 1, 7, 0, 5),
                Gender = 2,
                Rate = 1,
                Job = "行政人員",
                PicturePath = "555",
            });
            modelBuilder.Entity<Condition>().HasData(new Condition
            {
                Id=1,
                Name="寵物"
            });
            modelBuilder.Entity<Equipment>().HasData(new Equipment
            {
                Id = 1,
                Name = "冷氣",
                Picture= @"\Picture\C231702674-SP-10837585.jpg"
            });
            modelBuilder.Entity<Equipment>().HasData(new Equipment
            {
                Id = 2,
                Name = "電視",
                Picture= @"\Picture\4acd260998f15b994caa60ef32d7891e-1000x675.jpg"
            });
            modelBuilder.Entity<Equipment>().HasData(new Equipment
            {
                Id = 3,
                Name = "乾溼分離",
                Picture= @"\Picture\12323323232-4.jpg"
            });
            modelBuilder.Entity<Equipment>().HasData(new Equipment
            {
                Id = 4,
                Name = "陽台",
                Picture= @"\Picture\large-glass-enclosed-balcony-picture-id1344082102.jpg"
            });
            modelBuilder.Entity<Equipment>().HasData(new Equipment
            {
                Id = 5,
                Name = "洗衣機",
                Picture = @"\Picture\TAW-R1208DB.jpg"
            });
            modelBuilder.Entity<Equipment>().HasData(new Equipment
            {
                Id = 6,
                Name = "飲水機",
                Picture = @"\Picture\m_ed93aaa626b305bdc2f1c6b2aa269905-fbQg0.jpg"
            });
            modelBuilder.Entity<Equipment>().HasData(new Equipment
            {
                Id = 7,
                Name = "冰箱",
                Picture = @"\Picture\87021356646430.jpg"
            });
            modelBuilder.Entity<RoomType>().HasData(new RoomType
            {
                Id = 1,
                Name = "透天",
                IsActive=true,
            });
            modelBuilder.Entity<RoomType>().HasData(new RoomType
            {
                Id = 2,
                Name = "套房",
                IsActive = true,
            });
            modelBuilder.Entity<RoomType>().HasData(new RoomType
            {
                Id = 3,
                Name = "雅房",
                IsActive = true,
            });
            modelBuilder.Entity<RoomType>().HasData(new RoomType
            {
                Id = 4,
                Name = "其他",
                IsActive = true,
            });
        }




    }
}