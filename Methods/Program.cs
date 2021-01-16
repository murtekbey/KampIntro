using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Kapruz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1, product2 };

            // type-safe -- tip güvenliği
            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("------Methods-----");
            //instance - örnek
            //encapsulation
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

            productManager.Add2("Armut", "Yeşil Armut", 12, 10);
            productManager.Add2("Elma", "Yeşil Elma", 9, 9);
            productManager.Add2("Karpuz", "Diyarbakır karpuzu", 19, 8);
        }
    }
}
