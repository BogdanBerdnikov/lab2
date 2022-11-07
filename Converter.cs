namespace lab1
{
    internal class Converter
    {
        public Converter(double usd, double eur, double pln)
        {
            Usd = usd;
            Eur = eur;
            Rub = pln;

            Console.WriteLine("Enter amount (in uah): ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter currency (usd/eur/pln): ");
            Currency = Console.ReadLine();

            ConvertToUah();
        }

        public double Usd { get; }
        public double Eur { get; }
        public double Pln { get; }

        public double Amount { get; }
        public string Currency { get; }

        public double ConvertToUah()
        {
            switch (Currency)
            {
                case "usd":
                    return Amount * Usd;
                case "eur":
                    return Amount * Eur;
                case "pln":
                    return Amount * Rub;
                default:
                    return 0;
            }
        }
    }
}
