using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_2
{
    class Triangle
    {
        private double x1, y1;
        private double x2, y2;
        private double x3, y3;
        private double AB;
        private double AC;
        private double BC;
        private double perimeter;
        private double square;

        public Triangle() { }

        public Triangle(double _a, double _b, double _c)
        {
            AB = _a;
            AC = _b;
            BC = _c;

            perimeter = CalculatePerimeter(AB, AC, BC);
            square = CalculateSquare(AB, AC, BC);
        }

        public Triangle(double _x1, double _y1, double _x2, double _y2, double _x3, double _y3)
        {
            x1 = _x1;
            y1 = _y1;

            x2 = _x2;
            y2 = _y2;

            x3 = _x3;
            y3 = _y3;

            AB = CalculateLengthOfSide(_x1, _y1, _x2, _y2);
            AC = CalculateLengthOfSide(_x2, _y2, _x3, _y3);
            BC = CalculateLengthOfSide(_x3, _y3, _x1, _y1);

            perimeter = CalculatePerimeter(AB, AC, BC);
            square = CalculateSquare(AB, AC, BC);
        }

        public double CalculatePerimeter(double AB, double AC, double BC)
        {
            Console.WriteLine("Периметр трикутника: " + (AB + AC + BC));
            return AB + AC + BC;
        }

        public double CalculateSquare(double AB, double AC, double BC)
        {
            perimeter = CalculatePerimeter(AB, AC, BC);
            Console.WriteLine("Площа трикутника: " + (Math.Sqrt((perimeter / 2) * ((perimeter / 2) - AB) * ((perimeter / 2) - AC) * ((perimeter / 2) - BC))));
            return Math.Sqrt((perimeter / 2) * ((perimeter / 2) - AB) * ((perimeter / 2) - AC) * ((perimeter / 2) - BC));
        }

        public double CalculateLengthOfSide(double _x1, double _y1, double _x2, double _y2)
        {
            Console.WriteLine("Довжина вiдрiзку: " + (Math.Sqrt((_x2 - _x1) * (_x2 - _x1) + (_y2 - _y1) * (_y2 - _y1))));
            return Math.Sqrt((_x2 - _x1) * (_x2 - _x1) + (_y2 - _y1) * (_y2 - _y1));
        }

        static void Main(string[] args)
        {
            Triangle tr = new Triangle();
            tr.x1 = 5;
            tr.y1 = 7;
            tr.x2 = 2;
            tr.y2 = 3;
            tr.x3 = 4;
            tr.y3 = 5;

            tr.AB = tr.CalculateLengthOfSide(tr.x1, tr.y1, tr.x2, tr.y2);
            tr.AC = tr.CalculateLengthOfSide(tr.x2, tr.y2, tr.x3, tr.y3);
            tr.BC = tr.CalculateLengthOfSide(tr.x3, tr.y3, tr.x1, tr.y1);
            tr.CalculatePerimeter(tr.AB, tr.AC, tr.BC);
            tr.CalculateSquare(tr.AB, tr.AC, tr.BC);
        }

    }
}
