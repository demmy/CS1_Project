using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Data.DummyData
{
    static partial class Storage
    {
        public static List<Location> Locations = new List<Location>
        {
            new Location{Adress = "", City = "Dnepropetrovsk"},
            new Location{Adress = "", City = "Dnepropetrovsk"},
            new Location{Adress = "", City = "Dnepropetrovsk"},
            new Location{Adress = "", City = "Dnepropetrovsk"}
        }; 

        public static List<Client> Clients = new List<Client>
        {
            new Client(new List<string>()){ClientLocation = Locations[0], Id = 1, IsActive = true, User = Users[0], Date = new DateTime(2003, 11, 2, 23, 9, 0)},
            new Client(new List<string>()){ClientLocation = Locations[0], Id = 1, IsActive = true, User = Users[1], Date = new DateTime(2003, 9, 1, 11 , 9, 0)},
            new Client(new List<string>()){ClientLocation = Locations[0], Id = 1, IsActive = true, User = Users[2], Date = new DateTime(2003, 8, 3, 6, 12, 3)}
        }; 
    }
}
