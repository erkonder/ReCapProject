using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id = 1 , BrandId = 1 , ColorId = 1 , DailyPrice = 150000 , Description = "Clio" },
                new Car {Id = 2 , BrandId = 1 , ColorId = 3 , DailyPrice = 55000 , Description = "Doğan" },
                new Car {Id = 3 , BrandId = 2 , ColorId = 5 , DailyPrice = 460000 , Description = "C180" },
                new Car {Id = 4 , BrandId = 2 , ColorId = 3 , DailyPrice = 520000 , Description = "X5" },
                new Car {Id = 5 , BrandId = 1 , ColorId = 2 , DailyPrice = 125000 , Description = "Fiesta" },

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            Car getCarById = null;
            getCarById = _cars.Where(c => c.Id == carId).First();
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
