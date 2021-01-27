using Homework_5.Interfaces;
using Homework_5.Props;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5
{
    class VerificationEDevlet : IVerificationService
    {
        public void CheckInformation(Player player)
        {
            if (player.FirstName.Length >= 3 && player.LastName.Length >= 3 && player.TCNumber.Length == 11 && player.BirthYear > 1859)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " E-Devlet Kimlik doğrulamasından geçti.");
            }
            else
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " E-Devlet Kimlik doğrulamasından geçemedi.");

            }
        }
    }
}
