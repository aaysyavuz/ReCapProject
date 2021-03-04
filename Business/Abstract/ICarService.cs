using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandid);
        List<Car> GetCarsByColorId(int colorid);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
