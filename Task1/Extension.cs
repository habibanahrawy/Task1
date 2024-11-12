using Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Extension
    {
        public static void PrintstudentList(this List<student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name : {student.Name} , score : {student.Score}");
            }
        }
        public static student TopScorer(this List<student> students)
        {
            return students.OrderByDescending(student => student.Score).FirstOrDefault();
        }

    }
}
