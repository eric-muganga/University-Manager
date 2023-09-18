
using System.Threading.Channels;
using University_Manager;

UniversityManager um = new UniversityManager();

um.MaleStudents();
um.FemaleStudents();
um.SortStudentsByAge();
um.AllStudentsFromMak();
um.StudentAndUniversityCollection();

Console.WriteLine("\nEnter Id of university students : ");
string input = Console.ReadLine();
try
{
    int inputAsInt = Convert.ToInt32(input);
    um.AllStudentsFromThatUni(inputAsInt);
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();