namespace Lab1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шестизначное число: ");
            var number = int.Parse(Console.ReadLine());

            if(number < 100000 || number > 999999)
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
            }
        }
    }
}
