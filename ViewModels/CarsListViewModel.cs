using Shop.Data.Models;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> getAllCars { get; set; }

        public string currCategory { get; set; }

    }
}
