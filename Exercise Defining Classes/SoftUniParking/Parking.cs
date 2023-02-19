using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string,Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string,Car>();
        }
        public int Count { get { return cars.Count; } }


        public string AddCar(Car car)
        {
            string registrationNumber=car.RegistrationNumber;
            if (cars.ContainsKey(registrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (cars.Count>=capacity)
            {
                return ("Parking is full!");
            }
            cars.Add(registrationNumber,car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }
        public string RemoveCar(string registrationNumber)
        {
            if (!cars.ContainsKey(registrationNumber))
            {
                return ("Car with that registration number, doesn't exist!");
            }
            cars.Remove(registrationNumber);
            return $"Successfully removed {registrationNumber}";
        }
        public Car GetCar(string registrationNumber)
        {
            return cars[registrationNumber];
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var registrationNumber in RegistrationNumbers)
            {
                RemoveCar(registrationNumber);
            }
        }
    }
}