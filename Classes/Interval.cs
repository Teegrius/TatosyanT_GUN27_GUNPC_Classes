using System;

namespace HomeWork
{
    public struct Interval
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        private Random random;

        public Interval(int minValue, int maxValue)
        {
            random = new Random();

            if (minValue > maxValue)
            {
                Console.WriteLine("Invalid input: min > max. Values have been swapped.");
                (minValue, maxValue) = (maxValue, minValue);
            }

            if (minValue < 0)
            {
                Console.WriteLine("Invalid input: min < 0. Set to 0.");
                minValue = 0;
            }

            if (maxValue < 0)
            {
                Console.WriteLine("Invalid input: max < 0. Set to 0.");
                maxValue = 0;
            }

            if (minValue == maxValue)
            {
                Console.WriteLine("Invalid input: min == max. max increased by 10.");
                maxValue += 10;
            }

            Min = minValue;
            Max = maxValue;
        }

        public float Get()
        {
            return (float)(random.NextDouble() * (Max - Min) + Min);
        }

        public override string ToString()
        {
            return $"[{Min}, {Max}]";
        }
    }
}
