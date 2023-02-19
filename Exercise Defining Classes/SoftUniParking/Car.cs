using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            string result=
            $"Make: {this.Make}{Environment.NewLine}" +
            $"Mode: {this.Model}{Environment.NewLine}" +
            $"HorsePower: {this.HorsePower}{Environment.NewLine}" +
            $"RegistrationNumber: {this.RegistrationNumber}{Environment.NewLine}";

            return result;
        }
    }
}
