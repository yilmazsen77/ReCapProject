using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carimage, IFormFile file);
        IResult Update(CarImage carimage, IFormFile file);
        IResult Delete(CarImage carimage);
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetAll(Expression<Func<CarImage, bool>> filter = null);
        IDataResult<List<CarImage>> GetImagesByCarId(int carId);



    }
}
