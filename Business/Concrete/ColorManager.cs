using Business.Abstract;
using Business.BusinessAcpects.Autofac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [SecuredOperation("color.add,admin")]
        [ValidationAspect(typeof(ColorValidator))]
        [CacheRemoveAspect("IColorService.Get")]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();

        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Color color)
        {
            Add(color);
            if (color.Name.StartsWith("a"))
            {
                throw new Exception("");
            }

            Add(color);
            return null;
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();

        }

        [CacheAspect]
        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.Listed);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(p => p.Id == id));
        }

        [CacheRemoveAspect("IColorService.Get")]
        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();

        }
    }
}
