using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    interface IBookingSystem
    {
        void LogIn(string username, string password);
        void Register(string username, string password);
        void SearchFlights(string date, string destination, bool returnTicket);
        void SelectOffer(string offerId);
        void AddPassenger(string name, string surname, string passportNumber, DateTime dateOfBirth);
        void ConfirmReservation();
        void MakePayment(string paymentMethod);
        void IssueTicketAndInvoice(string email);
    }
}
