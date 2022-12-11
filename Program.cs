
internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
        // каждой строки двумерного массива.
        void Task54()
        {
            Console.WriteLine("Программа задаёт двумерный массив и упорядочивает по убыванию элементы каждой строки.");
            int rows = 4;
            int col = 5;
            int[,] numbers = new int[rows, col];
            FillArray(numbers, -10, 10);
            PrintArray(numbers);
            SortArrayToLower(numbers);
            PrintArray(numbers);
        }
    
        
        // Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
        // с наименьшей суммой элементов.
        void Task56()
        {
            Console.WriteLine("Программа задаёт прямоугольный двумерный массив и находит строку с наименьшей суммой элементов.");
            int rows = 4;
            int col = 6;
            int[,] numbers = new int[rows, col];
            FillArray(numbers);
            PrintArray(numbers);
            int indexMin = 0;
            int sumMin = FindSumInRow(numbers, 0);
            Console.WriteLine($"Сумма элементов {1}-ой строки равна {sumMin}.");
            
            for (int i = 1; i < rows; i++)
            {
                int sum = FindSumInRow(numbers, i);
                Console.WriteLine($"Сумма элементов {i + 1}-ой строки равна {sum}.");
                if (sum < sumMin)
                {
                    sumMin = sum;
                    indexMin = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов {indexMin + 1}-ой строки равна {sumMin} и является наименьшей в массиве."); 

            int FindSumInRow(int[,] numbers, int row)
            {
                int sum = 0;
                int columns = numbers.GetLength(1);
                
                for (int i = 0; i < columns; i++)
                {
                    sum += numbers[row, i];
                }
                return sum;
            }    
        }
        
        Task54(); 
        Task56(); 
    }
     static void FillArray(int[,] matrix, int minValue = 0, int maxValue = 10)
    {
        maxValue++;
        Random rand = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rand.Next(minValue, maxValue);
            }
        }
    }
    static void SortArrayToLower(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - j - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }
    static void PrintArray(int[,] matrix, string message = "Вывод массива:")
    {
        Console.WriteLine(message);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}