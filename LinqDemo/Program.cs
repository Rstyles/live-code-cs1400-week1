namespace LinqDemo;

class Program
{
    static void Main(string[] args)
    {
        List<Student> enrolledStudents =
        [
            new Student(1, "John", 80.00),
            new Student(1, "Bob", 68.24),
            new Student(1, "John", 75.20),
            new Student(1, "Mary", 75.20),
            new Student(1, "Lee", 58.68),
            new Student(1, "Fred", 41.56),
            new Student(1, "Alice", 100.00),
            new Student(1, "George", 95.46),
        ];

        var above80 = enrolledStudents.Where(s => s.Grade >= 80.00).ToList();
        var avgGrade = enrolledStudents.Average(s => s.Grade);


        
    }
}
