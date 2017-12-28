using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svoistva_pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую границу массива: ");
            int firstBorder;
            while (!int.TryParse(Console.ReadLine(), out firstBorder))
            {
                Console.Clear();
                Console.Write("Введите первую границу массива: ");
            }

            Console.Write("Введите вторую границу массива: ");
            int secondBorder;
            while (!int.TryParse(Console.ReadLine(), out secondBorder))
            {
                Console.Clear();
                Console.Write("Введите вторую границу массива: ");
            }

            RangeOfArray array = new RangeOfArray(firstBorder, secondBorder);
            Random random = new Random();

            const int MIN_VALUE = 0;
            const int MAX_VALUE = 500;

            if (firstBorder < secondBorder)
            {
                for (int i = firstBorder; i < secondBorder; i++)
                {
                    array[i] = random.Next(MIN_VALUE, MAX_VALUE);
                    Console.Write("{0}\t", array[i]);
                }
            }

            else
            {
                for (int i = secondBorder; i < firstBorder; i++)
                {
                    array[i] = random.Next(MIN_VALUE, MAX_VALUE);
                    Console.Write("{0}\t", array[i]);
                }
            }

            Console.WriteLine();

            int index;
            while (true)
            {
                try
                {
                    Console.Write("Введите индекс элемента массива: ");
                    while (!int.TryParse(Console.ReadLine(), out index))
                    {
                        Console.Clear();

                        if (firstBorder < secondBorder)
                        {
                            for (int i = firstBorder; i < secondBorder; i++)
                            {
                                Console.Write("{0}\t", array[i]);
                            }
                        }
                        else
                        {
                            for (int i = secondBorder; i < firstBorder; i++)
                            {
                                Console.Write("{0}\t", array[i]);
                            }
                        }
                        Console.WriteLine();
                        Console.Write("Введите индекс элемента массива: ");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Элемент массива с индексом {0} равен {1}", index, array[index]);
                }
                catch (IndexOutOfRangeException exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.ReadLine();
        }
    }
}
