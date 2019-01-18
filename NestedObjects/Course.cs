using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Course
    {
        public string Title { get; set; }

        public byte Credits { get; set; }

        public string Description { get; set; }

        public Instructor CourseInstructor { get; set; }
    }
}
