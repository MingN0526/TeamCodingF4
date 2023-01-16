using Microsoft.EntityFrameworkCore;

namespace TeamCodingF4.Models
{
    public class TeamCodingProjectContext :DbContext
    {
        public TeamCodingProjectContext(DbContextOptions<TeamCodingProjectContext> options) : base(options)
        {

        }
        public DbSet<MemberModel> MemberModels { get; set; }
        public DbSet<ArticalModel> ArticalModels { get; set; }
        

    }
}
