using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_pro
{
    class School
    {
        public List<CourseClass> CourseClasses = new List<CourseClass>();
        public List<Student> allStudents = new List<Student>();
        public List<Trainer> allTrainers = new List<Trainer>();
        public List<Assignment> allAssignments = new List<Assignment>();
        public List<Course> allCourses = new List<Course>();

        //Μέθοδο που την καλώ στη main για να τρέξει το πρόγραμμα 
        public School()
        {
            globalMenu();
        }

        //Menu επιλογής του χρήστη
        public void globalMenu()
        {
            string click;
            do
            {
                Console.WriteLine("\n     Μενού επιλογών");
                Console.WriteLine("     Για synthetic data, πατήστε SD");

                Console.WriteLine("********************************************************");
                Console.WriteLine("     Για λίστα students, πατήστε LS");
                Console.WriteLine("     Για λίστα trainers, πατήστε LT");
                Console.WriteLine("     Για λίστα assignments, πατήστε LA");
                Console.WriteLine("     Για λίστα courses, πατήστε LC");

                Console.WriteLine("********************************************************");
                Console.WriteLine("     Για λίστα students per course, πατήστε LSC");
                Console.WriteLine("     Για λίστα trainers per course, πατήστε LTC");
                Console.WriteLine("     Για λίστα assignments per course, πατήστε LAC");
                Console.WriteLine("     Για λίστα assignments per student, πατήστε LASC");
                Console.WriteLine("     Για λίστα students that belong to more than one courses, πατήστε LSM");
                Console.WriteLine("     Για να βρείτε ημερομηνία που παραδίδουν assignment, πατήστε LAS");

                Console.WriteLine("********************************************************");
                Console.WriteLine("     Για εισαγωγή course, πατήστε C");
                Console.WriteLine("     Για εισαγωγή student, πατήστε S");
                Console.WriteLine("     Για εισαγωγή trainer, πατήστε T");
                Console.WriteLine("     Για εισαγωγή assignment, πατήστε A");
                Console.WriteLine("     Για σύνδεση student και course, πατήστε SPC");
                Console.WriteLine("     Για σύνδεση trainer και course, πατήστε TPC");
                Console.WriteLine("     Για σύνδεση assignment και course, πατήστε APC");
                Console.WriteLine("     Για σύνδεση assignment ,student και course, πατήστε ASC\n");

                Console.WriteLine("********************************************************");
                Console.WriteLine("     Πατήστε EXIT για έξοδο");

                click = Console.ReadLine();
                Console.Clear();
                switch (click)
                {
                    case "SD":
                        UseSyntheticData();
                        ListAll();
                        break;
                    case "C":
                        AddCourse();
                        break;
                    case "S":
                        AddStudent();
                        break;
                    case "T":
                        AddTrainer();
                        break;
                    case "A":
                        AddAssignment();
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
                    case "ASC":
                        addAssignmentToStudent();
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
                        ListAssignmentPerCourse();
                        break;
                    case "LASC":
                        ListAssignmentPerStudentPerCourse();
                        break;
                    case "LSM":
                        ListStudentsMoreCourses();
                        break;
                    case "LAS":
                        ListAssignmentSubmissions();
                        break;
                    case "EXIT":
                        break;
                }
            } while (click != "EXIT");
        }

        // Χρήση synthetic data (με καρφωτά δεδομένα)
        public void UseSyntheticData()
        {
            int courseLastId;
            int studentLastId;
            int trainerLastId;
            int assignmentLastId;

            CourseClass CourseClass = new CourseClass();
            CourseClasses.Add(CourseClass);
            Course course1 = new Course("CB12", "C#", "PartTime", new DateTime(2020, 01, 01), new DateTime(2020, 06, 30));
            allCourses.Add(course1); //το τελευταίο βρίσκεται στην τελευταία θέση - 1
            courseLastId = allCourses.Count - 1;
            CourseClass.CourseId = courseLastId;
            Student student1 = new Student("Nikos", "Salichos", new DateTime(1994, 04, 23), 2000);
            allStudents.Add(student1);
            studentLastId = allStudents.Count - 1;
            CourseClass.addStudent(studentLastId);
            Student student3 = new Student("Corey", "Talor", new DateTime(1995, 08, 19), 1500);
            allStudents.Add(student3);
            studentLastId = allStudents.Count - 1;
            CourseClass.addStudent(studentLastId);
            Trainer trainer1 = new Trainer("Giorgos", "Pasparakis", "C#");
            allTrainers.Add(trainer1);
            trainerLastId = allTrainers.Count - 1;
            CourseClass.addTrainer(trainerLastId);
            Assignment assignment1 = new Assignment("Exercise1-C", "Write a program to build a food app", new DateTime(2020, 04, 16), 20, 80);
            allAssignments.Add(assignment1);
            assignmentLastId = allAssignments.Count - 1;
            CourseClass.addAssignment(assignmentLastId);
            CourseClass.assignToStudent(studentLastId, assignmentLastId);

            CourseClass CourseClass2 = new CourseClass();
            CourseClasses.Add(CourseClass2);
            CourseClass2.addStudent(studentLastId); // belong to more than one course
            Course course2 = new Course("CB12", "Java", "PartTime", new DateTime(2020, 01, 01), new DateTime(2020, 06, 30));
            allCourses.Add(course2);
            courseLastId = allCourses.Count - 1;
            CourseClass2.CourseId = courseLastId;
            Student student2 = new Student("Dimitris", "Michail", new DateTime(1994, 05, 23), 1800);
            allStudents.Add(student2);
            studentLastId = allStudents.Count - 1;
            CourseClass2.addStudent(studentLastId);
            Student student4 = new Student("Despoina", "Salichou", new DateTime(1994, 05, 23), 2200);
            allStudents.Add(student4);
            studentLastId = allStudents.Count - 1;
            CourseClass2.addStudent(studentLastId);
            Trainer trainer2 = new Trainer("Sandra", "Tyrovola", "Java");
            allTrainers.Add(trainer2);
            trainerLastId = allTrainers.Count - 1;
            CourseClass2.addTrainer(trainerLastId);
            Assignment assignment2 = new Assignment("Exercise-J", "Write a program to build a luna park app", new DateTime(2020, 04, 22), 20, 80);
            allAssignments.Add(assignment2);
            assignmentLastId = allAssignments.Count - 1;
            CourseClass2.addAssignment(assignmentLastId);
            CourseClass2.assignToStudent(studentLastId, assignmentLastId);
        }

        //Μέθοδο για εκτύπωση κάθε λίστας
        public void ListAll()
        {
            ListStudents();
            ListTrainers();
            ListAssignments();
            ListCourses();
            ListStudentsPerCourse();
            ListTrainersPerCourse();
            ListAssignmentPerCourse();
            ListAssignmentPerStudentPerCourse();
            ListStudentsMoreCourses();
        }

        //Προσθέτω νέο course
        public void AddCourse()
        {
            Console.WriteLine("Add a course!");
            Console.WriteLine("Give the Title of course");
            string title = Console.ReadLine();
            Console.WriteLine("Give the Stream of course");
            string stream = Console.ReadLine();
            Console.WriteLine("Give the Type of course");
            string type = Console.ReadLine();
            Console.WriteLine("Give Start Date of course DD/MM/YYYY");
            DateTime start_date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give End Date of course DD/MM/YYYY");
            DateTime end_date = Convert.ToDateTime(Console.ReadLine());
            Course course = new Course(title, stream, type, start_date, end_date);
            CourseClass CourseClass = new CourseClass();
            CourseClasses.Add(CourseClass);
            allCourses.Add(course);
            CourseClass.CourseId = allCourses.Count - 1;
        }

        //Προσθέτω νέο μαθητή
        public void AddStudent()
        {
            Console.WriteLine("Add a student!");
            Console.WriteLine("Give first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Give last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Give date of birth DD/MM/YYYY");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give tuition fees");
            decimal tutionFees = Convert.ToDecimal(Console.ReadLine());
            Student student = new Student(firstName, lastName, dateOfBirth, tutionFees);
            allStudents.Add(student);
        }

        //Προσθέτω νέο trainer
        public void AddTrainer()
        {
            Console.WriteLine("Add a trainer!");
            Console.WriteLine("Give first name");
            string firstNametrainer = Console.ReadLine();
            Console.WriteLine("Give last name");
            string lastNametrainer = Console.ReadLine();
            Console.WriteLine("Give subject");
            string subject = (Console.ReadLine());
            Trainer trainer = new Trainer(firstNametrainer, lastNametrainer, subject);
            allTrainers.Add(trainer);
        }

        //Προσθέτω νέο assignment
        public void AddAssignment()
        {
            Console.WriteLine("Add an assignment!");
            Console.WriteLine("Give title");
            string titleassignment = Console.ReadLine();
            Console.WriteLine("Give description");
            string description = Console.ReadLine();
            Console.WriteLine("Give subdate DD/MM/YYYY");
            DateTime subdateTime = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give oral Mark");
            int oralMark = int.Parse(Console.ReadLine());
            Console.WriteLine("Give oral Mark");
            int totalMark = int.Parse(Console.ReadLine());
            Assignment assignment = new Assignment(titleassignment, description, subdateTime, oralMark, totalMark);
            allAssignments.Add(assignment);
        }

        //Προσθέτω μαθητή σε course
        public void addStudentToCourse()
        {
            ListStudents();
            Console.WriteLine("Select a student");
            int studentId = int.Parse(Console.ReadLine());
            ListCourses();
            Console.WriteLine("Select a course for the student {0} {1}", allStudents[studentId].firstName, allStudents[studentId].lastName);
            int courseId = int.Parse(Console.ReadLine());

            CourseClass CourseClass = getCourseClassByCourseId(courseId);
            CourseClass.addStudent(studentId);
            ListStudentsPerCourse();
        }

        //Προσθέτω καθηγητή σε course
        public void addTrainerToCourse()
        {
            ListTrainers();
            Console.WriteLine("Select a trainer");
            int trainerId = int.Parse(Console.ReadLine());
            ListCourses();
            Console.WriteLine("Select a course for the trainer {0} {1}", allTrainers[trainerId].firstName, allTrainers[trainerId].lastName);
            int courseId = int.Parse(Console.ReadLine());

            CourseClass CourseClass = getCourseClassByCourseId(courseId);
            CourseClass.addTrainer(trainerId);
            ListTrainersPerCourse();
        }

        //Προσθέτω assignment σε course
        public void addAssignmentToCourse()
        {
            ListAssignments();
            Console.WriteLine("Select an assignment");
            int assignmentId = int.Parse(Console.ReadLine());
            ListCourses();
            Console.WriteLine("Select a course for the assignment {0} {1}", allAssignments[assignmentId].title, allAssignments[assignmentId].description);
            int courseId = int.Parse(Console.ReadLine());
            CourseClass CourseClass = getCourseClassByCourseId(courseId);
            CourseClass.addAssignment(assignmentId);
            ListAssignmentPerCourse();

        }


        private CourseClass getCourseClassByCourseId(int courseId)
        {
            foreach (var CourseClass in CourseClasses)
            {
                if (CourseClass.CourseId == courseId) return CourseClass;
            }
            return null;
        }

        //Προσθέτω assignment σε student
        public void addAssignmentToStudent()
        {
            Console.WriteLine("Select a course ");
            ListCourses();
            int courseId = int.Parse(Console.ReadLine());

            Console.WriteLine("Select a student");
            ListCourseStudents(courseId);
            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Select an assignment");
            ListCourseAssignments(courseId);
            int assignmentId = int.Parse(Console.ReadLine());
            ListCourseAssignments(courseId);
            CourseClass CourseClass = getCourseClassByCourseId(courseId);
            CourseClass.studentAssignments.Add(new StudentAssignment(studentId, assignmentId));
            ListAssignmentPerStudentPerCourse();
        }


        public void ListCourseStudents(int courseId)
        {
            Student student;
            foreach (var CourseClass in CourseClasses)
            {
                if (CourseClass.CourseId == courseId)
                {
                    for (int i = 0; i < CourseClass.students.Count; i++)
                    {
                        student = allStudents[CourseClass.students[i]];
                        Console.WriteLine("{0} {1}",
                            i,
                            student.lastName
                            );
                    }
                }
            }
        }


        public void ListCourseAssignments(int courseId)
        {
            Assignment assignment;
            foreach (var CourseClass in CourseClasses)
            {
                if (CourseClass.CourseId == courseId)
                {
                    for (int i = 0; i < CourseClass.assignments.Count; i++)
                    {
                        assignment = allAssignments[CourseClass.assignments[i]];
                        Console.WriteLine("{0} {1}",
                            i,
                            assignment.title
                            );
                    }
                }
            }
        }

        //Λίστα courses
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

        //Λίστα μαθητών
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

        //Λίστα trainers
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

        //Λίστα assignments
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

        //Λίστα μαθητών ανά course
        public void ListStudentsPerCourse()
        {
            Console.WriteLine("\nA LIST OF STUDENTS PER COURSE");

            foreach (var CourseClass in CourseClasses)
            {
                foreach (var studentId in CourseClass.students)
                {

                    Console.WriteLine("Course: {0} {1} {2} Firstname: {3} Lastname: {4}",
                    allCourses[CourseClass.CourseId].title,
                    allCourses[CourseClass.CourseId].stream,
                    allCourses[CourseClass.CourseId].type,
                    allStudents[studentId].firstName,
                    allStudents[studentId].lastName
                    );
                }
            }
        }

        //Λίστα trainer ανά course
        public void ListTrainersPerCourse()
        {
            Console.WriteLine("\nA LIST OF TRAINERS PER COURSE");
            foreach (var CourseClass in CourseClasses)
            {
                foreach (var trainerId in CourseClass.trainers)
                {
                    Console.WriteLine("Course: {0} {1} {2} Firstname: {3} Lastname: {4}",
                    allCourses[CourseClass.CourseId].title,
                    allCourses[CourseClass.CourseId].stream,
                    allCourses[CourseClass.CourseId].type,
                    allTrainers[trainerId].firstName,
                    allTrainers[trainerId].lastName
                    );
                }
            }
        }

        //Λίστα assignment ανά course
        public void ListAssignmentPerCourse()
        {
            Console.WriteLine("\nA LIST OF ASSIGNMENT PER COURSE");
            foreach (var CourseClass in CourseClasses)
            {
                foreach (var assignmentId in CourseClass.assignments)
                {
                    Console.WriteLine("Course: {0} {1} {2} Assignment title: {3} Description : {4}",
                        allCourses[CourseClass.CourseId].title,
                        allCourses[CourseClass.CourseId].stream,
                        allCourses[CourseClass.CourseId].type,
                        allAssignments[assignmentId].title,
                        allAssignments[assignmentId].description
                        );
                }
            }

        }

        //Λίστα assignment ανά μαθητή ανά course
        public void ListAssignmentPerStudentPerCourse()
        {
            Course course;
            Student student;
            Assignment assignment;
            Console.WriteLine("\nA LIST OF ASSIGNMENTS PER STUDENT(PER COURSE)");
            foreach (var CourseClass in CourseClasses)
            {
                course = allCourses[CourseClass.CourseId];
                foreach (var studentAssignment in CourseClass.studentAssignments)
                {
                    student = allStudents[studentAssignment.studentId];
                    assignment = allAssignments[studentAssignment.assignmentId];
                    Console.WriteLine("Course: {0} {1} {2} Student: {3} {4} Assignment: {5} {6}",
                        course.title,
                        course.stream,
                        course.type,
                        student.firstName,
                        student.lastName,
                        assignment.title,
                        assignment.description
                        );
                }
            }

        }

        //Λίστα μαθητών που ανήκει σε πάνω από 1 course
        public void ListStudentsMoreCourses()
        {
            List<int> _students = new List<int>();
            Console.WriteLine("\nA LIST OF STUDENTS THAT BELONG TO MORE THAN ONE COURSES");
            foreach (var courseClass in CourseClasses)
            {
                foreach (var studentId in courseClass.students)
                {
                    if (_students.Contains(studentId))
                    {
                        Console.WriteLine("Student: {0} {1}",
                        allStudents[studentId].firstName,
                        allStudents[studentId].lastName
                        );
                    }
                    else _students.Add(studentId);
                }
            }

        }

        //Μέθοδο που βρίσκει μαθητές που παραδίδουν assignment βάση της ημερομηνίας που δίνει ο χρήστης
        public void ListAssignmentSubmissions()
        {
            DateTime startWeek = new DateTime();
            DateTime endWeek = new DateTime();
            Console.WriteLine("Δώστε ημερομηνία σε μορφή DD/MM/YYYY");
            DateTime subDate = Convert.ToDateTime(Console.ReadLine());
            int numSubDate = (int)subDate.DayOfWeek;

            if (numSubDate == 1)

            {
                startWeek = subDate;
                endWeek = subDate.AddDays(4);
            }
            else if (numSubDate == 2)
            {
                startWeek = subDate.AddDays(-1);
                endWeek = subDate.AddDays(3);

            }
            else if (numSubDate == 3)
            {
                startWeek = subDate.AddDays(-2);
                endWeek = subDate.AddDays(2);
            }
            else if (numSubDate == 4)
            {
                startWeek = subDate.AddDays(-3);
                endWeek = subDate.AddDays(1);
            }
            else if (numSubDate == 5)
            {
                startWeek = subDate.AddDays(-4);
                endWeek = subDate;
            }



            Assignment assignment;
            Student student;
            foreach (var CourseClass in CourseClasses)
            {
                foreach (var studentAssignment in CourseClass.studentAssignments)
                {
                    assignment = allAssignments[studentAssignment.assignmentId];
                    student = allStudents[studentAssignment.studentId];
                    int start = DateTime.Compare(assignment.subDateTime, startWeek);
                    int end = DateTime.Compare(assignment.subDateTime, endWeek);
                    if (start >= 0 && end <= 0)
                    {
                        Console.WriteLine(assignment.subDateTime.ToString("d") + " " + student.lastName + " " + assignment.description);
                    }
                }
            }
        }
    }
}

