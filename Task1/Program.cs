using Delegate;
using Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        var Students = new List<student>
            {
                new student("Habiba",67),
                new student("Mariam", 48),
                new student("Menaa", 77),
                new student("Mona", 90),
                new student("Asmaa", 14),
                new student("Aliaa", 50),
                new student("Rahmaa", 89),
                new student("Ola", 34),
                new student("Rahaf", 47),
                new student("Fareda", 68),
                new student("Salma", 28),
                new student("Rokaya", 60),
                new student("Eman", 93)
            };
        int passThreshold = 60;
        ScoreProcessor processor = new ScoreProcessor(passThreshold);

        var passStudent = processor.filterStudents(Students, ScoreProcessor.Passing);
        Console.WriteLine("pass students: ");
        foreach (var student in passStudent)
        {
            Console.WriteLine($"Name : {student.Name} , score :{student .Score}");
        }
        Console.WriteLine("###############################################");
        var failStudent = processor.filterStudents(Students, ScoreProcessor.Failing);
        Console.WriteLine("fail students: ");
        foreach (var student in failStudent)
        {
            Console.WriteLine($"Name : {student.Name} , score :{student.Score}");
        }
        Console.WriteLine("###############################################");
        double avarage = processor.calculateAvarage(ScoreProcessor.calcAvarage, Students);
        Console.WriteLine($"Avarage : {avarage}");
        Console.WriteLine("###############################################");
        var topScorer = Students.TopScorer();
        Console.WriteLine($"Top Scorer: {topScorer.Name} ({topScorer.Score})");
    
}
}