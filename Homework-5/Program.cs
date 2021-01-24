using Homework_5.Classes;
using Homework_5.Interfaces;
using Homework_5.Managers;
using Homework_5.Props;
using System;
using System.Collections.Generic;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { Id = 1, Name = "Witcher 3", ReleasedAt = "18 Mayıs 2015", Price = 180.5 };
            Game game2 = new Game() { Id = 2, Name = "Age of Mythology", ReleasedAt = "30 Ekim 2002", Price = 70 };
            Game game3 = new Game() { Id = 3, Name = "Dota 2", ReleasedAt = "9 Temmuz 2013", Price = 127.99 };
            Game game4 = new Game() { Id = 4, Name = "Archeage - Unchained", ReleasedAt = "15 Ekim 2019", Price = 255 };
            Game game5 = new Game() { Id = 5, Name = "Cyberpunk 2077", ReleasedAt = "10 Aralık 2020", Price = 300 };
            List<Game> games = new List<Game>() { game1, game2, game3, game4, game5 };

            Player player1 = new Player() { Id = 1, TCNumber = "12345678901", FirstName = "Murat", LastName = "Altınpınar", BirthYear = 1994 };
            Player player2 = new Player() { Id = 2, TCNumber = "10987654321", FirstName = "Efe", LastName = "Özcan", BirthYear = 1995 };
            Player player3 = new Player() { Id = 3, TCNumber = "12345609871", FirstName = "Anıl", LastName = "Koralay", BirthYear = 1996 };
            List<Player> players = new List<Player>() { player1, player2, player3 };

            ICampaignService campaignBlackFriday = new CampaignBlackFriday();
            ICampaignService campaignNewPlayer = new CampaignNewPlayer();
            ICampaignService campaignCampaignStudent = new CampaignStudent();

            GameManager gameManager = new GameManager();
            PlayerManager playerManager = new PlayerManager();
            CampaignManager campaignManager = new CampaignManager();

            Console.WriteLine("Lütfen bir seçim yapınız.");
            while (true)
            {
                Console.WriteLine("1. Oyuncu Menü\n2. Oyun Menü\n3. Oyun Satın Al\n4. Çıkış");
                string inputOption = Console.ReadLine();
                if (inputOption == "1")
                {
                    while(true)
                    {
                        Console.WriteLine("1. Oyuncu Ekle\n2. Oyuncu Güncelle\n3. Oyuncu Sil\n4. Oyuncu Listesi\n5. Ana Menü");
                        string inputOptionGamer = Console.ReadLine();
                        if (inputOptionGamer == "1")
                        {
                            playerManager.Add(players);
                        }
                        else if (inputOptionGamer == "2")
                        {
                            playerManager.Update();
                        }
                        else if (inputOptionGamer == "3")
                        {
                            Console.WriteLine("Silmek istediğiniz oyuncunun TC Numarasını girin: ");
                            playerManager.Delete(players, Console.ReadLine());
                        }
                        else if (inputOptionGamer == "4")
                        {
                            playerManager.List(players);
                        }
                        else if (inputOptionGamer == "5")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz işlem");
                        }
                    }
                }
                else if (inputOption == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("1. Oyun Ekle\n2. Oyun Güncelle\n3. Oyun Sil\n4. Oyun Listesi\n5. Ana Menü");
                        string inputOptionGame = Console.ReadLine();
                        if (inputOptionGame == "1")
                        {
                            gameManager.Add(games);
                        }
                        else if (inputOptionGame == "2")
                        {
                            gameManager.Update();
                        }
                        else if (inputOptionGame == "3")
                        {
                            Console.WriteLine("Silmek istediğiniz oyunun ID Numarasını girin: ");
                            gameManager.Delete(games, Convert.ToInt32(Console.ReadLine()));
                        }
                        else if (inputOptionGame == "4")
                        {
                            gameManager.List(games);
                        }
                        else if (inputOptionGame == "5")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz işlem");
                        }
                    }
                }
                else if (inputOption == "3")
                {
                    foreach (Game game in games)
                    {
                        Console.WriteLine("ID: {0}, Name: {1}, Fiyatı: {2}", game.Id, game.Name, game.Price);
                    }
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Satın almak istediğiniz oyunun ID numarasını girin: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    foreach (Game game in games)
                    {
                        if (game.Id == x)
                        {
                            while (true)
                            {
                                Console.WriteLine("Yararlanmak istediğiniz indirimi seçin:");
                                Console.WriteLine("1. Black Friday İndirimi(%25)\n2. Yeni Oyuncu İndirimi(%10)\n3. Öğrenci İndirimi(%20)\n4. Çıkış");
                                string inputCampaign = Console.ReadLine();
                                if (inputCampaign == "1")
                                {
                                    double result = campaignManager.MakeCampaign(game, campaignBlackFriday);
                                    Console.WriteLine("{0} isimli oyunu {1} TL fiyatı yerine {2} TL fiyatına satın aldınız.", game.Name, game.Price, result);
                                    break;
                                }
                                else if (inputCampaign == "2")
                                {
                                    double result = campaignManager.MakeCampaign(game, campaignNewPlayer);
                                    Console.WriteLine("{0} isimli oyunu {1} TL fiyatı yerine {2} TL fiyatına satın aldınız.", game.Name, game.Price, result);
                                    break;
                                }
                                else if (inputCampaign == "3")
                                {
                                    double result = campaignManager.MakeCampaign(game, campaignCampaignStudent);
                                    Console.WriteLine("{0} isimli oyunu {1} TL fiyatı yerine {2} TL fiyatına satın aldınız.", game.Name, game.Price, result);
                                    break;
                                }
                                else if (inputCampaign == "4")
                                {
                                    Console.WriteLine("---------------------------------");
                                    Console.WriteLine("Anasayfaya yönlendiriliyorsunuz..");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı karakter girdiniz.");
                                }
                            }
                        }
                    }
                }
                else if (inputOption == "4")
                {
                    Console.WriteLine("Çıkış işleminiz tamamlandı");
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir değer girin.");
                }
            }
        }
    }
}
