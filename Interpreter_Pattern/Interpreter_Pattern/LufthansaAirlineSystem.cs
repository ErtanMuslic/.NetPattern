using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class LufthansaAirlineSystem : IAirlineSystem
    {
        public List<string> GetAvailableOffers(string date, string destination)
        {
            return new List<string> { "LH123", "LH456" };
        }
    }

}
