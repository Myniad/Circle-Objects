using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    public class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Console.WriteLine(CalculateFormattedCircumference());
            Console.WriteLine(CalculateFormattedArea());

        }


        //methods
        public double CalculateCircumference()
        {
            return 2 * (Math.PI * Radius);
        }
        public string CalculateFormattedCircumference()
        {
            double ValueCirc = CalculateCircumference();
            return $"Circumference: {FormatNumber(ValueCirc)}";
        }
        public double CalculateArea()
        {
            return (Math.PI * Radius*Radius);
        }
        public string CalculateFormattedArea()
        {
            double ValueArea = CalculateArea();
            return $"Area: {FormatNumber(ValueArea)}";
        }
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString();
        }


    }
}
