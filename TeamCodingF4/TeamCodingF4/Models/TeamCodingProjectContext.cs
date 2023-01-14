﻿using Microsoft.EntityFrameworkCore;

namespace TeamCodingF4.Models
{
    public class TeamCodingProjectContext :DbContext
    {
        public TeamCodingProjectContext(DbContextOptions<TeamCodingProjectContext> options) : base(options)
        {

        }
        DbSet<articalModel> articalModels { get; set; }
    }
}
