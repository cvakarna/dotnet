using FactoryMethodDemo.Constants;
using FactoryMethodDemo.University;
using System;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Admissions App");
            var university = new UniversityProvider().ExecuteCreation(Universities.AnnaUniversity);
            string message = university.FreeSeat(67).Result;
            Console.WriteLine("From AnnaUniversity:\t"+message);
            Console.ReadKey();
            
        }
    }
}
