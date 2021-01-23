using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Kurumsal Müşteri
    class Coorporate:Customer // inheritance
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
