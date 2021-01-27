using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5_Engin
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
