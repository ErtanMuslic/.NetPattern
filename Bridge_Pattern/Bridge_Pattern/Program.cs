using System;
using Bridge_Pattern;

class Program
{
    static void Main(string[] args)
    {
        IAirlineSystem swissAirlineSystem = new SwissAirlineSystem();
        IBookingSystem onlineBookingSystem = new OnlineBookingSystem(swissAirlineSystem);

        onlineBookingSystem.LogIn("Ertan", "Muslic");
        onlineBookingSystem.SearchFlights("2023-05-20", "New York", false);
        onlineBookingSystem.SelectOffer("SWISS123");
        onlineBookingSystem.AddPassenger("Ermin", "Muslic", "abcd123", new DateTime(2003, 5, 10));
        onlineBookingSystem.ConfirmReservation();
        onlineBookingSystem.MakePayment("credit card");
        onlineBookingSystem.IssueTicketAndInvoice("ertanmuslic@gmail.com");

        Console.ReadKey();
    }
}





