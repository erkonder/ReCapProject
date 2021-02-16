using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine("Marka Id'si :" +cars.BrandId + " Açıklama : " + cars.Description + " Renk Id'si :" + cars.ColorId + " Fiyatı :" + cars.DailyPrice);

            }
        }
    }
}
