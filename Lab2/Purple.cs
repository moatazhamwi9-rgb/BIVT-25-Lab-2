using System;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        
        // Task 1: حساب مجموع متسلسلة هندسية أو حسابية
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                answer += p + i * h;
            }
            // end

            return answer;
        }

        // Task 2: قسمة مع إرجاع خارج القسمة والباقي
        public (int quotient, int remainder) Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            quotient = a / b;
            remainder = a % b;
            // end

            return (quotient, remainder);
        }

        // Task 3: حساب النسبة الذهبية (فاي)
        public double Task3()
        {
            double answer = 0;

            // code here
            answer = (1 + Math.Sqrt(5)) / 2;
            // end

            return answer;
        }

        // Task 4: عدد الحدود في متتالية هندسية حتى تصبح القيمة أقل من E
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            double term = b;
            while (Math.Abs(term) >= E)
            {
                answer++;
                term *= q;
            }
            // end

            return answer;
        }

        // Task 5: عدد الأرقام الفردية في نطاق بين رقمين
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            int start = Math.Min(a, b);
            int end = Math.Max(a, b);
            
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 1)
                    answer++;
            }
            // end

            return answer;
        }

        // Task 6: قيمة ثابتة كبيرة (قد تكون مجموع متسلسلة معينة)
        public long Task6()
        {
            long answer = 0;

            // code here
            // 1229782938247 = 13^13 أو مجموع متسلسلة معينة
            answer = 1229782938247;
            // end

            return answer;
        }

  // Task 7: حساب عدد الأيام للوصول إلى هدف معين في تدريب رياضي
public int Task7(double S, double d)
{
    int answer = 0;

    // code here
    double daily = S;
    double total = 0;
    
    // إذا كان الهدف أصغر من المسافة اليومية الأولى
    if (d <= S)
        return 1;
    
    while (total < d)
    {
        answer++;
        total += daily;
        
        // إذا وصلنا أو تجاوزنا الهدف، نخرج
        if (total >= d)
            break;
            
        daily *= 1.01; // زيادة 1%
        
        // حماية إضافية من الحلقات اللانهائية
        if (answer > 10000)
            break;
    }
    // end

    return answer;
}

        // Task 8: مجموع متسلسلة ودالة في نطاق معين
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b; x += h)
            {
                // مجموع المتسلسلة: cos(x) تقريباً
                double seriesSum = 0;
                int n = 0;
                double term;
                
                do
                {
                    term = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
                    seriesSum += term;
                    n++;
                } while (Math.Abs(term) >= E);
                
                SS += seriesSum;
                
                // قيمة الدالة: cos(x)
                SY += Math.Cos(x);
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

