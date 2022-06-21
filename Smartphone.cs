using System;
using System.Collections.Generic;
using System.Text;

namespace l3
{
    class Smartphone
    {
        public string Manufacturer { get; set; }

        public string Model { get; set; }
        
        public double DisplaySizeInch { get; set; }

        public int Price { get; set; }

        public Smartphone(string manufacturer, string model, double displaySizeInch, int price)
        {
            Manufacturer = manufacturer;
            Model = model;
            DisplaySizeInch = displaySizeInch;
            Price = price;
        }
    }
}
