using System;
using Classes.Homework;
using Homework.MyNewClasses;
using Homework.MyClasses;
using ClassLibrary;




namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("Student");
        
            user1.UserName = null;

            Console.WriteLine(user1.UserName);

            Vehicle vhc = new Vehicle();
            //vhc.Brand = "dsfd";
            //vhc.Model = "df";
        }
    }
}
