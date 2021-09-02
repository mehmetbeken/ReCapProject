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

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { ModelYear = 2020, DailyPrice = 10000, Description = "Fast",ColorId=1,BrandId=1 });

           
            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
            }

          


        }
   
    }
}
