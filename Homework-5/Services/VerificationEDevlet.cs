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
            Console.WriteLine("{0} TC Numarasına sahip kişinin E-Devlet Kimlik Doğrulaması başarılı", player.TCNumber);
        }
    }
}
