using System;

namespace UniversityApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Age = 10;
            Console.WriteLine(human.Age);

            Student student = new Student();
            student.Age = 16;

            Console.WriteLine(student.Age);

            Phonebook phonebook = new Phonebook();


            phonebook.AddPhone("055123456789");
            phonebook.AddPhone("051123456789");
            phonebook.AddPhone("070123456789");


            Console.WriteLine("Nomreler:");
            foreach (var item in phonebook.Phones)
            {
                Console.WriteLine(item);
            }

            University adnsu = new University(3);

            adnsu.AddStudent(new Student() { Name = "Hikmet" });
            adnsu.AddStudent(new Student() { Name = "Abbas" });
            adnsu.AddStudent(new Student() { Name = "Nezrin" });
            adnsu.AddStudent(new Student() { Name = "Tofiq" });


            foreach (var item in adnsu.Students)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
