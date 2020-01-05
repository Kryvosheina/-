using System;

namespace QA_test_Kryvosheina
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            try
            {
                do
                {
                    Console.Write("Меню:\n1) Решение задачи 1\n2) Решение задачи 2\n3) Решение задачи 3\n4) Выйти из программы\n\nВаш выбор: ");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Algoritm1(); 
                            break;
                        case 2:
                            Algoritm2();
                            break;
                        case 3:
                            Algoritm3();
                            break;
                        case 4:
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Вы что-то другое нажали...");
                            break;
                    }
                    Console.Write("\n\n\t\t\tНажмите любую клавишу...");
                    Console.ReadLine();
                    Console.Clear();
                }
                while (i != 4);
            }
            catch (Exception)
            {
                Console.WriteLine("Упс, ошибка! Нажмите цифру! ");
            }
        }

        static void Algoritm1()
        {
            Console.WriteLine("Введите число: ");
            int correct_num;
            string number = Console.ReadLine();

            if (Int32.TryParse(number, out correct_num))
            {
                if (correct_num > 7)
                {
                    Console.WriteLine("Привет!");
                    Console.ReadKey();
                }
                else if (correct_num <= 7)
                {
                    Console.WriteLine("Введенная цифра равна 7 или меньше ");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не цифру!");
                Console.ReadKey();
            }
        }
       
        static void Algoritm2()
        {
            string verif_name = "Вячеслав";
            Console.WriteLine("Введите имя :");
            string input_name = Console.ReadLine();
            if (input_name == verif_name)
            {
                Console.WriteLine("Привет, Вячеслав!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Нет такого имени");
                Console.ReadKey();
            }
        }

        static void Algoritm3()
        {
            int n;
            int[] arr;
            int currint;

            do
            {
                Console.Clear();
                Console.Write("Введите длину массива: ");

            } while (!int.TryParse(Console.ReadLine(), out currint));

            n = currint;
            arr = new int[n];

            for (int i = 0; i < n; i++)
            {

                Console.Write("Введите элемент {0}: ", i + 1);

                if (int.TryParse(Console.ReadLine(), out currint))
                {
                    arr[i] = currint;
                }
                else --i;
            }

            Console.Write("Массив: " + string.Join(" ", arr));

            int mult_numb;

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Введите кратное число: ");

            } while (!int.TryParse(Console.ReadLine(), out mult_numb));

            for (int i = 0; i < n; i++)
            {
                if ((arr[i] % mult_numb) == 0)
                {
                    Console.WriteLine($"Элемент массива, кратный  {mult_numb}  : "
                                      + string.Join(" ", arr[i]));

                }
            }
            Console.ReadKey();
        }
    }

}
    


    

