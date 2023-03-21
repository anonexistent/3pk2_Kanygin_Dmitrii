namespace pz_007
{
    internal class Program
    {
        public static void Succesfull()
        {
            Console.WriteLine("\n\nyes or no? (y/n)");
            while (Console.ReadKey().Key != ConsoleKey.Y) Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Store x5RetailGroup = new();

            #region FirstStoreProducts

            List<Product> a = new List<Product> {
                new Bread("white", 10.0f, "0x1f55"),
                new Bread("black", 11.0f, "0x111a"),
                new Beer("filter", 50.0f, 4.5f),
                new Beer("more", 100.0f, 7.2f),
                new Milk("domestic", 8.0f, 3.2f),
                new Milk("summer time", 9.0f, 3.2) };

            Console.WriteLine("we have products:");

            foreach (Product item in a) Console.WriteLine($"\t{item.Name} - {item.Price:f2}");

            Succesfull();

            #endregion

            #region RegularCustomers

            Client client1 = new() { Name = "stepa123"};
            Client client2 = new() { Name = "rose7", AllPurchases = 7200};

            Console.WriteLine($"we have clients:\n\t{client1.Name} ({client1.AllPurchases})" +
                                              $"\n\t{client2.Name} ({client2.AllPurchases})");

            Succesfull();

            #endregion

            #region Carts

            x5RetailGroup.SaveOrder(client1, a[0], a[0], a[3]);

            x5RetailGroup.SaveOrder(client2, a[2], a[2], a[5]);

            x5RetailGroup.SaveOrder(client1, a[1], a[4], a[4], a[4]);

            Console.WriteLine("\nthat day is very productive and we made this operations:\n");

            for (int i = 0; i < x5RetailGroup.AllPurchases.Count; i++) Console.WriteLine($"{x5RetailGroup.AllPurchases[i]}");

            Console.WriteLine($"\nso we have this position of clients now:\n\t{client1.Name} ({client1.AllPurchases:f2}) " +
                                                                      $"\n\t{client2.Name} ({client2.AllPurchases:f2})");

            #endregion

            //x5RetailGroup.SaveOrder(new Client(), b1,m1,bee1,bee2);
            
        }
    }
}