using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            

            

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "A fast car",
                        longDesc = "A beautiful, fast, silent car by Tesla Company",
                        img = "/img/Tesla Model S.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Electrocars"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "A silent and comfortable",
                        longDesc = "A comfortable car for city life",
                        img = "/img/Ford Fiesta.jpg",
                        price = 11000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Classic cars"]
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
                        Category = Categories["Classic cars"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Silent and economy",
                        longDesc = "A comfortable car for city life",
                        img = "/img/Nissan Leaf.jpg",
                        price = 20000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Electrocars"]
                    }
                    );
            }

            content.SaveChanges();

        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category(){categoryName = "Electrocars", desc = "Modern vehicle"},
                        new Category(){categoryName = "Classic cars", desc = "Cars with gasoline engine"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category c in list)
                    {
                        category.Add(c.categoryName, c);
                    }
                }
                return category;
            ;
            }
        }


    }
}
