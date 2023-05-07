using AbstractFactory;


var users = new List<User>();
var flights = new List<Flight>();

var user1 = new User("Ertan","Muslic",12312312,new DateOnly(2001,05,18),"Belgrade",new DateTime(2001,05,01),"One-way");
users.Add(user1);
Console.WriteLine("User:\n");
user1.Show();

var flight1 = new Flight(1,"Swis","Belgrade",8,new DateTime(2001,02,04,3,0,0),300);
var flight2 = new Flight(2, "Lufthansa", "Belgrade", 10, new DateTime(2001, 02, 04, 3, 0, 0), 432);
var flight3 = new Flight(3, "Eurowings", "Paris", 12, new DateTime(2001, 02, 04, 3, 0, 0), 531);
var flight4 = new Flight(4, "Turkishairlines", "Istanbul", 15, new DateTime(2001, 02, 04, 3, 0, 0), 250);
var flight5 = new Flight(5, "Swis", "Sarajevo", 6, new DateTime(2001, 02, 04, 3, 0, 0), 365);
flights.Add(flight1);
flights.Add(flight2);
flights.Add(flight3);
flights.Add(flight4);
flights.Add(flight5);

Console.WriteLine("Flights:\n");
foreach(var flight in flights)
{
    flight.Show();
}


while (true)
{
    Console.WriteLine("1.Choose a Flight\n2.Add new User\n");
    var input = Convert.ToInt32(Console.ReadLine());
    if (input == 1)
    {
        Console.WriteLine($"Flights available for User: {user1.Name}\n");
        foreach (var flight in flights)
        {
            if (flight.Destination == user1.Destination)
            {
                flight.Show();
            }
        }

        Console.WriteLine("Choose a flight (id)");
        var id = Convert.ToInt32(Console.ReadLine());

        foreach (var flight in flights)
         {
            if (id == flight.Id)
            {
               Console.WriteLine($"Flight:\n");
               flight.Show();
               Console.WriteLine("Passengers:\n");
               foreach (var person in users)
                {
                 person.Show();

                }
             }
         }
        break;
     }

    if (input == 2)
    {
        Console.WriteLine("Enter Name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter Surname:");
        var surname = Console.ReadLine();
        Console.WriteLine("Enter Passport Number:");
        var pass = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Date of Birth:(Format -> yyyy:mm:dd)\n");
        var date = DateOnly.Parse(Console.ReadLine());
        var user2 = new User(name,surname,pass,date, user1.Destination, user1.Date, user1.ticketType);
        users.Add(user2);
    }
    else
    {
        Console.WriteLine("Invalid Input\n Try Again\n");
    }
    }
