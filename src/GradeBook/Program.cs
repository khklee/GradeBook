namespace GradeBook
{
    class Program
    {
        static void Main(string[] args) 
        {   
            var book = new Book("Student's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(52.5);
            book.AddGrade(35.6);

            var stats = book.GetStatistics();
            
            Console.WriteLine($"The highest grade is {stats.Low}.");
            Console.WriteLine($"The lowest grade is {stats.High}.");

            Console.WriteLine($"The average grade is {stats.Average:N1}.");
        }
    }
}

