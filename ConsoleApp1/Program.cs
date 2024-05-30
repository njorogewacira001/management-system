/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ForLoopExample
{
    class Program
    {
        public static void Main(string[] args)
        {
 // loop           
            /*Console.Write("Enter how many times to loop: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            
            if (int.TryParse(Console.ReadLine(), out loopCounter) && loopCounter > 0)
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine("loop");
                }
            }
            else
            {
                Console.WriteLine("Sorry, please enter a value above 0.");
            }

            /*
            for (int i = 0; i < 5; i += 2)
            {
                Console.WriteLine(i);
            }
            */
 
 //while loop

          /* Console.Write("Enter how many times to loop: ");
            int loopCounter;
         
            if (int.TryParse(Console.ReadLine(), out loopCounter) && loopCounter > 0)
            {
                int i = 0;
                
                while (i < loopCounter)
                {
                    Console.WriteLine("loop");
                    i++;
                }
            }
            else
            {
               
                Console.WriteLine("Sorry, please enter a value above 0.");
            }

            
            Console.ReadLine();*/

            //Conditional operator   
            
            /*int age = 10;
            if (age >= 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
               Console.WriteLine("Invalid"); 
            }
            String result = age >= 0 ? "valid" : "Invalid";
            Console.WriteLine();
            Console.ReadLine();
            */

//multiplication            

            /*Console.Write("enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}" , i , number , i * number);
            }

            Console.ReadLine();*/

           /* for (int i = 0; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/

            /* StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                sb.Append("Number ");
                sb.Append(i);
                sb.Append(", ");
            }
            string result = sb.ToString();
            Console.WriteLine(result); 

           
            Console.ReadLine();*/

 //Password checker

            /*Console.WriteLine("enter password:");
            string password = Console.ReadLine();

            Console.WriteLine("enter password again:");
            string passwordC = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Equals(passwordC))
                {
                    Console.WriteLine("password match");
                }
                else
                {
                    Console.WriteLine("password do not match");
                }
                }
                else
                {
                    Console.WriteLine("please enter a password confirmation:");
                }
                

            }
            else
            {
                Console.WriteLine("please enter a password:");
            }

            Console.ReadLine();*/
            
//ARRAY
            /*int[] numbers = new int[10];

            Console.Write("enter a number");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter a number");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter a number");
            numbers[2] = Convert.ToInt32(Console.ReadLine());*/

            //Console.WriteLine($"{numbers[0]},{numbers[1]},{numbers[2]}");

//Simple array

          /*  for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("enter a number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= numbers.Length; i++);
            {
                Console.WriteLine($"{numbers}");
            }

            Console.ReadLine();*/

//Array sortin

            /*int[] numbers = new int []
            {
                1,2,9,5,2,7,8,0
            };

            string test ="";
            test.Replace("","");

            Array.Sort(numbers);

            foreach(int num in numbers)

            {
                Console.WriteLine($"{num}");
            }
            Console.ReadLine();*/

//array clearin

            /*int[] numbers = new int[]
            {
                0,1,2,3,4,5,6,7,8
            } ;

            //Aray.Clear(numbers, 0 , numbers.Length);
            Array.Clear(numbers,5,5);
            for (int i = 5; i < 10; i++)
            {
                numbers[i] = default;
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item}");
            }*/
 
 //search usin indexof

            /*int[] numbers = new int[]
            {
                90, 177, 22, 33 , 46
            };

            Console.Write("enter a number to search:");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers, search);

            

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == search)
                {
                    position = 1;
                }
            }

            if (position >-1)
            {
                Console.WriteLine($"number{search} been found at position{position}");
            }
            else{
                Console.WriteLine("number {search} not found"); 
            }*/

//LIST
           /*
           ]]]]]]]]] int[] numbers = new int[3]
            {
                1,2,3
            };
            List<int> listnumbers = new List<int>();

            listnumbers.Add(1);
            listnumbers.Add(2);
            listnumbers.Add(3);

            Console.ReadLine();*/

//dictionary

       /* Dictionary<int, string> dict = new Dictionary<int, string>();
        
        dict.Add(1, "Apple");
        dict.Add(2, "Banana");
        dict.Add(3, "Cherry");
        
        Console.WriteLine("Element with key 2: " + dict[2]);
        
        if (dict.ContainsKey(3))
        {
            Console.WriteLine("Key 3 exists in the dictionary.");
        }
        
        foreach (KeyValuePair<int, string> kvp in dict)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
        
        dict.Remove(2);
        
        Console.WriteLine("Number of elements in the dictionary: " + dict.Count);

       
        if (dict.TryGetValue(1, out string value))
        {
            Console.WriteLine("Value associated with key 1: " + value);
        }
        else
        {
            Console.WriteLine("Key 1 not found.");

        }*/

//Reference parameter

        /*int num = 10;
        string name = "joe";
        Assign(ref num , ref name);
        Console.WriteLine(num);
        Console.WriteLine(name);*/

        /*string name = "Joe";

        Console.Write("enter your name");
        string newName = Console.ReadLine();

        if (changeName(ref name, newName))
        {
            Console.WriteLine($"your name is {name}!");
        }
        else
        {
            Console.WriteLine("new name cannot be empty");
        }
     

        Console.ReadLine();    

        }

      
        static bool changeName(ref string name, string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
            
            
        }
        static void Assign(ref int num, ref string name)
        {
            name = "Aba";
            num = 20;
            

             
        }
    }

}*/


using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Student(int studentID, string name, DateTime dateOfBirth)
    {
        StudentID = studentID;
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return $"ID: {StudentID}, Name: {Name}, DOB: {DateOfBirth.ToShortDateString()}";
    }
}

public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
    public int Credits { get; set; }

    public Course(int courseID, string courseName, int credits)
    {
        CourseID = courseID;
        CourseName = courseName;
        Credits = credits;
    }

    public override string ToString()
    {
        return $"ID: {CourseID}, Name: {CourseName}, Credits: {Credits}";
    }
}

public class Enrollment
{
    public int StudentID { get; set; }
    public int CourseID { get; set; }

    public Enrollment(int studentID, int courseID)
    {
        StudentID = studentID;
        CourseID = courseID;
    }
}






public class DataManager
{
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Course> Courses { get; set; } = new List<Course>();
    public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    // Add a student
    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    // Add a course
    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    // Enroll a student in a course
    public void EnrollStudent(int studentID, int courseID)
    {
        Enrollments.Add(new Enrollment(studentID, courseID));
    }

    // Find a student by ID
    public Student FindStudent(int studentID)
    {
        return Students.FirstOrDefault(s => s.StudentID == studentID);
    }

    // Find a course by ID
    public Course FindCourse(int courseID)
    {
        return Courses.FirstOrDefault(c => c.CourseID == courseID);
    }

    // List all students
    public List<Student> GetAllStudents()
    {
        return Students;
    }

    // List all courses
    public List<Course> GetAllCourses()
    {
        return Courses;
    }

    // List all enrollments
    public List<Enrollment> GetAllEnrollments()
    {
        return Enrollments;
    }
}



class Program
{
    static DataManager dataManager = new DataManager();

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Student Information Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Enroll Student");
            Console.WriteLine("4. View Students");
            Console.WriteLine("5. View Courses");
            Console.WriteLine("6. View Enrollments");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddCourse();
                    break;
                case "3":
                    EnrollStudent();
                    break;
                case "4":
                    ViewStudents();
                    break;
                case "5":
                    ViewCourses();
                    break;
                case "6":
                    ViewEnrollments();
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Clear();
        Console.WriteLine("Add Student");

        Console.Write("Enter Student ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
        DateTime dob = DateTime.Parse(Console.ReadLine());

        dataManager.AddStudent(new Student(id, name, dob));

        Console.WriteLine("Student added successfully. Press Enter to continue.");
        Console.ReadLine();
    }

    static void AddCourse()
    {
        Console.Clear();
        Console.WriteLine("Add Course");

        Console.Write("Enter Course ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Course Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Credits: ");
        int credits = int.Parse(Console.ReadLine());

        dataManager.AddCourse(new Course(id, name, credits));

        Console.WriteLine("Course added successfully. Press Enter to continue.");
        Console.ReadLine();
    }

    static void EnrollStudent()
    {
        Console.Clear();
        Console.WriteLine("Enroll Student");

        Console.Write("Enter Student ID: ");
        int studentID = int.Parse(Console.ReadLine());

        Console.Write("Enter Course ID: ");
        int courseID = int.Parse(Console.ReadLine());

        dataManager.EnrollStudent(studentID, courseID);

        Console.WriteLine("Student enrolled successfully. Press Enter to continue.");
        Console.ReadLine();
    }

    static void ViewStudents()
    {
        Console.Clear();
        Console.WriteLine("Students");

        foreach (var student in dataManager.GetAllStudents())
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    static void ViewCourses()
    {
        Console.Clear();
        Console.WriteLine("Courses");

        foreach (var course in dataManager.GetAllCourses())
        {
            Console.WriteLine(course);
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    static void ViewEnrollments()
    {
        Console.Clear();
        Console.WriteLine("Enrollments");

        foreach (var enrollment in dataManager.GetAllEnrollments())
        {
            var student = dataManager.FindStudent(enrollment.StudentID);
            var course = dataManager.FindCourse(enrollment.CourseID);

            Console.WriteLine($"Student: {student.Name}, Course: {course.CourseName}");
        }

        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }
}

