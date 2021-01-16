using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class ProductManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + product.Adi);
        }

        public void Add2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urunAdi);
        }
    }
}
