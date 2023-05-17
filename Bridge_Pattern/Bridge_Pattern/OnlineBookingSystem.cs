using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
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
            // Actual implementation for logging in to the online booking system
        }

        public void Register(string username, string password)
        {
            Console.WriteLine($"Registered to the online booking system with username: {username} and password: {password}.");
            // Actual implementation for registering to the online booking system
        }

        public void SearchFlights(string date, string destination, bool returnTicket)
        {
            Console.WriteLine($"Searching flights for date: {date}, destination: {destination}, return ticket: {returnTicket}.");
            airlineSystem.CheckAvailability(date, destination);
            // Actual implementation for searching flights
        }

        public void SelectOffer(string offerId)
        {
            Console.WriteLine($"Selected offer with ID: {offerId}.");
            // Actual implementation for selecting an offer
        }

        public void AddPassenger(string name, string surname, string passportNumber, DateTime dateOfBirth)
        {
            Console.WriteLine($"Added passenger: {name} {surname}, Passport Number: {passportNumber}, Date of Birth: {dateOfBirth}.");
            // Actual implementation for adding a passenger
        }

        public void ConfirmReservation()
        {
            Console.WriteLine("Confirmed the reservation.");
            // Actual implementation for confirming the reservation
        }

        public void MakePayment(string paymentMethod)
        {
            Console.WriteLine($"Made payment using {paymentMethod}.");
            // Actual implementation for making the payment
        }

        public void IssueTicketAndInvoice(string email)
        {
            Console.WriteLine($"Issued e-ticket and invoice to {email}.");
            // Actual implementation for issuing the e-ticket and invoice
        }
    }
}
