using Homework_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Classes
{
    class CampaignBlackFriday : ICampaignService
    {
        public double Discount(double Price)
        {
            double discount = (Price / 100) * 25;
            double total = Price - discount;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Black Friday indirimi yapıldı. İndirim Tutarı: -{0} TL", discount);
            Console.WriteLine("Black Friday indiriminiz başarıyla uygulandı.");
            return total;
        }
    }
}
