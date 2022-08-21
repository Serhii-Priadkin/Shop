using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get { 
                {
                return new List<Car>()
                { 
                    new Car 
                    { 
                        name = "Tesla Model S", 
                        shortDesc = "A fast car", 
                        longDesc = "A beautiful, fast, silent car by Tesla Company", 
                        img = "/img/Tesla Model S.jpg", 
                        price = 45000, 
                        isFavorite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "A silent and comfortable",
                        longDesc = "A comfortable car for city life",
                        img = "/img/Ford Fiesta.jpg",
                        price = 11000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Fury and fast",
                        longDesc = "A comfortable car for city life",
                        img = "/img/BMW M3.jpg",
                        price = 65000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Silent and economy",
                        longDesc = "A comfortable car for city life",
                        img = "/img/Nissan Leaf.jpg",
                        price = 20000,
                        isFavorite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };

                };  
            }
        
        }
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car GetObjectCar(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
