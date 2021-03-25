using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //ColorTest();
            //BrandTest();
            //UserTest();
            //CustomerTest();
            //RentalTest();
            //CarCrudTest();
            //ColorCrudTest();
            //BrandCrudTest();
            //UserCrudTest();
            //CustomerCrudTest();
            //RentalCrudTest();



        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.Description + " / " + car.ColorName + " / " + car.BrandName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName);
            }

            Console.WriteLine(userManager.GetById(1).Data.FirstName);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }

            Console.WriteLine(customerManager.GetById(1).Data.CompanyName);
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.RentalDate);
            }

            Console.WriteLine(rentalManager.GetById(1).Data.RentalDate);
        }



        private static void BrandCrudTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand
            {
                Name = "Şahin"
            });


            brandManager.Update(new Brand
            {
                Id = 1,
                Name = "Seat"
            });


            brandManager.Delete(new Brand
            {
                Id = 2,
            });

        }

        private static void ColorCrudTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color
            {
                Name = "Matalik gri"
            });



            colorManager.Update(new Color
            {
                Id = 3,
                Name = "Sarı"
            });



            colorManager.Delete(new Color
            {
                Id = 1,
            });


        }

        private static void CarCrudTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                ColorId = 3,
                BrandId = 3,
                DailyPrice = 125,
                Description = "dfdsgsfg",
                ModelYear = 2021
            });



            carManager.Update(new Car
            {
                Id = 1,
                ColorId = 3,
                BrandId = 3,
                DailyPrice = 125,
                Description = "fdfd",
                ModelYear = 2021
            });



            carManager.Delete(new Car
            {
                Id = 1
            });



        }

        private static void CustomerCrudTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            customerManager.Add(new Customer
            {
                CompanyName = "abc"
            });


            customerManager.Update(new Customer
            {
                Id = 1,
                CompanyName = "Seat"
            });


            customerManager.Delete(new Customer
            {
                Id = 1,
            });

        }

        private static void UserCrudTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            userManager.Add(new User
            {
                FirstName = "abc",
                LastName = "abc",
                Email = "mail@abc.com",
                Password = "12344"
            });


            userManager.Update(new User
            {
                Id = 1,
                FirstName = "abc",
                LastName = "abc",
                Email = "mail@abc.com",
                Password = "12344"
            });


            userManager.Delete(new User
            {
                Id = 1,
            });

        }

        private static void RentalCrudTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentalDate = Convert.ToDateTime(6 / 7 / 2020),
                ReturnDate = Convert.ToDateTime(6 / 7 / 2020)
            });


            rentalManager.Update(new Rental
            {
                Id = 1,
                CarId = 1,
                CustomerId = 1,
                RentalDate = Convert.ToDateTime(6 / 7 / 2020),
                ReturnDate = Convert.ToDateTime(6 / 7 / 2020)
            });


            rentalManager.Delete(new Rental
            {
                Id = 1,
            });

        }
    }
}
