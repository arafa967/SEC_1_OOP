using System.Net.Http.Headers;
using Common;
namespace Demo
{
    enum Grades
    {
        // lables 
        A, B, C, D, E, F

    }
    enum Gender
    {
        Male =1, Female=2, M = 1 ,F = 2

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region what is accesse modifier
            TypeA obj = new TypeA();
            //obj.X = 10; invalid
            obj.Z = 30; //valid

            #endregion
            #region Enum 
            //Grades grade = Grades.A;
            //if (grade == Grades.A)
            //{
            //    Console.WriteLine("Congratulation A+");

            //}
            //else
            //{ 
            //    Console.WriteLine("Sorry :()");
            //}


            #endregion
            #region Struct
            Point p1 = new Point(4,2);
            // new Just for Constructor Selection 
            //Declare for object from "point"
            // Clr will Allocate 8 Byte unitialized at Stack
            Console.WriteLine(p1);
            #endregion
            #region What is oop 
            #endregion
            #region What is oop 
            #endregion
            #region Encapsulation 
            //Employee emp = new Employee(1, "Mark", 25000);
            ////Console.WriteLine(emp);
            ////2.1
            //emp.Salary = 1;
            //Console.WriteLine(emp.Salary);
            ////2.2
            //emp.Id = 1;
            //Console.WriteLine(emp.Id);
            #endregion
        }
    }
}
