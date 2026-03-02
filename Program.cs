namespace Lab1._1
{
    public class LuckyNumberLogic
    {
        public static bool IsNegative(int number)
        {
            return number < 0;
        }

        public static bool IsSixDigit(int number)
        {
            return number >= 100000 && number <= 999999;
        }

        public static string CheckLuckyNumber(int number)
        {
            var digit1 = number / 100000;
            var digit2 = (number / 10000) % 10;
            var digit3 = (number / 1000) % 10;
            var digit4 = (number / 100) % 10;
            var digit5 = (number / 10) % 10;
            var digit6 = number % 10;

            var firstSum = digit1 + digit2 + digit3;
            var secondSum = digit4 + digit5 + digit6;

            if (firstSum == secondSum)
            {
                return "Число является счастливым";
            }
            else
            {
                return "Число не является счастливым";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число: ");
            var number = int.Parse(Console.ReadLine());

            var result = "";
            if (LuckyNumberLogic.IsNegative(number))
            {
                result = "Число является отрицательным";
            }
            else if (!LuckyNumberLogic.IsSixDigit(number))
            {
                result = "Число не является шестизначным";
            }
            else
            {
               result = LuckyNumberLogic.CheckLuckyNumber(number);
            }

            Console.WriteLine(result);
        }
    }
}
