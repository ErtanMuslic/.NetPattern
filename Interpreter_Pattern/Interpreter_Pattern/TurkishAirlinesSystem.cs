using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class TurkishAirlinesSystem : IAirlineSystem
    {
        public List<string> GetAvailableOffers(string date, string destination)
        {
            return new List<string> { "TK123", "TK456" };
        }
    }

}
