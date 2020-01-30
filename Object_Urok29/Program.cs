using System;

namespace Object_Urok29
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();

            int i = 5;
            int j = 5;

            Console.WriteLine(i.Equals(j));

            // Одинаковые варианты
            var oi = (object)i;  // Упаковка
            object oj = j;  // Упаковка

            Console.WriteLine(oi.Equals(oj));

            var p1 = new Point() { X = 5 };
            var p2 = new Point() { X = 5 };

            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine(i.GetHashCode());
            Console.WriteLine(oj.GetHashCode()); // Упакованная
            Console.WriteLine(new MyClass().GetHashCode());
            Console.WriteLine(p1.GetHashCode()); // Ссылочный

            Console.WriteLine(i.ToString());
            Console.WriteLine(p1.ToString()); // Ссылочный

            Console.WriteLine(i.GetType());
            Console.WriteLine(oi.GetType()); // Упакованная
            Console.WriteLine(p1.GetType()); // Ссылочный

            Console.WriteLine(typeof(Point) == p1.GetType());  // Так делать нельзя, опасный код.

            Console.WriteLine();
            Console.WriteLine(Object.Equals(5, 5)); // Значения равны.
            Console.WriteLine(Object.ReferenceEquals(5, 5)); // Не равны так как хранятся в памяти по отдельности. 
            Console.WriteLine(Object.ReferenceEquals(p2, p2)); // Один участок памяти по этому они равны.

            Console.WriteLine();

            var pp = new Point() { X = 7, Y = new Point() };
            var pp2 = pp;
            pp2.X = 77;
            pp2.Y = new Point() { X = 99 };
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);

            Console.WriteLine();

            var pp3 = pp.Clone();
            pp3.X = 88;
            pp3.Y.X = 222;
            Console.WriteLine(pp);
            Console.WriteLine(pp.Y);

            Console.ReadLine();
        }
    }
}
