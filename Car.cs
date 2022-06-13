using System;

namespace PILab8
{
    internal class Car : IComparable<Car>
    {
        public Transmission Transmittion { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int CompareTo(Car car) => GetInfo(this).CompareTo(GetInfo(car));

        public static bool operator true(Car car) => car != null;

        public static bool operator false(Car car) => car == null;

        public static explicit operator string(Car car) => GetInfo(car);

        public static implicit operator Car(string info) 
        {
            string[] parts = info.Split(' ');
            return new Car() { Brand = parts?[0], Model = parts?[1] };
        }

        private static string GetInfo(Car car) => $"{car.Brand} {car.Model}";
    }
}
