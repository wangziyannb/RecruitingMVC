﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecCore.Entities
{
    public class JobCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<JobRequirement> JobRequirements { get; set; }
    }
}
