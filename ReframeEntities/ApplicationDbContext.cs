using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ReframeEntities.Entities;

namespace ReframeEntities
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<ThoughtLog> ThoughtLogs { get; set; }

        public virtual DbSet<NegativeThoughtType> NegativeThoughtTypes { get; set; }

        public virtual DbSet<CognitiveDistortion> CognitiveDistortions {get; set;}
    }
}
