using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllGetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
    }
}
