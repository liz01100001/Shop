using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _caregiryCars = new MockCategory();

        public IEnumerable<Car> Cars 
        {
           get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Быстрый и очень тихий автомобиль компании Tesla",
                        img = "",
                        prise = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _caregiryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городский жизни",
                        img = "",
                        prise = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _caregiryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "",
                        prise = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _caregiryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Удобный автомобиль для городской жизни ",
                        img = "",
                        prise = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _caregiryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "",
                        prise = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _caregiryCars.AllCategories.First()
                    },
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
    
}
