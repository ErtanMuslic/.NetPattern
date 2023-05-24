using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class EurowingsAirlineSystem : IAirlineSystem
    {
        public List<string> GetAvailableOffers(string date, string destination)
        {
            return new List<string> { "EW123", "EW456" };
        }
    }

}
