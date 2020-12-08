﻿using System.Globalization;

namespace Exercise_037_Product_tags.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag()
        {
            return Name + " U$  " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
