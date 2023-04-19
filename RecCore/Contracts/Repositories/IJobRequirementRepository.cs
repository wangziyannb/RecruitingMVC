﻿using RecCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecCore.Contracts.Repositories
{
    public interface IJobRequirementRepository:IBaseRepository<JobRequirement>
    {
        public Task<IEnumerable<JobRequirement>> GetJobRequirementsIncludingCategory(Expression<Func<JobRequirement, bool>> filter);
    }
}
