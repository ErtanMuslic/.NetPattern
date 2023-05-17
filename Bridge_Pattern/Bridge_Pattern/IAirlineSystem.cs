using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    interface IAirlineSystem
    {
        void CheckAvailability(string date, string destination);
        List<string> GetAvailableOffers();
    }
}
