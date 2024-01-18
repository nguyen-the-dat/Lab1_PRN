using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        private static List<Car> carList = new List<Car>() { new Car { CarID = 1, CarName = "CRV", Manufacturer = "Honda", Price = 3000, ReleaseYear = 2021 }, 
            new Car { CarID = 2, CarName = "Ford Focus", Manufacturer = "Ford", Price = 15000, ReleaseYear = 2020 } 
        };
        //using Singleton Pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance {
            get
            {
                lock (instanceLock) {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                }
                return instance;
            }
        }
        public List<Car> GetCarList => carList;
        //================================
        public Car GetCarByID(int cID)
        {
            Car car = carList.SingleOrDefault(pro=>pro.CarID == cID);
            return car;
        }
        //================================
        //Add new car
        public void AddNew(Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if(pro == null) {
                carList.Add(car);

            }
            else
            {
                throw new Exception("Car is already exists.");
            }
        }
        //================================
        //Update car
        public void Update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if ((c != null)){
                var index = carList.IndexOf(c);
                carList[index] = car;
            }
            else
            {
                throw new Exception("Car does not exists.");
            }

        }
        //================================
        //Delete car
        public void Remove(int carID)
        {
            Car p = GetCarByID(carID);
            if(p != null) {
            carList.Remove(p);
            }
            else
            {
                throw new Exception("Car does not already exists.");
            }
        }
    }//end class
}
