using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Manager
{
    internal class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            students = new List<Student>();
            universities = new List<University>();

            universities.Add(new University() { Id = 1, Name = "Makerere" });
            universities.Add(new University() { Id = 2, Name = "Ndejje" });

            students.Add(new Student() { Id = 1, Name = "Hamza", Age = 23, Gender = "male", UnversityId = 2 });
            students.Add(new Student() { Id = 2, Name = "Eric", Age = 21, Gender = "male", UnversityId = 1 });
            students.Add(new Student() { Id = 3, Name = "George", Age = 22, Gender = "male", UnversityId = 2 });
            students.Add(new Student() { Id = 4, Name = "Brian", Age = 19, Gender = "male", UnversityId = 1 });
            students.Add(new Student() { Id = 5, Name = "Angela", Age = 17, Gender = "female", UnversityId = 1 });
            students.Add(new Student() { Id = 6, Name = "Magy", Age = 20, Gender = "female", UnversityId = 1 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("\nMale students: ");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("\nFemale students: ");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("\nStudents sorted by age: ");

            foreach (Student student in sortedStudents)
            {
                student.Print();

            }
        }

        public void AllStudentsFromMak()
        {
            IEnumerable<Student> makStudents = from student in students
                                               join university in universities on student.UnversityId equals university.Id
                                               where university.Name == "Makerere"
                                               select student;

            Console.WriteLine("\nMakerere Students : ");

            foreach (Student student in makStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int id)
        {
            IEnumerable<Student> myStudents = from student in students
                                              join university in universities on student.UnversityId equals university.Id
                                              where university.Id == id
                                              select student;

            Console.WriteLine($"\nStudents form uni with Id {id} : ");

            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityCollection()
        {
            var newCollection = from student in students
                                join university in universities on student.UnversityId equals university.Id
                                orderby student.Name
                                select new { studentName = student.Name, universtyName = university.Name };

            Console.WriteLine($"\nNew collection:");

            foreach (var col in newCollection)
            {
                Console.WriteLine($"Student {col.studentName} from {col.universtyName} university");
            }
        }
    }
}
