﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Core.Entities
{
#nullable disable
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty; 
        public DateTime StartDate { get; set; }
        public ICollection<Module> Modules { get; set; } 
    }
}
