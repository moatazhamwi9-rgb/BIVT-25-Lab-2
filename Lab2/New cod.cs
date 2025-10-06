using System;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        
        // Task 1: s = sin(x) + sin(2x)/x + sin(3x)/x² + ... + sin(nx)/x^(n-1)
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / Math.Pow(x, i - 1);
            }
            // end

            return answer;
        }

        // Task 2: s = -s/1! + s²/2! - s³/3! + ... + (-1)^n * s^n/n!
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 1.0;
            for (int i = 1; i <= n; i++)
            {
                double term = Math.Pow(s, i) / Factorial(i);
                if (i % 2 == 1)
                    answer -= term;
                else
                    answer += term;
            }
            // end

            return answer;
        }

        // Task 3: مجموع أول n عدد فيبوناتشي
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n <= 0) return 0;
            
            long a = 0, b = 1;
            answer = a;
            
            if (n >= 2) answer += b;
            
            for (int i = 2; i < n; i++)
            {
                long next = a + b;
                answer += next;
                a = b;
                b = next;
            }
            // end

            return answer;
        }

        // Task 4: أقصى عدد حدود في التقدم الحسابي حيث المجموع ≤ L
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int sum = 0;
            int n = 0;
            
            while (sum <= L)
            {
                int term = a + n * h;
                if (sum + term > L)
                    break;
                    
                sum += term;
                n++;
            }
            answer = n;
            // end

            return answer;
        }

        // Task 5: متسلسلة أركتان x
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            int n = 0;
            double term;
            
            do
            {
                term = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (2 * n + 1);
                answer += term;
                n++;
            } while (Math.Abs(term) >= E);
            // end

            return answer;
        }

        // Task 6: وقت تكاثر الأميبا
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int current = S;
            
            while (current < L)
            {
                answer += h;
                current *= 2;
            }
            // end

            return answer;
        }

        // Task 7: إحصائيات تدريب الرياضي
        public (double a, int b, int c) Task7(double S, double L)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            // أ: مجموع 7 أيام
            double daily = S;
            for (int day = 0; day < 7; day++)
            {
                a += daily;
                daily *= 1.01;
            }
            
            // ب: الأيام للوصول إلى 100 كم مجموع
            daily = S;
            double total = 0;
            b = 0;
            while (total < 100)
            {
                total += daily;
                daily *= 1.01;
                b++;
            }
            
            // ج: الأيام للجري أكثر من 42 كم في اليوم
            daily = S;
            c = 0;
            while (daily <= 42)
            {
                daily *= 1.01;
                c++;
            }
            // end

            return (a, b, c);
        }

        // Task 8: مجموع المتسلسلة والدالة في المدى [a, b]
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b; x += h)
            {
                // مجموع المتسلسلة
                double seriesSum = 0;
                int i = 0;
                double term;
                
                do
                {
                    term = (2 * i + 1) * Math.Pow(x, 2 * i) / Factorial(i);
                    seriesSum += term;
                    i++;
                } while (Math.Abs(term) >= E);
                
                SS += seriesSum;
                
                // قيمة الدالة
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
            }
            // end

            return (SS, SY);
        }

        // دالة مساعدة لحساب المضروب
        private double Factorial(int n)
        {
            if (n <= 1) return 1.0;
            
            double result = 1.0;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
