using System;
using System.Collections.Generic;
using System.Text;

namespace l3
{
    class WareHouse
    {
        public List<Smartphone> smartphones = new List<Smartphone>();

        public WareHouse()
        {
            smartphones.Add(new Smartphone("xiaomi", "mi 10 pro", 6.67, 23700));
            smartphones.Add(new Smartphone("xiaomi", "redmi note 11", 6.43, 9500));
            smartphones.Add(new Smartphone("xiaomi", "redmi 9c", 6.53, 5300));
            smartphones.Add(new Smartphone("xiaomi", "redmi 9A", 6.53, 4400));
            smartphones.Add(new Smartphone("xiaomi", "redmi 8", 6.22, 4995));

            smartphones.Add(new Smartphone("samsung", "galaxy s21 ultra", 6.8, 4800));

            smartphones.Add(new Smartphone("samsung", "galaxy note 20 ultra", 6.3, 4800));

            smartphones.Add(new Smartphone("samsung", "galaxy m12", 6.5, 7000));

            smartphones.Add(new Smartphone("samsung", "galaxy a32", 6.4, 9800));

            smartphones.Add(new Smartphone("samsung", "galaxy a035", 6.5, 5600));


            smartphones.Add(new Smartphone("iphone", "11", 6.1, 61000));


            smartphones.Add(new Smartphone("iphone", "13 pro", 6.1, 23000));


            smartphones.Add(new Smartphone("iphone", "xs", 5.8, 20000));


            smartphones.Add(new Smartphone("iphone", "7", 4.7, 11000));


            smartphones.Add(new Smartphone("iphone", "12", 6.1, 15000));

        }

        public List<Smartphone> SearchByPrice(int minPrice, int maxPrice)
        {
            var result = new List<Smartphone>();
            foreach (var x in smartphones)
            {
                if (x.Price > minPrice && x.Price < maxPrice) result.Add(x);
            }

            return result;
        }

        public List<Smartphone> SearchByManufacturer(string manufacturer)
        {
            manufacturer.ToLower();
            var result = new List<Smartphone>();

            foreach (var x in smartphones)
            {
                if (x.Manufacturer == manufacturer) result.Add(x);
            }
            return result;
        }

        public List<Smartphone> SearchByModel(string model)
        {
            model.ToLower();
            var result = new List<Smartphone>();

            foreach (var x in smartphones)
            {
                if (x.Manufacturer == model) result.Add(x);
            }
            return result;
        }

        public List<Smartphone> SearchByDisplaySize(double size)
        { 
            var result = new List<Smartphone>();

            foreach (var x in smartphones)
            {
                if (x.DisplaySizeInch == size||x.DisplaySizeInch-size<0.2|| x.DisplaySizeInch - size > -0.2) 
                    result.Add(x);
            }
            return result;
        }



    }
}
