using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id=1,Name="Pizza Hut",Location="Westgate",Cusine=CusineType.Italian},
                new Restaurant{Id=2,Name="Banana Leaf",Location="Little India",Cusine=CusineType.Indian},
                new Restaurant{Id=3,Name="Stuff'd",Location="Clementi",Cusine=CusineType.Mexican},

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name).ToList();
        }
    }
}
