using Lession3;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student(1, "Hùng", "+8412345678", "dễ");
        Console.WriteLine(student.Id);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.PhoneNumber);
        Console.WriteLine(student.Email);

    }
}