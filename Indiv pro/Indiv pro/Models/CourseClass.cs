using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class StudentAssignment
    {
        public int studentId;
        public int assignmentId;
        public StudentAssignment(int studentId, int assignmentId)
        {
            this.studentId = studentId;
            this.assignmentId = assignmentId;
        }
    }
    class CourseClass
    {

        public int CourseId;
        public List<int> students = new List<int>();
        public List<int> trainers = new List<int>();
        public List<int> assignments = new List<int>();
        public List<StudentAssignment> studentAssignments = new List<StudentAssignment>();


        public void addStudent(int studentId)
        {
            students.Add(studentId);
        }
        public void addTrainer(int trainerId)
        {
            trainers.Add(trainerId);
        }
        public void addAssignment(int assignmentId)
        {
            assignments.Add(assignmentId);
        }
        public void assignToStudent(int studentId, int assignmentId)
        {
            StudentAssignment studentAssignment = new StudentAssignment(studentId, assignmentId);
            studentAssignments.Add(studentAssignment);
        }


    }
}
