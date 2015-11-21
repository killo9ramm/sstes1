using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a =Triangle.Create(3,4,5);
            Console.WriteLine(a.CalculateStrictTriangleSquare());
            Console.ReadKey();
        }
    }
    public class Triangle
    {
        /// <summary>
        /// Создаем треугольник
        /// </summary>
        /// <param name="storny">Стороны треугольника</param>
        /// <returns></returns>
        public static Triangle Create(params int[] storny)
        {
            if (storny!=null && storny.Length == 3)
            {
                return new Triangle(storny
                    .OrderByDescending(a=>a).ToList());    
            }
            else
            {
                throw new ArgumentException("Invalid arguments to create triangle");
            }
        }

        private Triangle(List<int> list)
        {
            hypo = list[0];
            a = list[1];
            b = list[2];

            if (a + b < hypo) 
                throw new ArgumentOutOfRangeException("The figure is not the triangle. Hypo is too high.");
        }
        public int a { get; private set; }
        public int b { get; private set; }
        public int hypo { get; private set; }

        /// <summary>
        /// Возвращаем площадь прямоугольного треугольника
        /// </summary>
        /// <returns></returns>
        public int CalculateStrictTriangleSquare()
        {
            if (TriangleIsNotStrict())
            {
                throw new Exception("Triangle is not strict");
            }
            else
            {
                return (a * b) / 2;
            }
        }

        private bool TriangleIsNotStrict()
        {
            if (Math.Pow(a, 2) * Math.Pow(b, 2) != Math.Pow(hypo, 2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
