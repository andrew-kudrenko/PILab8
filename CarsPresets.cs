using System.Collections.Generic;

namespace PILab8
{
    internal class CarsPresets
    {
        public readonly static Dictionary<string, GearBox> GearBoxes = new Dictionary<string, GearBox>()
        {
            { "Manual 5", new ManualGearBox(5) },
            { "Automatic 6", new AutomaticGearBox(6) },
            { "Manual 6", new ManualGearBox(6) },
            { "Subaru Sequental", new SequentalGearBox(6) },
        };

        public readonly static List<Car> DefaultCars = new List<Car>() {
            new Car() {
                Brand = "Toyota",
                Model = "Mark 2", 
                Transmittion = new Transmission(GearBoxes["Manual 5"], WheelsDriven.Rear),
            },
            new Car() {
                Brand = "Subaru",
                Model = "Impreza WRX STI",
                Transmittion = new Transmission(GearBoxes["Subaru Sequental"], WheelsDriven.All),
            },
            new Car() {
                Brand = "Toyota",
                Model = "Cresta",
                Transmittion = new Transmission(GearBoxes["Manual 6"], WheelsDriven.Rear),
            },
            new Car() {
                Brand = "Toyota",
                Model = "Chaser",
                Transmittion = new Transmission(GearBoxes["Manual 5"], WheelsDriven.Rear),
            },
            new Car() {
                Brand = "Infiniti",
                Model = "QX35", 
                Transmittion = new Transmission(GearBoxes["Automatic 6"], WheelsDriven.FrontWithPlugInAll),
            },
            new Car() {
                Brand = "KIA",
                Model = "K5",
                Transmittion = new Transmission(GearBoxes["Automatic 6"], WheelsDriven.Front),
            },
            new Car() {
                Brand = "Toyota",
                Model = "Mark 2",
                Transmittion = new Transmission(GearBoxes["Automatic 6"], WheelsDriven.Rear),
            },
            new Car() {
                Brand = "Mazda",
                Model = "RX7",
                Transmittion = new Transmission(GearBoxes["Manual 5"], WheelsDriven.Rear),
            },
            new Car() {
                Brand = "Infiniti",
                Model = "G37",
                Transmittion = new Transmission(GearBoxes["Automatic 6"], WheelsDriven.Front),
            },
            new Car() {
                Brand = "Infiniti",
                Model = "G37",
                Transmittion = new Transmission(GearBoxes["Manual 6"], WheelsDriven.Front),
            },
            new Car() {
                Brand = "Infiniti",
                Model = "G37",
                Transmittion = new Transmission(GearBoxes["Manual 5"], WheelsDriven.Front),
            },
            new Car() {
                Brand = "Nissan",
                Model = "Silvia",
                Transmittion = new Transmission(GearBoxes["Manual 6"], WheelsDriven.Rear),
            },
        };
    }
}
