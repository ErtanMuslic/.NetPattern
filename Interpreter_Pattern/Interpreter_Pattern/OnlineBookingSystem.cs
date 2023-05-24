using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_Pattern
{
    class OnlineBookingSystem : IBookingSystem
    {
        private IAirlineSystem airlineSystem;

        public OnlineBookingSystem(IAirlineSystem airlineSystem)
        {
            this.airlineSystem = airlineSystem;
        }

        public void LogIn(string username, string password)
        {
            Console.WriteLine($"Logged in to the online booking system with username: {username} and password: {password}.");
        }

        public void Register(string username, string password)
        {
            Console.WriteLine($"Registered to the online booking system with username: {username} and password: {password}.");
        }

        public void SearchFlights(string date, string destination, bool returnTicket)
        {
            Console.WriteLine($"Searching for flights on {date} to {destination}. Return Ticket: {returnTicket}.");
            List<string> availableOffers = airlineSystem.GetAvailableOffers(date, destination);
        }

        public void SelectOffer(string offerId)
        {
            Console.WriteLine($"Selected offer: {offerId}.");
        }

        public void AddPassenger(string name, string surname, string passportNumber, string dateOfBirth)
        {
            Console.WriteLine($"Added passenger: {name} {surname}, Passport Number: {passportNumber}, Date of Birth: {dateOfBirth}.");
        }

        public void ConfirmReservation()
        {
            Console.WriteLine("Confirmed the reservation.");
        }

        public void MakePayment(string paymentMethod)
        {
            Console.WriteLine($"Made payment using {paymentMethod}.");
        }

        public void IssueTicketAndInvoice(string email)
        {
            Console.WriteLine($"Issued e-ticket and invoice to {email}.");
        }
    }

}
