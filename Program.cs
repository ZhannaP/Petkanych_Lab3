using System;

namespace l3
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Виберіть завдання:\n" +
                "1. Завдання 1\n" +
                "2. Завдання 2\n");
            int choice=0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Такого пункту меню не існує. Виберіть ще раз.");
                Main();
            }
            switch (choice)
            {
                case 1: Task1(); Console.ReadKey(); Main(); break;
                case 2: Task2(); break;
                default: Console.WriteLine("Такого пункту меню не існує. Виберіть ще раз.");
                    Main();
                    break;
            }
        }

        public static void Task1()
        {
            Console.WriteLine("Task 1:\n");
            Console.WriteLine("Cuckoo:");
            var cuckoo = new Cuckoo();
            Console.WriteLine(cuckoo.Fly());
            Console.WriteLine(cuckoo.Sing());
            Console.WriteLine(cuckoo.LayEggs());
            Console.WriteLine(cuckoo.Hatch());

            Console.WriteLine("\nChicken:");
            var chicken = new Chicken();
            Console.WriteLine(chicken.Fly());
            Console.WriteLine(chicken.Hatch());
            Console.WriteLine(chicken.Sing());
            Console.WriteLine(chicken.LayEggs());

            Console.WriteLine("\nHen:");
            var hen = new Hen();
            Console.WriteLine(hen.Fly());
            Console.WriteLine(hen.Hatch());
            Console.WriteLine(hen.Sing());
            Console.WriteLine(hen.LayEggs());

            Console.WriteLine("\nHen(ToString):");
            Console.WriteLine(hen.ToString());

            Console.WriteLine("Get Hash Code (hen):");
            Console.WriteLine(hen.GetHashCode());

            Console.WriteLine("Hen equals cuckoo:");
            Console.WriteLine(hen.Equals(cuckoo));
        }

        public static void Task2()
        {
            Console.Clear();
            WareHouse wareHouse = new WareHouse();
            Console.WriteLine("Виберіть пункт меню:\n");
            Console.WriteLine("1. Переглянути всі телефони на складі\n" +
                "2. Пошук телефона за ціновим діапазоном\n" +
                "3. Пошук телефона за виробником\n" +
                "4. Пошук телефона за моделлю\n" +
                "5. Пошук телефона за діагоналлю екрану\n");
            int choice=0;
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Такого пункту меню не існує. Виберіть ще раз.");
                Task2();
            }

            switch (choice)
            {
                case 1:
                    wareHouse.smartphones.ForEach(x => Console.WriteLine(x.Manufacturer + " " + x.Model + x.DisplaySizeInch +
                        "дюймів" + " " + x.Price + "грн"));
                    Console.ReadKey();
                    Task2();
                    break;
                case 2:
                    Console.WriteLine("Введіть мінімальну суму:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введіть максимальну суму:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    var smartphones = wareHouse.SearchByPrice(a, b);
                    smartphones.ForEach(x => Console.WriteLine(x.Manufacturer + " " + x.Model + x.DisplaySizeInch +
                       "дюймів" + " " + x.Price + "грн"));
                    Console.ReadKey();
                    Task2();
                    break;

                case 3:
                    Console.WriteLine("Введіть виробника:");
                    var manu = Console.ReadLine();
                    var phones = wareHouse.SearchByManufacturer(manu);
                    phones.ForEach(x => Console.WriteLine(x.Manufacturer + " " + x.Model + x.DisplaySizeInch +
                       "дюймів" + " " + x.Price + "грн"));
                    Console.ReadKey();
                    Task2();
                    break;

                case 4:
                    Console.WriteLine("Введіть модель:");
                    var model = Console.ReadLine();
                    var models = wareHouse.SearchByManufacturer(model);
                    models.ForEach(x => Console.WriteLine(x.Manufacturer + " " + x.Model + x.DisplaySizeInch +
                       "дюймів" + " " + x.Price + "грн"));
                    Console.ReadKey();
                    Task2();
                    break;
                    
                case 5:
                    Console.WriteLine("Введіть розмір діагоналі екрану:");
                    var size = Convert.ToDouble(Console.ReadLine());
                    var sizes = wareHouse.SearchByDisplaySize(size);
                    sizes.ForEach(x => Console.WriteLine(x.Manufacturer + " " + x.Model + x.DisplaySizeInch +
                       "дюймів" + " " + x.Price + "грн"));
                    Console.ReadKey();
                    Task2();
                    break;

                    
                default:
                    Console.WriteLine("Такого пункту меню не існує. Виберіть ще раз.");
                    Console.ReadKey();
                    Task2();
                    break;

            }
            
        }
    }
}
