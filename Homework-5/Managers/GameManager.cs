using Homework_5.Interfaces;
using Homework_5.Props;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Managers
{
    class GameManager
    {
        public void Add(List<Game> games)
        {
            Game game = new Game();
            Console.WriteLine("ID Numarası: ");
            int id = Convert.ToInt32(Console.ReadLine());
            game.Id = id;
            Console.WriteLine("Oyunun Adı: ");
            string name = Console.ReadLine();
            game.Name = name;
            Console.WriteLine("Satış Tarihi: ");
            string releasedAt = Console.ReadLine();
            game.ReleasedAt = releasedAt;
            Console.WriteLine("Fiyat: ");
            double price = Convert.ToDouble(Console.ReadLine());
            game.Price = price;

            games.Add(game);
            Console.WriteLine("Oyun sisteme başarılı bir şekilde kayıt edildi.");
        }

        public void Update()
        {
            Console.WriteLine("Güncelleme işleminiz teknik bir aksaklıkdan dolayı gerçekleştirilemiyor.");
        }

        public void Delete(List<Game> games, int id)
        {
            foreach (Game game in games)
            {
                if (game.Id == id)
                {
                    games.Remove(game);
                    Console.WriteLine(game.Name + " isimli oyun silindi.");
                    break;
                }
            }
        }

        public void List(List<Game> games)
        {
            foreach (Game game in games)
            {
                Console.WriteLine("ID: {0}, Oyun Adı: {1}, Çıkış Tarihi: {2}, Fiyatı: {3}", game.Id, game.Name, game.ReleasedAt, game.Price);
                Console.WriteLine("------------------------------------");
            }
        }

        public void Sell(IVerificationService verification, ICampaignService campaign)
        {
            
        }
    }
}
