using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Bireysel Müşteri
    class Individual: Customer // inheritance
    {
        public string TCNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
