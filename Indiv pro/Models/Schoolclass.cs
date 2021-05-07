using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class SchoolClass
    {
        public List<CourseClass> CourseClasses = new List<CourseClass>();

        public SchoolClass()
        {

        }
        public void AddCourseClass(CourseClass courseClass)
        {
            CourseClasses.Add(courseClass);
        }



    }
}
