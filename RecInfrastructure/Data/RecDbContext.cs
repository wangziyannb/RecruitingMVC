using Microsoft.EntityFrameworkCore;
using RecCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfrastructure.Data
{
    public class RecDbContext : DbContext
    {

        public RecDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobRequirement> JobRequirements { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<EmployeeRequirementType> EmployeeRequirementTypes { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
