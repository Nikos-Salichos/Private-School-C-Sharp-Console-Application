using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class Utils
    {

        public static void UseSyntheticData(
            List<SchoolClass> schoolClasses,
            List<CourseClass> CourseClasses,
            List<Course> allCourses,
            List<Student> allStudents,
            List<Trainer> allTrainers,
            List<Assignment> allAssignments,
            List<Student> studentsToMoreThanOneCourses
            )

        {
            SchoolClass schoolClass = new SchoolClass();
            schoolClasses.Add(schoolClass);

            CourseClass CourseClass1 = new CourseClass();
            CourseClasses.Add(CourseClass1);
            schoolClass.AddCourseClass(CourseClass1);

            CourseClass CourseClass2 = new CourseClass();
            CourseClasses.Add(CourseClass2);
            schoolClass.AddCourseClass(CourseClass2);

            CourseClass CourseClass3 = new CourseClass();
            CourseClasses.Add(CourseClass3);
            schoolClass.AddCourseClass(CourseClass3);

            CourseClass CourseClass4 = new CourseClass();
            CourseClasses.Add(CourseClass4);
            schoolClass.AddCourseClass(CourseClass4);



            CourseClass1.course = new Course("CB12", "C#", "Part_time", new DateTime(2020, 01, 01), new DateTime(2020, 06, 30));
            allCourses.Add(CourseClass1.course);
            CourseClass2.course = new Course("CB12", "Java", "Part_time", new DateTime(2020, 01, 01), new DateTime(2020, 06, 30));
            allCourses.Add(CourseClass2.course);
            CourseClass3.course = new Course("CB12", "C#", "Full_time", new DateTime(2020, 01, 01), new DateTime(2020, 03, 31));
            allCourses.Add(CourseClass3.course);
            CourseClass4.course = new Course("CB12", "Java", "Full_time", new DateTime(2020, 01, 01), new DateTime(2020, 03, 31));
            allCourses.Add(CourseClass4.course);


            //Create assignments
            Assignment assignment1 = new Assignment("Exercise1 CPT", "Write a program to display the first 10 natural numbers", new DateTime(2020, 04, 16), 20, 80);
            allAssignments.Add(assignment1);
            CourseClass1.addAssignment(assignment1);

            Assignment assignment2 = new Assignment("Exercise1 JPT", "Write a program to create a list of students", new DateTime(2020, 04, 22), 20, 80);
            allAssignments.Add(assignment2);
            CourseClass2.addAssignment(assignment2);

            Assignment assignment3 = new Assignment("Exercise1 CFT", "Write a program to create a class of banks", new DateTime(2020, 02, 05), 20, 80);
            allAssignments.Add(assignment3);
            CourseClass3.addAssignment(assignment3);

            Assignment assignment4 = new Assignment("Exercise1 JFT", "Write a program to create a class of cars", new DateTime(2020, 02, 12), 20, 80);
            allAssignments.Add(assignment4);
            CourseClass4.addAssignment(assignment4);

            Assignment assignment5 = new Assignment("Individual Project ", "Write a program ", new DateTime(2020, 06, 24), 20, 80);
            allAssignments.Add(assignment5);
            CourseClass1.addAssignment(assignment5);
            CourseClass2.addAssignment(assignment5);

            Assignment assignment6 = new Assignment("Team Project", "Write a program ", new DateTime(2020, 03, 25), 20, 80);
            allAssignments.Add(assignment6);
            CourseClass3.addAssignment(assignment6);
            CourseClass4.addAssignment(assignment6);


            //Create students
            Student student1 = new Student("Despoina", "Salichou", new DateTime(1994, 04, 23), 200);
            allStudents.Add(student1);                                          //Προσθέτω το μαθητή στη λίστα όλων των μαθητών
            CourseClass1.addStudent(student1);                                  //Προσθετω το μαθητή στην courseclass1 
            CourseClass1.connectStudentToAssignment(student1, assignment1);     //Συνδέω το μαθητή του courseclass1 με το assignment                
            CourseClass2.addStudent(student1);                                  //Προσθέτω το μαθητή στην courseclass2
            CourseClass2.connectStudentToAssignment(student1, assignment2);     //Συνδέω το μαθητή του courseclass2 με το assignment 
            studentsToMoreThanOneCourses.Add(student1);                         //Προσθέτω το μαθητή στη λίστα με τους μαθητές με παραπάνω απο 1 μάθημα

            Student student2 = new Student("Nikos", "Salichos", new DateTime(1991, 05, 12), 200);
            allStudents.Add(student2);
            CourseClass2.addStudent(student2);
            CourseClass2.connectStudentToAssignment(student2, assignment2);

            CourseClass1.addStudent(student2);
            CourseClass1.connectStudentToAssignment(student2, assignment1);
            studentsToMoreThanOneCourses.Add(student2);

            Student student3 = new Student("Maria", "Markatou", new DateTime(1994, 06, 15), 200);
            allStudents.Add(student3);
            CourseClass3.addStudent(student3);
            CourseClass3.connectStudentToAssignment(student3, assignment3);
            CourseClass4.addStudent(student3);
            CourseClass4.connectStudentToAssignment(student3, assignment4);
            studentsToMoreThanOneCourses.Add(student3);

            Student student4 = new Student("Nikoletta", "Michalopoulou", new DateTime(1992, 03, 31), 100);
            allStudents.Add(student4);
            CourseClass4.addStudent(student4);
            CourseClass4.connectStudentToAssignment(student4, assignment4);
            CourseClass3.addStudent(student4);
            CourseClass3.connectStudentToAssignment(student4, assignment3);
            studentsToMoreThanOneCourses.Add(student4);

            Student student5 = new Student("Panagiotis", "Petroglou", new DateTime(1995, 11, 01), 100);
            allStudents.Add(student5);
            CourseClass1.addStudent(student5);
            CourseClass1.connectStudentToAssignment(student5, assignment1);
            CourseClass4.addStudent(student5);
            studentsToMoreThanOneCourses.Add(student5);

            Student student6 = new Student("Achilleas", "Mavridis", new DateTime(1994, 08, 25), 100);
            allStudents.Add(student6);
            CourseClass2.addStudent(student6);
            CourseClass2.connectStudentToAssignment(student6, assignment2);

            Student student7 = new Student("Evangelos", "Peristeris", new DateTime(1994, 04, 09), 100);
            allStudents.Add(student7);
            CourseClass3.addStudent(student7);
            CourseClass3.connectStudentToAssignment(student7, assignment3);

            Student student8 = new Student("Christina", "Nikolaou", new DateTime(1995, 06, 02), 100);
            allStudents.Add(student8);
            CourseClass4.addStudent(student8);
            CourseClass4.connectStudentToAssignment(student8, assignment4);




            //Create trainers
            Trainer trainer1 = new Trainer("Katerina", "Papadopoulou", "C#");
            allTrainers.Add(trainer1);
            CourseClass1.addTrainer(trainer1);
            CourseClass3.addTrainer(trainer1);

            Trainer trainer2 = new Trainer("Ioannis", "Spyropoulos", "Java");
            allTrainers.Add(trainer2);
            CourseClass2.addTrainer(trainer2);
            CourseClass4.addTrainer(trainer2);

            Trainer trainer3 = new Trainer("Athanasios", "Evangelou", "C#");
            allTrainers.Add(trainer3);
            CourseClass3.addTrainer(trainer3);
            CourseClass1.addTrainer(trainer3);

            Trainer trainer4 = new Trainer("Maria", "Alevra", "Java");
            allTrainers.Add(trainer4);
            CourseClass4.addTrainer(trainer4);
            CourseClass2.addTrainer(trainer4);
        }

        //STUDENTS
        public static void printAllStudents(List<Student> allStudents)
        {
            Console.WriteLine("\nA LIST OF ALL STUDENTS:");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.firstName} {student.lastName} {student.dateOfBirth.ToString("d", CultureInfo.CreateSpecificCulture("el-GR"))} {student.tuitionFees}");
            }
        }
        public static void printAllStudentsandCourses(List<CourseClass> CourseClasses)
        {
            Console.WriteLine("\nALL THE STUDENTS PER COURSE ");
            foreach (var CourseClass in CourseClasses)
                foreach (var student in CourseClass.students)
                {
                    Console.WriteLine($" Students for {CourseClass.course.title} {CourseClass.course.stream} {CourseClass.course.type} : {student.firstName} {student.lastName} {student.dateOfBirth.ToString("d", CultureInfo.CreateSpecificCulture("el-GR"))} {student.tuitionFees}");
                }
        }
        public static void printStudentsMoreThanOneCourse(List<Student> studentsToMoreThanOneCourses)
        {
            Console.WriteLine("\nA LIST OF STUDENTS THAT BELONG TO MORE THAN ONE COURSES:");
            foreach (var student in studentsToMoreThanOneCourses)
            {
                Console.WriteLine($"{student.firstName} {student.lastName} {student.dateOfBirth.ToString("d", CultureInfo.CreateSpecificCulture("el-GR"))} {student.tuitionFees}");
            }
        }
        public static void printStudentsMoreThanOneCourses(List<Student> studentsToMoreThanOneCourses)
        {
            Console.WriteLine("\nA LIST OF STUDENTS THAT BELONG TO MORE THAN ONE COURSES:");

            foreach (var student in studentsToMoreThanOneCourses)
            {
                Console.WriteLine($"{student.firstName} {student.lastName }");
            }
        }
        //TRAINERS
        public static void printAllTrainers(List<Trainer> alltrainers)
        {
            Console.WriteLine("\nA LIST OF ALL TRAINERS:");
            foreach (var trainer in alltrainers)
            {
                Console.WriteLine($"{trainer.firstName} {trainer.lastName} {trainer.subject}");
            }
        }
        public static void printAllTrainersPerCourse(List<CourseClass> CourseClasses)
        {
            Console.WriteLine("\nALL THE TRAINERS PER COURSE");
            foreach (var CourseClass in CourseClasses)
                foreach (var trainer in CourseClass.trainers)
                {
                    Console.WriteLine($"Trainer for {CourseClass.course.stream} {CourseClass.course.type} : { trainer.firstName} {trainer.lastName} {trainer.subject}");
                }
        }
        //COURSES
        public static void printAllCourses(List<Course> allCourses)
        {
            Console.WriteLine("\nA LIST OF ALL COURSES:");
            foreach (var course in allCourses)
            {
                Console.WriteLine($"{course.title} {course.stream} {course.type} {course.startDate.ToString("d", CultureInfo.CreateSpecificCulture("el-GR"))} {course.endDate.ToString("d", CultureInfo.CreateSpecificCulture("el-GR"))}");
            }
        }
        //ASSIGNMENTS
        public static void printAllAssignmentsPerCourse(List<CourseClass> CourseClasses)
        {
            Console.WriteLine("\nALL ASSIGNMENTS PER COURSE");
            foreach (var CourseClass in CourseClasses)
                foreach (var assignment in CourseClass.assignments)
                {
                    Console.WriteLine($"Assignment for {CourseClass.course.stream} {CourseClass.course.type} : {assignment.title} {assignment.description} {assignment.subDateTime.ToString("d", CultureInfo.CreateSpecificCulture("el-GR"))} {assignment.oralMark}{assignment.totalMark}");
                }
        }
        public static void printAllAssignments(List<Assignment> allassignments)
        {
            Console.WriteLine("\nA LIST OF ALL THE ASSIGNMENTS:");
            foreach (var assignment in allassignments)
            {
                Console.WriteLine($"{assignment.title} {assignment.description} {assignment.subDateTime.ToString("d", CultureInfo.CreateSpecificCulture("el-GR"))} {assignment.oralMark}{assignment.totalMark}");
            }
        }
        public static void printAllStudentsAssignmentsStudents(List<CourseClass> CourseClasses)
        {

            Console.WriteLine("\nALL THE ASSIGNMENTS PER STUDENT(PER COURSE):");
            foreach (var CourseClass in CourseClasses)
                foreach (var studentAssignment in CourseClass.studentAssignments)
                {
                    Console.WriteLine($"{CourseClass.course.stream} {CourseClass.course.type} {studentAssignment.student.firstName} {studentAssignment.student.lastName} {studentAssignment.assignment.description}");

                }
        }
















        public static CourseClass InsertCourseClass(List<CourseClass> CourseClasses)
        {
            CourseClass CourseClass = new CourseClass();
            CourseClasses.Add(CourseClass);
            return CourseClass;
        }

        public static Course InsertCourseClass(
            CourseClass CourseClass,
            List<Course> allCourses)
        {

            Console.WriteLine("Write a course");
            Console.WriteLine("Give the Title of course");
            string title = Console.ReadLine();
            Console.WriteLine("Give the Stream of course");
            string stream = Console.ReadLine();
            Console.WriteLine("Give the Type of course");
            string type = Console.ReadLine();
            Console.WriteLine("Give Start Date of course");
            DateTime start_date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give End Date of course");
            DateTime end_date = Convert.ToDateTime(Console.ReadLine());
            Course course = new Course(title, stream, type, start_date, end_date);
            allCourses.Add(course);
            CourseClass.course = course;
            return course;
        }

        public static Student InsertStudentClass(CourseClass CourseClasses, List<Student> allStudents)
        {

            Console.WriteLine("Write a student");
            Console.WriteLine("Give first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Give last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Give date of birth");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give tuition fees");
            decimal tutionFees = Convert.ToDecimal(Console.ReadLine());
            Student student = new Student(firstName, lastName, dateOfBirth, tutionFees);
            allStudents.Add(student);
            CourseClasses.addStudent(student);
            return student;
        }

        public static Trainer InsertTrainerClass(CourseClass CourseClass, List<Trainer> allTrainers)
        {
            Console.WriteLine("Write a trainer");
            Console.WriteLine("Give first name");
            string firstNametrainer = Console.ReadLine();
            Console.WriteLine("Give last name");
            string lastNametrainer = Console.ReadLine();
            Console.WriteLine("Give subject");
            string subject = (Console.ReadLine());

            Trainer trainer = new Trainer(firstNametrainer, lastNametrainer, subject);
            allTrainers.Add(trainer);
            CourseClass.addTrainer(trainer);
            return trainer;
        }

        public static Assignment InsertAssignmentClass(CourseClass CourseClass, List<Assignment> allAssignments)
        {
            Console.WriteLine("Write an assignment");
            Console.WriteLine("Give title");
            string titleassignment = Console.ReadLine();
            Console.WriteLine("Give description");
            string description = Console.ReadLine();
            Console.WriteLine("Give subdate");
            DateTime subdateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give oral Mark");
            int oralMark = int.Parse(Console.ReadLine());
            Console.WriteLine("Give oral Mark");
            int totalMark = int.Parse(Console.ReadLine());

            Assignment assignment = new Assignment(titleassignment, description, subdateTime, oralMark, totalMark);
            allAssignments.Add(assignment);
            CourseClass.addAssignment(assignment);
            return assignment;
        }









        public static void PrintAssignmentSubmissions(List<SchoolClass> schoolClasses)
        {
            DateTime startWeek = new DateTime();
            DateTime endWeek = new DateTime();
            Console.WriteLine("Give me a date");
            DateTime mydate = Convert.ToDateTime(Console.ReadLine());
            switch ((int)mydate.DayOfWeek)
            {
                case 0:
                    startWeek = mydate.AddDays(1);
                    endWeek = mydate.AddDays(5);
                    break;
                case 1:
                    startWeek = mydate;
                    endWeek = mydate.AddDays(4);
                    break;
                case 2:
                    startWeek = mydate.AddDays(-1);
                    endWeek = mydate.AddDays(3);
                    break;
                case 3:
                    startWeek = mydate.AddDays(-2);
                    endWeek = mydate.AddDays(2);
                    break;
                case 4:
                    startWeek = mydate.AddDays(-3);
                    endWeek = mydate.AddDays(1);
                    break;
                case 5:
                    startWeek = mydate.AddDays(-4);
                    endWeek = mydate;
                    break;
                case 6:
                    startWeek = mydate.AddDays(-4);
                    endWeek = mydate.AddDays(-1);
                    break;
            }

            foreach (var schoolclass in schoolClasses)
            {
                foreach (var courseClass in schoolclass.CourseClasses)
                {
                    foreach (var studentAssignment in courseClass.studentAssignments)
                    {
                        int start = DateTime.Compare(studentAssignment.assignment.subDateTime, startWeek);
                        int end = DateTime.Compare(studentAssignment.assignment.subDateTime, endWeek);
                        if (start >= 0 && end <= 0)
                        {
                            Console.WriteLine(studentAssignment.assignment.subDateTime.ToString("d") + " " + studentAssignment.student.lastName + " " + studentAssignment.assignment.description);
                        }
                    }
                }
            }
        }
    }
}




























































