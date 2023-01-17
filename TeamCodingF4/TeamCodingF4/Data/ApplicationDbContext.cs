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
        public DbSet<ArticalModel> ArticalModel { get; set; }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<MemberLike> MemberLikes { get; set; }

        public DbSet<EstateImage> EstateImage { get; set; }

    }
}