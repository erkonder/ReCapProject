﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetById(int carId);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<Car> GetAll();

    }
}
