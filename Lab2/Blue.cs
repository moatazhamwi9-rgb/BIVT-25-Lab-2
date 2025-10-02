using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        
        public double Task1(int n, double x)
        {
            double answer = 0;
            double term = 1;
            
            for (int i = 1; i <= n; i++)
            {
                term = term * x / i;
                answer = answer + term;
            }
            
            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;
            
            for (int i = 1; i <= n; i++)
            {
                double term = 1.0 / (i * (i + 1));
                answer = answer + term;
            }
            
            return answer;
        }

        public long Task3(int n)
        {
            long answer = 0;
            long term = 1;
            
            for (int i = 1; i <= n; i++)
            {
                term = term * i;
                answer = answer + term;
            }
            
            return answer;
        }

        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int area = a * h;
            
            if (area <= L)
            {
                answer = 1;
            }
            else
            {
                answer = 0;
            }
            
            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;
            
            if (x >= 0)
            {
                answer = x * x;
            }
            else
            {
                answer = x * x * x;
            }
            
            return answer;
        }

        public int Task6(int h, int S, int L)
        {
            int answer = 0;
            int volume = h * S;
            
            if (volume <= L)
            {
                answer = 1;
            }
            else
            {
                answer = 0;
            }
            
            return answer;
        }

        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            if (I > S)
            {
                a = I - S;
                b = 1;
            }
            else if (I < S)
            {
                a = S - I;
                b = 2;
            }
            else
            {
                a = 0;
                b = 3;
            }
            
            if (a > E)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }

            return (a, b, c);
        }

        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            SS = a * b;
            
            double baseTriangle = b - a;
            SY = 0.5 * baseTriangle * h;

            return (SS, SY);
        }
    }
}
