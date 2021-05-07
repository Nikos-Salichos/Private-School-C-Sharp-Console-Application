using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class SchoolClass1
    {
        public int CourseId;
        public List<int> allStudents = new List<int>();
        public List<int> allTrainers = new List<int>();
        public List<int> allAssignments = new List<int>();
        public List<int> allStudentCourses = new List<int>();
        public List<int> allTrainerCourses = new List<int>();
        public List<int> allAssignmentCourses = new List<int>();
        public List<StudentAssignment> studentAssignments = new List<StudentAssignment>();
        //public List<int> allAssignmentStudentCourses = new List<int>();


        public void addStudent(int studentId)
        {
            allStudents.Add(studentId);
        }
        public void addTrainer(int trainerId)
        {
            allTrainers.Add(trainerId);
        }
        public void addAssignment(int assignmentId)
        {
            allAssignments.Add(assignmentId);
        }

        public void addStudentToCourse(int studentCourseId)
        {
            allStudentCourses.Add(studentCourseId);
        }

        public void addTrainerToCourse(int trainerCourseId)
        {
            allTrainerCourses.Add(trainerCourseId);
        }
        public void addAssignmentToCourse(int assignmentCourseId)
        {
            allAssignmentCourses.Add(assignmentCourseId);
        }
        public void addAssignmentStudentCourses(int assignmentStudentCourseId)
        {
            allAssignmentStudentCourses.Add(assignmentStudentCourseId);
        }

    }
}
