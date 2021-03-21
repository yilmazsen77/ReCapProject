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

            //CarCrudTest();

            //ColorCrudTest();

            //BrandCrudTest();

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
                Console.WriteLine(car.Description+" / "+car.ColorName+" / " + car.BrandName);
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

        private static void BrandCrudTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand
            {
                Name = "Şahin"
            });
            Console.WriteLine("Brand added.");

            brandManager.Update(new Brand
            {
                Id = 1,
                Name = "Seat"
            });
            Console.WriteLine("Brand updated");

            brandManager.Delete(new Brand
            {
                Id = 2,
            });
            Console.WriteLine("Brand deleted.");
        }

        private static void ColorCrudTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color
            {
                Name = "Matalik gri"
            });

            Console.WriteLine("Color added.");

            colorManager.Update(new Color
            {
                Id = 3,
                Name = "Sarı"
            });

            Console.WriteLine("Color updated.");

            colorManager.Delete(new Color
            {
                Id = 1,
            });

            Console.WriteLine("Color deleted.");
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

            Console.WriteLine("New car added.");

            carManager.Update(new Car
            {
                Id = 1,
                ColorId = 3,
                BrandId = 3,
                DailyPrice = 125,
                Description = "fdfd",
                ModelYear = 2021
            });

            Console.WriteLine("Car updated.");

            carManager.Delete(new Car
            {
                Id = 1
            });

            Console.WriteLine("Car deleted.");

        }
    }
}
