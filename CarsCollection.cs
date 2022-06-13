using System;
using System.Collections.Generic;
using System.Linq;

namespace PILab8
{
    internal class CarsCollection
    {
        public readonly List<Car> Cars = new List<Car>();

        public CarsCollection()
        {
            foreach (var car in CarsPresets.DefaultCars)
            {
                Cars.Add(car);
            }
        }

        public List<Car> FindByBrand(string brand)
        {
            return Cars.Where(c => c.Brand == brand).ToList();
        }

        public void SortByBrandAndModel()
        {
            Cars.Sort((a, b) => ((string) a).CompareTo((string) b));
        }

        public int CountByBrand(string brand) => Cars.Count(c => c.Brand == brand);

        public void Sort()
        {
            Cars.Sort();
        }

        public List<Car> FilterOnlyWithModel() => Cars.Where(c => c.Model.Length > 0).ToList();
    }
}
