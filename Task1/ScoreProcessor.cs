using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate bool scoreCriteria(student Student);
    public delegate double AvarageCalculate(List<student> Student);
    internal class ScoreProcessor
    {
        private readonly int passthreshold;
        public ScoreProcessor(int Passthreshold) 
        {
            passthreshold = Passthreshold;
        }
        public List<student> filterStudents(List<student> students, scoreCriteria criteria)
        {
            List<student> FilterStudent = new List<student>();
            foreach (var student in students)
            {
                if (criteria(student))
                {
                    FilterStudent.Add(student);
                }
            }
            return FilterStudent;
        }

        public static bool Passing(student student)
        {
            return student.Score >= 50;
        }
        public static bool Failing(student student)
        {
            return student.Score < 50;
        }


        public static double calcAvarage(List<student> students)
        {
            return students.Average(student => student.Score);
        }


        public double calculateAvarage(AvarageCalculate calcAvarge, List<student> students)
        {
            return calcAvarge(students);
        }
    }
}
