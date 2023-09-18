using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Manager
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //foreign key
        public int UnversityId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {this.Name} with Id {this.Id}, Gender {this.Gender}" +
                $" and age {this.Age} years from University with Id {this.UnversityId}");
        }
    }
}
