using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class User : ISpecimen
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int passNum { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public string ticketType { get; set; }


        public User(string name, string surname, int pass, DateOnly birthDate, string destination, DateTime date, string ticket)
        {
            Name = name;
            Surname = surname;
            passNum = pass;
            BirthDate = birthDate;
            Destination = destination;
            Date = date;
            ticketType = ticket;
        }

        public void Show()
        {
            Console.WriteLine($" Name: {Name}\n Surname: {Surname}\n Passport Number: {passNum}\n Birth Date: {BirthDate}\n Destination: {Destination}\n Date: {Date}\n Ticket: {ticketType}\n\n");
        }
    }
}
