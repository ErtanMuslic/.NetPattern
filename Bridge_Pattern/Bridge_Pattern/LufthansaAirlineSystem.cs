using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class LufthansaAirlineSystem : IAirlineSystem
    {
        public void CheckAvailability(string date, string destination)
        {
            Console.WriteLine($"Checking availability with Lufthansa Airlines for date: {date}, destination: {destination}.");
            // Actual implementation to check availability with Lufthansa Airlines
        }

        public List<string> GetAvailableOffers()
        {
            Console.WriteLine("Getting available offers from Lufthansa Airlines.");
            // Actual implementation to get available offers from Lufthansa Airlines
            return new List<string> { "LH123", "LH456" };
        }
    }
}
