using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdded();
            //ColorAdded();
            //GetCarDetails();
            //CarAddedd();

            //UserAdded();
            //CustomerAdded();


        }

        private static void CustomerAdded()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { UserId = 1, CompanyName = "Home" });
            if (result.Success)
            {
                System.Console.WriteLine(result.Message);
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }

        private static void UserAdded()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.Add(new User { FirstName = "Fırat", LastName = "Kılıç", Password = "1903", Email = "firatkilic97@gmail.com" });
            if (result.Success)
            {
                System.Console.WriteLine(result.Message);
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }

        //private static void CarAddedd()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var result = carManager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2021, DailyPrice = 20000, Description = "m" });

        //    if (result.Success)
        //    {
        //        System.Console.WriteLine(result.Message);
        //    }
        //    else
        //    {
        //        System.Console.WriteLine(result.Message);
        //    }
        //}

        //private static void GetCarDetails()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    var result = carManager.GetCarDetails();

        //    if (result.Success)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            System.Console.WriteLine(car.Description + "\n" + car.BrandName + "\n" + car.ColorName + "\n" + car.DailyPrice);
        //        }

        //    }
        //    else
        //    {
        //        System.Console.WriteLine(result.Message);
        //    }
        //}

        //private static void ColorAdded()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    colorManager.Add(new Color { ColorName = "Turuncu" });
        //    foreach (var colors in colorManager.GetAll())
        //    {
        //        System.Console.WriteLine(colors.ColorName);
        //    }
        //}

        //private static void CarAdded()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    carManager.Add(new Car { BrandId = 5, ColorId = 2, Description = "Fast", ModelYear = 2020, DailyPrice = 20000 });
        //    carManager.Add(new Car { BrandId = 7, ColorId = 1, Description = "Cheaper", ModelYear = 2019, DailyPrice = 15000 });
        //    foreach (var cars in carManager.GetAll())
        //    {
        //        System.Console.WriteLine(cars.Description + " " + cars.DailyPrice);
        //    }
        //}
    }
}
