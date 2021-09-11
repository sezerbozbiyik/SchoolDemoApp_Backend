using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager(new EfStudentDal());
            foreach (var student in studentManager.GetAll())
            {
                Console.WriteLine(student.FullName);
            }

            Console.WriteLine("----------------");
            Console.WriteLine(studentManager.GetById(2).FullName);

        }
    }
}
