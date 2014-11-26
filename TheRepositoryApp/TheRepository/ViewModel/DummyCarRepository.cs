using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRepository.ViewModel
{
    class DummyCarRepository : ICarRepository
    {
        public IEnumerable<Car> GetAllCars()
        {
            return new List<Car>()
            {
                new Car { Merk = "Opel",Model = "Astra" , Prijs = 15000, Bijtelling = 20},
                new Car { Merk = "Seat",Model = "Leon" , Prijs = 25000, Bijtelling = 20},
                new Car { Merk = "Volkswagen",Model = "Golf" , Prijs = 35000, Bijtelling = 20}
            };
        }
    }
}
