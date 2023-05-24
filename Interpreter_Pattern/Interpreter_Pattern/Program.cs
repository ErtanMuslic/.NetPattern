using System;
using Interpreter_Pattern;

class Program
{
    static void Main(string[] args)
    {
        IAirlineSystem swissAirlineSystem = new SwissAirlineSystem();
        IBookingSystem onlineBookingSystem = new OnlineBookingSystem(swissAirlineSystem);

        onlineBookingSystem.LogIn("Ertan Muslic", "1234");
        onlineBookingSystem.SearchFlights("2023-07-10", "Belgrade", false);
        onlineBookingSystem.SelectOffer("SWISS123");
        onlineBookingSystem.AddPassenger("Marko", "Popovic", "Acasd", new DateTime(2001, 3, 7).ToString());
        onlineBookingSystem.ConfirmReservation();
        onlineBookingSystem.MakePayment("credit card");
        onlineBookingSystem.IssueTicketAndInvoice("ertanmuslic@gmail.com");

        Console.ReadKey();
    }
}
