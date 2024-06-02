// Завдання 5
// Розробіть додаток, який знаходитиме мінімальне і максимальне значення у двовимірному масиві. 

namespace task_5
{
    internal class Program
    {
        static void FillArray(int[,] array)
        {
            Random random = new Random();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-10, 10);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int GetMinValue(int[,] array)
        {
            int minValue = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minValue > array[i, j])
                    {
                        minValue = array[i, j];
                    }
                }
            }

            return minValue;
        }
        
        static int GetMaxValue(int[,] array)
        {
            int maxValue = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxValue < array[i, j])
                    {
                        maxValue = array[i, j];
                    }
                }
            }

            return maxValue;
        }
        
        static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            FillArray(array);
            
            Console.WriteLine($"Min value: {GetMinValue(array)}");
            Console.WriteLine($"Max value: {GetMaxValue(array)}");
        }
    }
}
