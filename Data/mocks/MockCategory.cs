using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get 
            {
                return new List<Category>()
                {
                    new Category(){categoryName = "Electrocars", desc = "Modern vehicle"},
                    new Category(){categoryName = "Classic cars", desc = "Cars with gasoline engine"}
                };
            
            }
        }
    }
}
