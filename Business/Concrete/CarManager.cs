using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private IProductDal _carDal;

        public CarManager(IProductDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _carDal.GetAll(p => p.BrandId == brandid);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll(p => p.ColorId == colorid);
        }

        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.CarName + " isimli araba eklendi!");
            }
            else if (car.CarName.Length<2)
            {
                Console.WriteLine("Araba isim uzunluğu minimum 2 karakter olmalıdır!");
            }
            else if (car.DailyPrice<0)
            {
                Console.WriteLine("Arabanın günlük fiyatı 0'dan büyük olmalıdır!");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
           _carDal.Update(car);
        }
    }
}
