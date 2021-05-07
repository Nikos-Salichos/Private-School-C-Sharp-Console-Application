using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class CourseClass
    {
        public Course course;
        public List<Student> students = new List<Student>();
        public List<Assignment> assignments = new List<Assignment>();
        public List<Trainer> trainers = new List<Trainer>();
        public List<StudentAssignment> studentAssignments = new List<StudentAssignment>();


        public class StudentAssignment
        {
            private Student _student;
            private Assignment _assignment;
            public Student student
            {
                get { return _student; }
                set { _student = value; }
            }
            public Assignment assignment
            {
                get { return _assignment; }
                set { _assignment = value; }
            }
        }

        public void connectStudentToAssignment(Student student, Assignment assignment)
        {
            StudentAssignment sa = new StudentAssignment();
            sa.student = student;
            sa.assignment = assignment;
            studentAssignments.Add(sa);
        }

        public CourseClass()
        {

        }

        public void addStudent(Student student)
        {
            students.Add(student);
        }

        public void addAssignment(Assignment assignment)
        {
            assignments.Add(assignment);
        }

        public void addTrainer(Trainer trainer)
        {
            trainers.Add(trainer);
        }
    }
}
