namespace hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1(); Console.WriteLine();
            Task2(); Console.WriteLine();
            Task3(); Console.WriteLine();
            Task4(); Console.WriteLine();
            Task5(); Console.WriteLine();
            Task6(); Console.WriteLine();
        }

        public static void Task1()
        {
            Console.WriteLine("Введіть число від 1 до 100: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 1 && num <= 100)
            {
                if (num % 3 == 0 && num % 5 == 0)
                    Console.WriteLine("Fizz Buzz");
                else if (num % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (num % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("Число вишло за діапазон 1-100");
            }
        }

        public static void Task2()
        {
            Console.Write("Введіть значення: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Введіть відсоток: ");
            double percent = double.Parse(Console.ReadLine());

            double result = value * (percent / 100);
            Console.WriteLine($"{percent}% від {value} дорівнює {result}");
        }

        public static void Task3()
        {
            Console.Write("Введіть перше число: ");
            int digit1 = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int digit2 = int.Parse(Console.ReadLine());

            Console.Write("Введіть третє число: ");
            int digit3 = int.Parse(Console.ReadLine());

            Console.Write("Введіть четверте число: ");
            int digit4 = int.Parse(Console.ReadLine());

            int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
            Console.WriteLine($"Сформоване число: {number}");
        }

        public static void Task4()
        {
            Console.Write("Введіть шестизначне число: ");
            string input = Console.ReadLine();

            if (input.Length != 6 || !int.TryParse(input, out _))
            {
                Console.WriteLine("Помилка: введіть коректне шестизначне число.");
                return;
            }

            Console.Write("Введіть перший номер розряду (1-6): ");
            int firstIndex = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Введіть другий номер розряду (1-6): ");
            int secondIndex = int.Parse(Console.ReadLine()) - 1;

            if (firstIndex < 0 || firstIndex > 5 || secondIndex < 0 || secondIndex > 5)
            {
                Console.WriteLine("Помилка: введіть правильні номери розрядів.");
                return;
            }

            char[] digits = input.ToCharArray();
            (digits[firstIndex], digits[secondIndex]) = (digits[secondIndex], digits[firstIndex]);

            string result = new string(digits);
            Console.WriteLine($"Результат після заміни: {result}");
        }

        public static void Task5()
        {
            Console.Write("Введіть дату (дд.мм.рррр): ");
            string[] date = Console.ReadLine().Split('.');

            int day = int.Parse(date[0]);
            int month = int.Parse(date[1]);
            int year = int.Parse(date[2]);

            string season = GetSeason(month);
            string dayOfWeek = new DateTime(year, month, day).DayOfWeek.ToString();

            Console.WriteLine($"{season}, {dayOfWeek}");
        }

        static string GetSeason(int month)
        {
            if (month == 12 || month == 1 || month == 2) return "Winter";
            if (month >= 3 && month <= 5) return "Spring";
            if (month >= 6 && month <= 8) return "Summer";
            return "Autumn";
        }

        public static void Task6()
        {
            Console.Write("Введіть температуру: ");
            double temperature = double.Parse(Console.ReadLine());

            Console.Write("Конвертувати в (C) Цельсій або (F) Фаренгейт: ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "C")
            {
                double celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine($"Температура в Цельсіях: {celsius}");
            }
            else if (choice == "F")
            {
                double fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit}");
            }
            else
            {
                Console.WriteLine("Невірний вибір");
            }
        }

        public static void Task7()
        {
            Console.Write("Введіть перше число: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            int end = int.Parse(Console.ReadLine());

            if (start > end)
            {
                (start, end) = (end, start);
            }

            Console.WriteLine("Парні числа в діапазоні:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
