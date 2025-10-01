using Tyuiu.BarminaSK.Sprint1.Task6.V18.Lib;

namespace Tyuiu.BarminaSK.Sprint1.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Бармина С.К. | ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Бармина София Константиновна | ПИНб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что строка    *");
            Console.WriteLine("* является символьным представлением натурального числа.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите текст для проверки (например, 122 или -3): ");
            string inputValue = Console.ReadLine();

            var isNatural = ds.CheckNumber(inputValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Введенная строка: \"{inputValue}\"");

            if (isNatural)
            {
                Console.WriteLine("Строка является символьным представлением НАТУРАЛЬНОГО числа.");
            }
            else
            {
                Console.WriteLine("Строка НЕ является символьным представлением натурального числа.");
            }

            Console.WriteLine("**************************************************");

            Console.WriteLine("Нажмите любую клавишу для завершения программы...");
            Console.ReadKey();
        }
    }
}