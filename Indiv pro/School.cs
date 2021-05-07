using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class School
    {
        List<SchoolClass1> schoolClasses = new List<SchoolClass1>();
        public List<Course> allCourses = new List<Course>();
        public List<Student> allStudents = new List<Student>();
        public List<Trainer> allTrainers = new List<Trainer>();
        public List<Assignment> allAssignments = new List<Assignment>();
        public List<StudentCourse> allStudentCourses = new List<StudentCourse>();
        public List<TrainerCourse> allTrainerCourses = new List<TrainerCourse>();
        public List<AssignmentCourse> allAssignmentCourses = new List<AssignmentCourse>();
        public List<AssignmentStudentCourse> allAssignmentStudentCourses = new List<AssignmentStudentCourse>();

        public School()
        {
            globalMenu();
        }
        public void globalMenu()
        {

            string command;
            do
            {
                Console.WriteLine("\nΜενού επιλογών: (Πατήστε EXIT για έξοδο)");
                Console.WriteLine("     Για synthetic data, πατήστε SD");

                Console.WriteLine("     Για εισαγωγή course, πατήστε C");
                Console.WriteLine("     Για εισαγωγή student, πατήστε S");
                Console.WriteLine("     Για εισαγωγή trainer, πατήστε T");
                Console.WriteLine("     Για εισαγωγή assignment, πατήστε A");
                Console.WriteLine("     Για σύνδεση student και course, πατήστε SPC");
                Console.WriteLine("     Για σύνδεση trainer και course, πατήστε TPC");
                Console.WriteLine("     Για σύνδεση assignment και course, πατήστε APC");
                Console.WriteLine("     Για σύνδεση assignment ,student και course, πατήστε ASSC");


                Console.WriteLine("     Για λίστα courses, πατήστε LC");
                Console.WriteLine("     Για λίστα students, πατήστε LS");
                Console.WriteLine("     Για λίστα trainers, πατήστε LT");
                Console.WriteLine("     Για λίστα assignments, πατήστε LA");

                Console.WriteLine("     Για λίστα student per course, πατήστε LSC");
                Console.WriteLine("     Για λίστα trainer per course, πατήστε LTC");
                Console.WriteLine("     Για λίστα assignment per course, πατήστε LAC");


                command = Console.ReadLine();
                switch (command)
                {
                    case "SD":
                        UseSyntheticData();
                        ListAll();
                        break;
                    case "C":
                        AddCourse();
                        // ListCourses();
                        break;
                    case "S":
                        AddStudent();
                        //ListStudents();
                        break;
                    case "T":
                        AddTrainer();
                        //ListTrainers();
                        break;
                    case "A":
                        AddAssignment();
                        //ListAssignments();
                        break;
                    case "SPC":
                        addStudentToCourse();
                        break;
                    case "TPC":
                        addTrainerToCourse();
                        break;
                    case "APC":
                        addAssignmentToCourse();
                        break;
                    case "ASSC":
                        addAssignmentStudentCourses();
                        break;
                    case "LC":
                        ListCourses();
                        break;
                    case "LS":
                        ListStudents();
                        break;
                    case "LT":
                        ListTrainers();
                        break;
                    case "LA":
                        ListAssignments();
                        break;
                    case "LSC":
                        ListStudentsPerCourse();
                        break;
                    case "LTC":
                        ListTrainersPerCourse();
                        break;
                    case "LAC":
                        addAssignmentToCourse();
                        break;
                    case "EXIT":
                        break;
                }
            } while (command != "EXIT");
        }

        public void UseSyntheticData()
        {
            int courseLastId;
            int studentLastId;
            int trainerLastId;
            int assignmentLastId;

            SchoolClass1 schoolClass1 = new SchoolClass1();
            schoolClasses.Add(schoolClass1);
            SchoolClass1 schoolClass2 = new SchoolClass1();
            schoolClasses.Add(schoolClass2);

            Course course1 = new Course("CB12", "C#", "Part_time", new DateTime(2020, 01, 01), new DateTime(2020, 06, 30));
            allCourses.Add(course1); //το τελευταίο βρίσκεται στην τελευταία θέση - 1
            courseLastId = allCourses.Count - 1;
            schoolClass1.CourseId = courseLastId;

            Course course2 = new Course("CB12", "Java", "Part_time", new DateTime(2020, 01, 01), new DateTime(2020, 06, 30));
            allCourses.Add(course2);
            courseLastId = allCourses.Count - 1;
            schoolClass2.CourseId = courseLastId;

            Student student1 = new Student("Despoina", "Salichou", new DateTime(1994, 04, 23), 200);
            allStudents.Add(student1);
            studentLastId = allStudents.Count - 1;
            schoolClass1.addStudent(studentLastId);

            Student student2 = new Student("Nikos", "Salichos", new DateTime(1994, 05, 23), 200);
            allStudents.Add(student2);
            studentLastId = allStudents.Count - 1;
            schoolClass2.addStudent(studentLastId);

            Student student3 = new Student("Christos", "Papadopoulos", new DateTime(1994, 04, 23), 200);
            allStudents.Add(student3);
            studentLastId = allStudents.Count - 1;
            schoolClass1.addStudent(studentLastId);

            Student student4 = new Student("Panagiota", "Sali", new DateTime(1994, 05, 23), 200);
            allStudents.Add(student4);
            studentLastId = allStudents.Count - 1;
            schoolClass2.addStudent(studentLastId);

            Trainer trainer1 = new Trainer("Katerina", "Papadopoulou", "C#");
            allTrainers.Add(trainer1);
            trainerLastId = allTrainers.Count - 1;
            schoolClass1.addTrainer(trainerLastId);

            Trainer trainer2 = new Trainer("Ioannis", "Spyropoulos", "Java");
            allTrainers.Add(trainer2);
            trainerLastId = allTrainers.Count - 1;
            schoolClass2.addTrainer(trainerLastId);

            Assignment assignment1 = new Assignment("Exercise1 CPT", "Write a program to display the first 10 natural numbers", new DateTime(2020, 04, 16), 20, 80);
            allAssignments.Add(assignment1);
            assignmentLastId = allAssignments.Count - 1;
            schoolClass1.addAssignment(assignmentLastId);

            Assignment assignment2 = new Assignment("Exercise1 JPT", "Write a program to create a list of students", new DateTime(2020, 04, 22), 20, 80);
            allAssignments.Add(assignment2);
            assignmentLastId = allAssignments.Count - 1;
            schoolClass2.addAssignment(assignmentLastId);


        }
        public void ListAll()
        {

            ListStudents();
            ListTrainers();
            ListAssignments();
            ListCourses();
            ListStudentsPerCourse();
            ListTrainersPerCourse();
            ListAssignmentPerCourse();
        }




        public void AddCourse()
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

        }
        public void AddStudent()
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
        }
        public void AddTrainer()
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
        }
        public void AddAssignment()
        {
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
        }
        public void addStudentToCourse()
        {
            ListStudents();
            Console.WriteLine("Διάλεξε μαθητή");
            int studentId = int.Parse(Console.ReadLine());
            ListCourses();
            Console.WriteLine("Διάλεξε course να βάλεις το μαθητή {0} {1}", allStudents[studentId].firstName, allStudents[studentId].lastName);
            int courseId = int.Parse(Console.ReadLine());

            StudentCourse studentCourse = new StudentCourse(studentId, courseId);
            allStudentCourses.Add(studentCourse);

            foreach (var studentcourse in allStudentCourses)
            {
                Console.WriteLine("{0} {1}", allStudents[studentCourse.studentId].firstName, allCourses[studentCourse.courseId].stream);
            }
        }
        public void addTrainerToCourse()
        {
            ListTrainers();
            Console.WriteLine("Διάλεξε Καθηγητή");
            int trainerId = int.Parse(Console.ReadLine());
            ListCourses();
            Console.WriteLine("Διάλεξε course να βάλεις τον καθηγητή {0} {1}", allTrainers[trainerId].firstName, allTrainers[trainerId].lastName);
            int courseId = int.Parse(Console.ReadLine());

            TrainerCourse trainerCourse = new TrainerCourse(trainerId, courseId);
            allTrainerCourses.Add(trainerCourse);

            foreach (var trainercourse in allTrainerCourses)
            {
                Console.WriteLine("{0} {1}", allTrainers[trainercourse.trainerId].firstName, allCourses[trainerCourse.courseId].stream);
            }
        }
        public void addAssignmentToCourse()
        {
            ListAssignments();
            Console.WriteLine("Διάλεξε Assignment");
            int assignmentId = int.Parse(Console.ReadLine());
            ListCourses();
            Console.WriteLine("Διάλεξε course να βάλεις τo assignment {0} {1}", allAssignments[assignmentId].title, allAssignments[assignmentId].description);
            int courseId = int.Parse(Console.ReadLine());

            AssignmentCourse assignmentCourse = new AssignmentCourse(assignmentId, courseId);
            allAssignmentCourses.Add(assignmentCourse);

            foreach (var assignmentcourseId in allAssignmentCourses)
            {
                Console.WriteLine("{0} {1}", allAssignments[assignmentId].title, allCourses[assignmentcourseId.courseId].stream);
            }
        }

        public void addAssignmentStudentCourses()
        {
            ListStudents();
            Console.WriteLine("Διάλεξε μαθητή ");
            int studentId = int.Parse(Console.ReadLine());
            ListAssignments();
            Console.WriteLine("Διάλεξε Assignment na βάλεις το μαθητή {0} {1}", allStudents[studentId].firstName, allStudents[studentId].lastName);
            int assignmentId = int.Parse(Console.ReadLine());
            ListCourses();
            Console.WriteLine("Διάλεξε course να βάλεις τo assignment {0} {1}", allAssignments[assignmentId].title, allAssignments[assignmentId].description);
            int courseId = int.Parse(Console.ReadLine());

            AssignmentStudentCourse assignmentStudentCourse = new AssignmentStudentCourse(assignmentId, studentId, courseId);
            allAssignmentStudentCourses.Add(assignmentStudentCourse);

            Console.WriteLine("\nA LIST OF ASSIGNMENT PER STUDENT (PER COURSE)");
            foreach (var assignmentstudentcourse in allAssignmentStudentCourses)
            {
                Console.WriteLine("{0} {1} {2}", allAssignments[assignmentId].title, allStudents[studentId].firstName, allCourses[courseId].stream);
            }


        }





        public void ListCourses()
        {
            Course course;
            Console.WriteLine("\nA LIST OF COURSES:");
            for (int i = 0; i < allCourses.Count; i++)
            {
                course = allCourses[i];
                Console.WriteLine("{0}. {1} {2} {3} {4} {5}", i, course.title, course.stream, course.type, course.startDate.ToString("d"), course.endDate.ToString("d"));
            }
        }
        public void ListStudents()
        {
            Student student;
            Console.WriteLine("\nA LIST OF STUDENTS");
            for (int i = 0; i < allStudents.Count; i++)
            {
                student = allStudents[i];
                Console.WriteLine("{0}. {1} {2} {3} {4}", i, student.firstName, student.lastName, student.dateOfBirth.ToString("d"), student.tuitionFees);
            }
        }
        public void ListTrainers()
        {
            Trainer trainer;
            Console.WriteLine("\nA LIST OF TRAINERS");
            for (int i = 0; i < allTrainers.Count; i++)
            {
                trainer = allTrainers[i];
                Console.WriteLine("{0}. {1} {2} {3}", i, trainer.lastName, trainer.firstName, trainer.subject);
            }
        }
        public void ListAssignments()
        {
            Assignment assignment;
            Console.WriteLine("\nA LIST OF ASSIGNMENTS");
            for (int i = 0; i < allAssignments.Count; i++)
            {
                assignment = allAssignments[i];
                Console.WriteLine($"{i}.{assignment.title} {assignment.description} {assignment.subDateTime.ToString("d")} {assignment.oralMark} {assignment.totalMark}");
            }
        }
        public void ListStudentsPerCourse()
        {
            Console.WriteLine("\nA LIST OF STUDENTS PER COURSE");

            foreach (var schoolClass in schoolClasses)
            {
                foreach (var studentId in schoolClass.allStudents)
                {

                    Console.WriteLine("Course: {0} {1} {2} Firstname: {3} Lastname: {4}",
                    allCourses[schoolClass.CourseId].title,
                    allCourses[schoolClass.CourseId].stream,
                    allCourses[schoolClass.CourseId].type,
                    allStudents[studentId].firstName,
                    allStudents[studentId].lastName
                    );
                }
            }
            foreach (var studentCourse in allStudentCourses)
            {
                Console.WriteLine("{0} {1}", allStudents[studentCourse.studentId].firstName, allCourses[studentCourse.courseId].stream);
            }
        }
        public void ListTrainersPerCourse()
        {
            Console.WriteLine("\nA LIST OF TRAINERS PER COURSE");
            foreach (var schoolClass in schoolClasses)
            {
                foreach (var trainerId in schoolClass.allTrainers)
                {
                    Console.WriteLine("Course: {0} {1} {2} Firstname: {3} Lastname: {4}",
                    allCourses[schoolClass.CourseId].title,
                    allCourses[schoolClass.CourseId].stream,
                    allCourses[schoolClass.CourseId].type,
                    allTrainers[trainerId].firstName,
                    allTrainers[trainerId].lastName
                    );
                }
            }
            foreach (var trainercourse in allTrainerCourses)
            {
                Console.WriteLine("{0} {1}", allTrainers[trainercourse.trainerId].firstName, allCourses[trainercourse.courseId].stream);
            }
        }
        public void ListAssignmentPerCourse()
        {
            Console.WriteLine("\nA LIST OF ASSIGNMENT PER COURSE");
            foreach (var schoolClass in schoolClasses)
            {
                foreach (var assignmentId in schoolClass.allAssignments)
                {
                    Console.WriteLine("{0} {1} {2} Assignment title: {3} Description : {4}",
                        allCourses[schoolClass.CourseId].title,
                        allCourses[schoolClass.CourseId].stream,
                        allCourses[schoolClass.CourseId].type,
                        allAssignments[assignmentId].title,
                        allAssignments[assignmentId].description
                        );
                }
            }
            foreach (var assignmentcourseId in allAssignmentCourses)
            {
                Console.WriteLine("{0} {1}", allAssignments[assignmentcourseId.assignmentId].title, allCourses[assignmentcourseId.courseId].stream);
            }

        }
        public void ListAssignmentStudentCourse()
        {


        }
    }
}

