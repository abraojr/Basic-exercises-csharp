using System.Globalization;

namespace Exercise_037_Product_tags.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }
        public double TotalPrice()
        {
            return Price += CustomFee;
        }
        public override string PriceTag()
        {
            return Name + " U$ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Custom fee: U$ " + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + " )";
        }
    }
}
