using Logic;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*Person person1 = new("Juan", "mario", 3993932);
            Console.WriteLine(person1);
            Console.WriteLine(person1.CompleteName);*/

            Student student = new("Emma", "Green", 38443932, 112345);

            Console.WriteLine(student);
            Console.WriteLine(student.SayHi());
        }
    }
}