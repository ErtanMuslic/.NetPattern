using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class SwissAirlineSystem : IAirlineSystem
    {
        public List<string> GetAvailableOffers(string date, string destination)
        {
            // Actual implementation to get available offers from Swiss Airlines
            return new List<string> { "SWISS123", "SWISS456" };
        }
    }

}
