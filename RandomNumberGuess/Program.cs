﻿using System.Text;

class RandomNumberGenerator
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число между: 1 и 100.");


        //Создание объекта для генерации чисел
        Random rnd = new Random();

        //Получить случайное число (в диапазоне от 0 до 10)
        int value = rnd.Next(0, 101);
        int popitka = 0;
       


        Console.WriteLine("У вас 10 попыток.Попробуйте угадать.");

        while (popitka < 10)
        {
            
            
            string choose = Console.ReadLine();
            long number;
            bool result = long.TryParse(choose, out number);
            if (result)
            {
                if (number <= 100 && number >= 1)
                {
                    
                    popitka++;
                    if (popitka == 10)
                    {
                        Console.WriteLine("Вы использовали 10 попыток");
                        Console.WriteLine("Загаданное число = " + value);
                    }
                    else if (number > value)
                    {
                        Console.WriteLine("Ваше число больше загаданного. Оставшееся число попыток = " + popitka);
                    }

                    else if (number < value)
                    {
                        Console.WriteLine("Ваше число меньше загаданного Оставшееся число попыток = " + popitka);
                    }


                    else if (number == value)
                    {
                        Console.WriteLine("Вы угадали. Число использованых попыток =  " + popitka);
                        break;
                    }

                      
                }

                else
                {
                    Console.WriteLine("Введите число от 1 до 100");
                }
            }

            else 
            {
                Console.WriteLine("Неверный ввод");
            }
          

        }
    


        // Создаем объект для генерации чисел

        // Создаем переменную для хранения случайного числа

        // Создаем переменную для хранения числа попыток

        // 1. Создаем цикл, который будет выполняться до тех пор, пока не будет угадано число


        // 2. В теле цикла:
        // 2.1. Увеличиваем счетчик попыток на 1

        // 2.2. Считываем число с клавиатуры и сохраняем в переменную

        // 2.3. Сравниваем загаданное число с введенным пользователем

        // 2.4. Если числа равны, то выводим сообщение о победе и о количестве попыток

        // 2.5. Если число пользователя больше загаданного, то выводим сообщение, что число больше загаданного

        // 2.6. Если число пользователя меньше загаданного, то выводим сообщение, что число меньше загаданного

        // 2.7. Если число попыток равно 10, то выводим сообщение о проигрыше и загаданное число


        // Так же помним что надо проверять ввод пользователя на корректность
        // Если пользователь ввел не число, то выводим сообщение об ошибке и просим ввести число еще раз
        // Число джолжно быть в диапазоне от 1 до 100 и целое

    }
}
