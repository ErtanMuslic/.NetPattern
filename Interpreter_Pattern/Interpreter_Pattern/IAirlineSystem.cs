using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    interface IAirlineSystem
    {
        List<string> GetAvailableOffers(string date, string destination);
    }

}
