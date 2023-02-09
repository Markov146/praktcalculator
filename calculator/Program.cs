namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FirstPerem, SecondPerem, operation;

            while (true)
            {
                if (true)
                {
                    Console.WriteLine("Введите операцию от 1 до 9: ");
                    operation = int.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case 0:
                            {
                                if (operation == 0)
                                {
                                    Console.WriteLine("Неизвестная команда");
                                }
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("Введите первое число: ");
                                FirstPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine("Введите второе число: ");
                                SecondPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine(FirstPerem + SecondPerem);
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Введите первое число: ");
                                FirstPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine("Введите второе число: ");
                                SecondPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine(FirstPerem - SecondPerem);
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Введите первое число: ");
                                FirstPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine("Введите второе число: ");
                                SecondPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine(FirstPerem * SecondPerem);
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Введите первое число: ");
                                FirstPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine("Введите второе число: ");
                                SecondPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine(FirstPerem / SecondPerem);
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Введите число: ");
                                FirstPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine("Введите степень: ");
                                SecondPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine(Math.Pow(FirstPerem, SecondPerem));
                            }
                            break;
                        case 6:
                            {
                                Console.WriteLine("Введите число: ");
                                FirstPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine(Math.Sqrt(FirstPerem));
                            }
                            break;
                        case 7:
                            {
                                Console.WriteLine("Введите первое число: ");
                                FirstPerem = float.Parse(Console.ReadLine());
                                Console.WriteLine(FirstPerem * 0.01);
                            }
                            break;

                        case 8:
                            {
                                int fact = 1;
                                float n;
                                FirstPerem = float.Parse(Console.ReadLine());
                                n = (float)FirstPerem;
                                for (int i = 1; i <= n; i++)
                                    fact *= i;
                                if (fact == 1 && fact == 0)
                                    fact = 0;
                                Console.WriteLine(fact);


                            }
                            break;
                        case 9:
                            {
                                Console.WriteLine("Спасибо, что воспользовались данной программой!");
                            }
                            break;
                        case 10:
                            {
                                if (operation == 10)

                                {
                                    Console.WriteLine("Неизвестная команда");
                                }

                                break;
                            }






                    }
                }
            }
        }
    }
    
}