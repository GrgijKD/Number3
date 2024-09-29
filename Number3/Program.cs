using System.Text;

namespace CurrencyConverter
{
    class Converter
    {
        private decimal usdToUah;
        private decimal eurToUah;

        public Converter(decimal usdRate, decimal eurRate)
        {
            usdToUah = usdRate;
            eurToUah = eurRate;
        }

        public decimal ConvertUahToUsd(decimal amountInUah)
        {
            return amountInUah / usdToUah;
        }

        public decimal ConvertUahToEur(decimal amountInUah)
        {
            return amountInUah / eurToUah;
        }

        public decimal ConvertUsdToUah(decimal amountInUsd)
        {
            return amountInUsd * usdToUah;
        }

        public decimal ConvertEurToUah(decimal amountInEur)
        {
            return amountInEur * eurToUah;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть курс долара до гривні:");
            decimal usdRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введіть курс євро до гривні:");
            decimal eurRate = Convert.ToDecimal(Console.ReadLine());

            Converter converter = new Converter(usdRate, eurRate);

            bool continueConversion = true;
            while (continueConversion)
            {
                Console.WriteLine("\nОберіть напрямок конвертації:");
                Console.WriteLine("1. Долари в гривні");
                Console.WriteLine("2. Євро в гривні");
                Console.WriteLine("3. Гривні в долари");
                Console.WriteLine("4. Гривні в євро");
                Console.WriteLine("5. Вихід");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введіть суму в доларах:");
                        decimal amountInUsd = Convert.ToDecimal(Console.ReadLine());
                        decimal resultInUahFromUsd = converter.ConvertUsdToUah(amountInUsd);
                        Console.WriteLine($"{amountInUsd} USD = {resultInUahFromUsd} грн");
                        break;

                    case 2:
                        Console.WriteLine("Введіть суму в євро:");
                        decimal amountInEur = Convert.ToDecimal(Console.ReadLine());
                        decimal resultInUahFromEur = converter.ConvertEurToUah(amountInEur);
                        Console.WriteLine($"{amountInEur} EUR = {resultInUahFromEur} грн");
                        break;
                    case 3:
                        Console.WriteLine("Введіть суму в гривнях:");
                        decimal amountInUahToUsd = Convert.ToDecimal(Console.ReadLine());
                        decimal resultInUsd = converter.ConvertUahToUsd(amountInUahToUsd);
                        Console.WriteLine($"{amountInUahToUsd} грн = {resultInUsd} USD");
                        break;
                    case 4:
                        Console.WriteLine("Введіть суму в гривнях:");
                        decimal amountInUahToEur = Convert.ToDecimal(Console.ReadLine());
                        decimal resultInEur = converter.ConvertUahToEur(amountInUahToEur);
                        Console.WriteLine($"{amountInUahToEur} грн = {resultInEur} EUR");
                        break;
                    case 5:
                        continueConversion = false;
                        break;
                    default:
                        Console.WriteLine("Невірний вибір");
                        break;
                }
            }
        }
    }
}

