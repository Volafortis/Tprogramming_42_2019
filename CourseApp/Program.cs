using System;

namespace CourseApp
{
    public class Program
    {
        public static double MyFunction(double a, double b,  double x)
        {
            var y = Math.Asin(Math.Pow(x, a)) + Math.Acos(Math.Pow(x, b));
            return y;
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            int i = 0;
            var y = new double[(int)((xk - xn) / dx)];
            for (double x = xn; x < xk; x += dx)
            {
                y[i] = MyFunction(a, b, x);
                i++;
            }

            return y;
        }

        public static double[] TaskB(double a, double b, double[] x)
        {
            var y = new double[x.Length];
            for (var i = 0; i < x.Length; i++)
            {
                y[i] = MyFunction(a, b,  x[i]);
            }

            return y;
        }

        public static void Main(string[] args)
        {
            const double a = 2.0;
            const double b = 3.0;
            const double xn = 0.11;
            const double xk = 0.36;
            const double dx = 0.05;
            double count = xn;
            Console.WriteLine("Task A:");
            foreach (var i in TaskA(a, b, xn, xk, dx))
            {
                Console.WriteLine($"x = {count += dx}, y = {i}");
            }

            Console.WriteLine();
            var x = new double[] { 0.08, 0.26, 0.35, 0.41, 0.53 };
            count = 0;
            Console.WriteLine("Task B:");
            foreach (var i in TaskB(a, b, x))
            {
                Console.WriteLine($"x = {x[(int)count++]}, y = {i}");
            }

            Console.ReadKey();
        }
    }
}