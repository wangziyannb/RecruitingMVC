﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecCore.Models
{
    public class CandidateResponseModel
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ResumeURL { get; set; }
    }
}
