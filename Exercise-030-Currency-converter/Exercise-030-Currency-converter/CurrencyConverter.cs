namespace Exercise_030_Currency_converter
{
    class CurrencyConverter
    {
        public static double Iof = 6.0;
        public static double Convert(double quotation, double dollar)
        {
            double Total = quotation * dollar;
            return Total += Total * (Iof / 100.0);
        }
    }
}
