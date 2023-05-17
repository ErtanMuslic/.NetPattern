using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class SwissAirlineSystem : IAirlineSystem
    {
        public void CheckAvailability(string date, string destination)
        {
            Console.WriteLine($"Checking availability with Swiss Airlines for date: {date}, destination: {destination}.");
            // Actual implementation to check availability with Swiss Airlines
        }

        public List<string> GetAvailableOffers()
        {
            Console.WriteLine("Getting available offers from Swiss Airlines.");
            // Actual implementation to get available offers from Swiss Airlines
            return new List<string> { "SWISS123", "SWISS456" };
        }
    }
}
