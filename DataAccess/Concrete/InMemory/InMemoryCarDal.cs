﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                    new Car{Id=1, BrandId=1, ColorId=4, DailyPrice=450,ModelYear=2015, Description ="kaliteli araba" },
                    new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=320,ModelYear=2013, Description ="uygun fiyatlı" },
                    new Car{Id=3, BrandId=2, ColorId=6, DailyPrice=510,ModelYear=2019, Description ="lüks araba" },
                    new Car{Id=4, BrandId=3, ColorId=1, DailyPrice=480,ModelYear=2019, Description ="dağ arabası" },
                    new Car{Id=5, BrandId=2, ColorId=3, DailyPrice=730,ModelYear=2021, Description ="offroad kaliteli" },
                    new Car{Id=6, BrandId=1, ColorId=2, DailyPrice=550,ModelYear=2019, Description ="alçak spor " },

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            //LINQ ile yazdık.

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }
        public void Update(Car car)
        {
            //LINQ kullandık (yukarıdakinin aynısını aldık birisi silme birisi güncelleme.)
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public List<Car> GetAllById(int Id)
        {
            //ICarDal üzerinden listeyi oluşturup buradan implement ettik

            return _cars.Where(p => p.Id == Id).ToList();
        }

    }
}