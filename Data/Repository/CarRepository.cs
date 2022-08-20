using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Data.Entity;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavorite).Include(c =>c.Category);

        public Car GetObjectCar(int carID) => appDBContent.Car.FirstOrDefault(p => p.id == carID);
    }
}
