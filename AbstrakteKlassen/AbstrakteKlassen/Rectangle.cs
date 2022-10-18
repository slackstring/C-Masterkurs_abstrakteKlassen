using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal class Rectangle : Shape
    {
        //Eigenschaften
        public double Width { get; set; }
        public double Height { get; set; }

        //Konstruktor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        //implementierte abstrakte Methode
        public override double GetArea()
        {
            return Width * Height;
        }
        //ToString Methode überschreiben
        public override string ToString()
        {
            return "Rechteck mit einer Höhe von" + Height + " und Breite von " + Width;
        }
    }
}
