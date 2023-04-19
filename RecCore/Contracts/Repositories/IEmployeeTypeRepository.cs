﻿using RecCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecCore.Contracts.Repositories
{
    public interface IEmployeeTypeRepository : IBaseRepository<EmployeeType>
    {
        Task<EmployeeType> GetEmployeeTypeByTypeName(string typeName);
    }
}
