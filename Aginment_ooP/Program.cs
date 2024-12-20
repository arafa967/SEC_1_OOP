namespace Aginment_ooP
{
    #region 1- question   
    //enum WeekDays
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //}
    #endregion

    #region 2- question
    //struct Person
    //{
    //    public string Name;
    //    public int Age;
    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //}
    #endregion

    #region 3- question
    //{
    //    Spring,Summer,Autumn,Winter
    //}
    #endregion

    #region 4- question
    //[Flags]
    //enum Permissions
    //{
    //    Read, Write, Delete, Execute
    //}

    #endregion

    #region 5- question
    //enum Colors
    //{
    //    Red, Green, Blue
    //}
    #endregion

    #region 6- question
    //struct Point
    //{
    //    public double X { get; set; }
    //    public double Y { get; set; }

    //    public Point(double x, double y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public double Distance(Point p)
    //    {
    //        double dx = p.X - X;
    //        double dy = p.Y - Y;
    //        return  Math.Sqrt( dx * dx + dy * dy);
    //    }
    //}
    #endregion

    #region 7- question
    //struct Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }

    //    public Person(string name, int age)
    //    {
    //       Name = name;
    //        Age = age;
    //    }
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            #region 1- question
            //foreach(WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region 2- question
            //Person[] people = new Person[3];
            //people[0] = new Person("Arafa", 20);
            //people[1] = new Person("Mohamed", 30);
            //people[2] = new Person("Fatma", 15);
            //foreach (var Person in people)
            //{
            //    Console.WriteLine($"Name:{Person.Name},Age{Person.Age}");
            //}
            #endregion

            #region 3- question
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}

            #endregion

            #region 4- question

            //Permissions userPermissions = Permissions.Read | Permissions.Write;
            //Console.WriteLine($"Current Permissions: {userPermissions}");


            //userPermissions |= Permissions.Delete;
            //Console.WriteLine($"Added Delete: {userPermissions}");


            //userPermissions &= ~Permissions.Write;
            //Console.WriteLine($"Removed Write: {userPermissions}");


            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("User has Read permission.");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have Read permission.");
            //}


            #endregion

            #region 5- question
            //Console.Write("Enter A Coolor Name: ");
            //string str = Console.ReadLine();
            //if (Enum.TryParse(str, true, out Colors color))
            //    Console.WriteLine($"{color} Is A Primary Color.");

            //else
            //    Console.WriteLine($"{str} Is Not A Primary Color");

            #endregion

            #region 6- question
            //Console.WriteLine("Enter The Coordinates Of The First Point (X Y):");
            //string[] point1  = Console.ReadLine().Split(' ');
            //double d1 = double.Parse(point1 [0]);
            //double d2 = double.Parse(point1 t[1]);
            //Point point01 = new Point(d1, d2);
            //Console.WriteLine("Enter The Coordinates Of The Second Point (X Y):");
            //string[] point2 = Console.ReadLine().Split(' ');
            //double d11 = double.Parse(point2 [0]);
            //double d12 = double.Parse(point2 [1]);
            //Point point02 = new Point(d11, d12);

            //double distance = point01.Distance(point02);

            //Console.WriteLine($"The Distance Between The Two Points Is: {distance:F2}");
            #endregion

            #region 7- question
            //Person[] person = new Person[3];

            //for (int i = 0; i < person.Length; i++)
            //{
            //    Console.WriteLine($"Enter Details For Person: {i + 1}");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());
            //    person[i] = new Person(name, age);
            //}
            //Person oldPerson = person[0];
            //foreach (Person p in person)
            //{
            //    if(p.Age > oldPerson.Age )
            //      oldPerson = p;
            //}
            //Console.WriteLine($"The Oldest Person Is {oldPerson.Name} with {oldPerson.Age} years.");
            #endregion


        }
    }
}
