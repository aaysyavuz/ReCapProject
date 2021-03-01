using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Car> _cars;

        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1,BrandId = 1,ColorId = 1,DailyPrice = 40000,ModelYear = "2001",Description = "10000 km"},
                new Car{Id = 2,BrandId = 1,ColorId = 2,DailyPrice = 50000,ModelYear = "2020",Description = "25000 km"},
                new Car{Id = 3,BrandId = 2,ColorId = 2,DailyPrice = 80000,ModelYear = "2010",Description = "5000 km"},
                new Car{Id = 4,BrandId = 2,ColorId = 4,DailyPrice = 100000,ModelYear = "2005",Description = "20000 km"},
                new Car{Id = 5,BrandId = 3,ColorId = 3,DailyPrice = 120000,ModelYear = "2019",Description = "12000 km"},

            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }


    }
}
