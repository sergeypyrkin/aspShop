using shop.Data.interfaces;
using shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _mycarscategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                List<Car> cars = new List<Car>()
                {
                    new Car(){name="Tesla",price=45000,isFavourite=true, available=true, Category= _mycarscategory.AllCategories.First()},
                    new Car(){name="Volga",price=25000,isFavourite=true, available=true, Category= _mycarscategory.AllCategories.First()},
                    new Car(){name="Moscvich",price=15000,isFavourite=true, available=true, Category= _mycarscategory.AllCategories.First()},
                    new Car(){name="Lada",price=40000,isFavourite=true, available=true, Category= _mycarscategory.AllCategories.First()}

                };

                return cars;
            }
        }
        public IEnumerable<Car> getFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
