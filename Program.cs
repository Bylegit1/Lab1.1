namespace Lab1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число: ");
            var number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Число является отрицательным");
            }
            else if (number < 100000 || number > 999999)
            {
                Console.WriteLine("Число не является шестизначным");
            }
            else
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
                    Console.WriteLine("Число является счастливым");
                }
                else
                {
                    Console.WriteLine("Число не является счастливым");
                }
            }
        }
    }
}
