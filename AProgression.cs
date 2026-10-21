using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05
{
    public class AProgression
    {
        public double First { get; set; }

        private double step;
        public double Step
        {
            get 
            { 
                return step; 
            }
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("Шаг прогрессии не может быть равен 0.");
                }    
                step = value; 
            }
        }

        public AProgression(double first, double step)
        {
            First = first;
            Step = step;
        }

        public double GetSum(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Параметр n должен быть положительынм.");
            }

            return (n * (2 * First + (n - 1) * Step)) / 2;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Арифметическая прогрессия: первый член = {First}, шаг = {Step}");
        }
    }
}
