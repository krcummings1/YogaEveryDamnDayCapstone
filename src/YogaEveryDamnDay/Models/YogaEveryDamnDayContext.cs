using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YogaEveryDamnDay.Models
{
    public class YogaEveryDamnDayContext :DbContext
    {
        public YogaEveryDamnDayContext(DbContextOptions<YogaEveryDamnDayContext> options)
        : base(options)
        { }

        public DbSet<Pose> Pose { get; set; }
        public DbSet<PoseRelationship> PoseRelationship { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<PoseCategory> PoseCategory { get; set; }
    }
}

