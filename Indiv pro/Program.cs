using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace Indiv_pro
{

    class StudentCourse
    {
        public int studentId;
        public int courseId;
        public StudentCourse(int studentId, int courseId)
        {
            this.studentId = studentId;
            this.courseId = courseId;
        }
    }
    class TrainerCourse
    {
        public int trainerId;
        public int courseId;
        public TrainerCourse(int trainerId, int courseId)
        {
            this.trainerId = trainerId;
            this.courseId = courseId;
        }
    }
    class AssignmentCourse
    {
        public int assignmentId;
        public int courseId;
        public AssignmentCourse(int assignmentId, int courseId)
        {
            this.assignmentId = assignmentId;
            this.courseId = courseId;
        }
    }
    class AssignmentStudentCourse
    {
        public int assignmentId;
        public int studentId;
        public int courseId;
        public AssignmentStudentCourse(int assignmentId, int studentId, int courseId)
        {
            this.assignmentId = assignmentId;
            this.studentId = studentId;
            this.courseId = courseId;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<SchoolClass> schoolClasses = new List<SchoolClass>();
            List<CourseClass> CourseClasses = new List<CourseClass>();
            List<Course> allCourses = new List<Course>();
            List<Student> allStudents = new List<Student>();
            List<Trainer> allTrainers = new List<Trainer>();
            List<Assignment> allAssignments = new List<Assignment>();
            List<Student> studentsToMoreThanOneCourses = new List<Student>();
            List<StudentCourse> studentCourses = new List<StudentCourse>();
            List<AssignmentCourse> assignmentCourses = new List<AssignmentCourse>();
            List<AssignmentStudentCourse> allAssignmentStudentCourses = new List<AssignmentStudentCourse>();

            School school = new School();











            /*

                        Student student1 = new Student("Despoina", "Salichou", new DateTime(1994, 04, 23), 200);
                        allStudents.Add(student1);
                        Student student2 = new Student("Nikos", "Salichos", new DateTime(1994, 05, 23), 200);
                        allStudents.Add(student2);


                        Course course1 = new Course("CB12", "C#", "Part_time", new DateTime(2020, 01, 01), new DateTime(2020, 06, 30));
                        allCourses.Add(course1);
                        Course course2 = new Course("CB12", "Java", "Part_time", new DateTime(2020, 01, 01), new DateTime(2020, 06, 30));
                        allCourses.Add(course2);


                        Console.WriteLine("Μαθητές");
                        for (int i = 0; i < allStudents.Count; i++)
                        {
                            Console.WriteLine("{0}. {1}", i, allStudents[i].firstName);
                        }
                        int courseId;

                        do
                        {
                            Console.WriteLine("Διάλεξε μαθητή");
                            int studentId = int.Parse(Console.ReadLine());



                            Console.WriteLine("Διάλεξε course να βάλεις το μαθητή {0} {1}", allStudents[studentId].firstName, allStudents[studentId].lastName);
                            for (int i = 0; i < allCourses.Count; i++)
                            {
                                Console.WriteLine("{0}. {1}", i, allCourses[i].stream);
                            }
                            courseId = int.Parse(Console.ReadLine());
                            // Console.WriteLine("{0} {1}", allStudents[studentId].firstName, allCourses[courseId].stream);



                            studentCourses.Add(new StudentCourse(studentId, courseId));
                            foreach (var studentCourse in studentCourses)
                            {
                                Console.WriteLine("{0} {1}", allStudents[studentCourse.studentId].firstName, allCourses[studentCourse.courseId].stream);
                            }
                        }
                        while (true);*/












            /*Console.WriteLine("Αν θέλετε να χρησιμοποιήσετε synthetic data, πληκτρολογείστε YES ");
            string sd = Console.ReadLine();

            if (sd == "YES")
            {
                Utils.UseSyntheticData(
                    schoolClasses,
                    CourseClasses,
                    allCourses,
                    allStudents,
                    allTrainers,
                    allAssignments,
                    studentsToMoreThanOneCourses
                    );

            }
            else
            {

                for (int i = 0; i < allStudents.Count; i++)
                {
                    Console.WriteLine($"{allStudents[i]}+" + i);

                }
            }
            Utils.printAllStudents(allStudents);
            Utils.printAllTrainers(allTrainers);
            Utils.printAllAssignments(allAssignments);
            Utils.printAllCourses(allCourses);
            Utils.printAllStudentsandCourses(CourseClasses);
            Utils.printAllTrainersPerCourse(CourseClasses);
            Utils.printAllAssignmentsPerCourse(CourseClasses);
            Utils.printAllStudentsAssignmentsStudents(CourseClasses);
            Utils.printStudentsMoreThanOneCourses(studentsToMoreThanOneCourses);
            Utils.PrintAssignmentSubmissions(schoolClasses);*/








        }
    }

}
















