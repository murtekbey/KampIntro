using Homework_5.Interfaces;
using Homework_5.Props;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.Managers
{
    class PlayerManager:Player
    {
        IVerificationService eDevletVerificate = new VerificationEDevlet();
        public void Add(List<Player> players)
        {
            Player player = new Player();
            Console.WriteLine("ID Numarası: ");
            int id = Convert.ToInt32(Console.ReadLine());
            player.Id = id;
            Console.WriteLine("TC Numarası: ");
            string tc = Console.ReadLine();
            player.TCNumber = tc;
            Console.WriteLine("Adı: ");
            string firstName = Console.ReadLine();
            player.FirstName = firstName;
            Console.WriteLine("Soyadı: ");
            string lastName = Console.ReadLine();
            player.LastName = lastName;
            Console.WriteLine("Doğum Yılı: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            player.BirthYear = birthYear;

            players.Add(player);
            eDevletVerificate.CheckInformation(player);
            Console.WriteLine("Oyuncu sisteme başarılı bir şekilde kayıt edildi.");
        }

        public void Update()
        {
            Console.WriteLine("Güncelleme işleminiz teknik bir aksaklıkdan dolayı gerçekleştirilemiyor.");
        }

        public void Delete(List<Player> players, string tc)
        {
            foreach (Player player in players)
            {
                if (player.TCNumber == tc)
                {
                    players.Remove(player);
                    Console.WriteLine(player.FirstName + " isimli oyuncu silindi.");
                    break;
                }
                else
                {
                    Console.WriteLine("Eşleşme yok {0} - {1}", tc, player.TCNumber);
                }
            }
            
        }

        public void List (List<Player> players)
        {
            foreach(Player player in players)
            {
                Console.WriteLine("ID: {0}, TC: {1}, Ad: {2} {3}, Doğum Yılı:{4}", player.Id, player.TCNumber, player.FirstName, player.LastName, player.BirthYear);
                eDevletVerificate.CheckInformation(player);
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
