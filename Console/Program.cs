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
            // CarAdded();
            //ColorAdded();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                System.Console.WriteLine(car.Description + "\n" + car.BrandName + "\n" + car.ColorName + "\n" + car.DailyPrice);
            }

        }

        private static void ColorAdded()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color { ColorName = "Turuncu" });
            foreach (var colors in colorManager.GetAll())
            {
                System.Console.WriteLine(colors.ColorName);
            }
        }

        private static void CarAdded()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car { BrandId = 5, ColorId = 2, Description = "Fast", ModelYear = 2020, DailyPrice = 20000 });
            carManager.Add(new Car { BrandId = 7, ColorId = 1, Description = "Cheaper", ModelYear = 2019, DailyPrice = 15000 });
            foreach (var cars in carManager.GetAll())
            {
                System.Console.WriteLine(cars.Description + " " + cars.DailyPrice);
            }
        }
    }
}
