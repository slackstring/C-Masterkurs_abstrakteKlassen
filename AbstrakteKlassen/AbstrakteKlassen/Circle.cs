using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal class Circle : Shape
    {
        //Eigenschaften
        public double Radius { get; set; }
        //Konstruktor
        public Circle(double radius)
        {
            Radius = radius;
        }
        //implementierte abstrakte Methode
        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
        //ToString Methode überschreiben
        public override string ToString()
        {
            return "Kreis mit einem Radius von " + Radius;
        }
    }
}
