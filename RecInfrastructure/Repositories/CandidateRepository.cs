using RecCore.Contracts.Repositories;
using RecCore.Entities;
using RecInfrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecInfrastructure.Repositories
{
    public class CandidateRepository : BaseRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(RecDbContext dbContext) : base(dbContext)
        {
        }
    }
}
