﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoHomePage
{
    class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public Instructor Instructor { get; set; }
    }
}
