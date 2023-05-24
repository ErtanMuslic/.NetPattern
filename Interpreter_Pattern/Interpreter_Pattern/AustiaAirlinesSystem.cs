using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class AustiaAirlinesSystem : IAirlineSystem
    {
        public List<string> GetAvailableOffers(string date, string destination)
        {
            return new List<string> { "AU123", "AU456" };
        }
    }

}
