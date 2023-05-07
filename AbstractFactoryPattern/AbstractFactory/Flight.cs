using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Flight : ISpecimen
    {

        public int Id { get; set; }  
        public string Name { get; set; }
        public string Destination { get; set; }
        public int flightTime { get; set; }
        public DateTime Date { get; set; }

        public int Price { get; set; }

        public Flight(int id, string name, string destination, int flighttime, DateTime date, int price)
        {
            Id = id;
            Name = name;
            Destination = destination;
            flightTime = flighttime;
            Date = date;
            Price = price;
        }

        public void Show()
        {
            Console.WriteLine($" Id: {Id}\n Name: {Name}\n Destination: {Destination}\n Flight Time: {flightTime}h\n Date: {Date}\n Price: {Price}$\n\n");
        }
    }
}
