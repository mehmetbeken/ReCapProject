using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager= new CarManager(new InMemoryCarDal());

            carManager.Add(new Car { Id = 7, BrandId = 3, ColorId = 3, DailyPrice = 3500, Description = "Beautiful", ModelYear = 2020 });
            
            carManager.Delete(new Car { Id = 1 });

            carManager.Update(new Car { Id = 7, BrandId = 3, ColorId = 3, DailyPrice = 3500, Description = "Kind", ModelYear = 2020 });

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }

            System.Console.WriteLine(carManager.GetById(7).Description);
          
        }
    }
}
