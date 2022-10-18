using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);
            Circle circ = new Circle(3);
            Console.WriteLine(rect.GetArea());
            Console.WriteLine(circ.GetArea());
            Console.ReadKey();
        }
    }
}
