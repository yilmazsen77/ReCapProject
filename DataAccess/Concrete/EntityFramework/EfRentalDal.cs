using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        

        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {

                var result = from c in context.Customers
                             join r in context.Rentals
                             on c.Id equals r.CustomerId
                             join cr in context.Cars
                             on r.CarId equals cr.Id
                             join b in context.Brands
                             on cr.BrandId equals b.Id
                             join cl in context.Colors
                             on cr.ColorId equals cl.Id
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 BrandName = b.Name,
                                 CarName = cr.Description,
                                 ColorName = cl.Name,
                                 CustomerCompanyName = c.CompanyName,
                                 CustomerName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 DailyPrice = cr.DailyPrice,
                                 RentalDate = r.RentalDate,
                                 ReturnDate = r.ReturnDate


                             };
                return result.ToList();
            }
        }
    }
}
