using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace array_katsiukou
{
    class Program
    {
        static void Main()
        {


            string path1 = "Inlet.in";
            string path2 = "Outlet.out";
            


            int n = 5;       // размер матрицы
            int Min = 0;   // локальный минимум
            int i, j;         // счетчики циклов
            Random random = new Random();


        


                int[,] arr = new int[n, n];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", arr[i, j] = random.Next(0, 15));
                }
                Console.WriteLine();
            }


            // Кол-во локальных минимумов
            for (i = 1; i < n - 1; i++)
            {
                for (j = 1; j < n - 1; j++)
                {                                    
                    if ((arr[i, j] < arr[i, j - 1]) &&(arr[i, j] < arr[i - 1, j]) &&(arr[i, j] < arr[i, j + 1]) &&(arr[i, j] < arr[i + 1, j]))
                    {
                        Min++;             
                    }
                }
            }
            Console.WriteLine("\n\nКоличество локальных минимумов: " + Min);

            File.WriteAllText(path2, "Количество локальных минимумов = "+Min.ToString());

            Console.ReadKey();
        }
    }
}
