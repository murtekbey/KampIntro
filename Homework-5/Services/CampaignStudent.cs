using Homework_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Classes
{
    class CampaignStudent : ICampaignService
    {
        public double Discount(double Price)
        {
            double discount = (Price / 100) * 20;
            double total = Price - discount;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Öğrenci indirimi yapıldı. İndirim Tutarı: -{0} TL", discount);
            Console.WriteLine("Öğrenci indiriminiz başarıyla uygulandı.");
            return total;
        }
    }
}
