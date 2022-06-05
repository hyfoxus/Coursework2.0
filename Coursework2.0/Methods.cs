using AngouriMath;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Coursework2._0
{
    static class Methods
    {
        public static double Fib(bool minMax, string function, double a, double b, double epsilon, string filePath) //if minMax = true - then return local minimum
        {
            FileStream fs = File.Create(filePath);
            fs.Close();
            Function func = new Function(function);
            StreamWriter writer = new StreamWriter(filePath, false);
            writer.WriteLine(function);
            writer.WriteLine("Borders[" + a + ";" + b + "] Accuracy:" + epsilon);
            int n = (int)((b - a) / epsilon);
            writer.WriteLine("Amount of steps: " + n);
            for (int i = 1; i < n ; i++)
            {
                double lambda = a + ((double)GetFibNumber(n - i - 1) / (double)GetFibNumber(n - i + 1))*(b-a);
                double nuy = a + ((double)GetFibNumber(n - i) / (double)GetFibNumber(n - i + 1)) * (b - a);
                writer.WriteLine("Lambda = " + lambda + " Nyu = " + nuy);
                writer.WriteLine("f(lambda) = " + func.calculate(lambda) + " f(nyu) = " + func.calculate(nuy));
                if (func.calculate(lambda) > func.calculate(nuy))    
                {
                    if (minMax) a = lambda;
                    else b = nuy;
                }
                else
                {
                    if (minMax) b = nuy;
                    else a = lambda;
                }
                writer.WriteLine("New borders[" + a + ";" + b + "] ");
               
            }
           
            
            if (func.calculate(b) < func.calculate(a))
            {
                if (minMax)
                {
                    writer.WriteLine("Result: " + b);
                    writer.Close();
                    return b;
                    
                }
                else
                {
                    writer.WriteLine("Result: " + a);
                    writer.Close();
                    return a;
                    
                }
            }
            else
            {
                if (minMax)
                {
                    writer.WriteLine("Result: " + a);
                    writer.Close();
                    return a;
                    
                }
                else
                {
                    writer.WriteLine("Result: " + b);
                    writer.Close();
                    return b;
                }
            }
           

        }
        static long GetFibNumber(int n)
        {
            double aux = (Pow(((1+Sqrt(5))/2), n)-(Pow(((1 - Sqrt(5)) / 2), n)))/(Sqrt(5));
            long fibNumber = Convert.ToInt64(aux);
            
            return fibNumber;
        }

        public static double func(string function, double x)
        {
            Function func = new Function(function);
            return func.calculate(x);
        }
    }

    
}
