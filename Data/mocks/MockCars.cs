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
                        img = "https://unsplash.com/s/photos/tesla", 
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
                        img = "https://www.istockphoto.com/photos/ford-fiesta",
                        price = 11000,
                        isFavorite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Fury and fast",
                        longDesc = "A comfortable car for city life",
                        img = "https://www.shutterstock.com/search/bmw-m3",
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
                        img = "https://www.caranddriver.com/nissan/leaf",
                        price = 20000,
                        isFavorite = true,
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
