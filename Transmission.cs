using System;
using System.Collections.Generic;

namespace PILab8
{
    internal class GearBoxKind
    {
        public static readonly string Manual = "Manual";
        public static readonly string Automatic = "Automatic";
        public static readonly string Sequental = "Sequental";
        public static readonly string Robotical = "Robotical";
        public static readonly string Variator = "Variator";

        public static List<string> Keys = new List<string>()
        {
            Manual, 
            Automatic, 
            Sequental, 
            Robotical, 
            Variator,
        };
    }

    internal class WheelsDriven
    {
        public static readonly string Front = "Front";
        public static readonly string Rear = "Rear";
        public static readonly string All = "All";
        public static readonly string FrontWithPlugInAll = "FrontWithPlugInAll";
        public static readonly string RearWithPlugInAll = "RearWithPlugInAll";

        public static List<string> Keys = new List<string>() 
        {
            Front,
            Rear,
            All,
            FrontWithPlugInAll,
            RearWithPlugInAll,
        };
    }

    internal abstract class GearBox
    {
        public string Kind;
        public uint Count;
        public int Speed = 0;

        public GearBox(string kind, uint count) {
            Kind = kind;
            Count = count; 
        }

        public abstract void Change(int speed);
    }

    internal class ManualGearBox : GearBox
    {
        public ManualGearBox(uint count) : base(GearBoxKind.Manual, count)
        {
        }

        public override void Change(int speed)
        {
            Speed = speed;
        }
    }

    internal class AutomaticGearBox : GearBox
    {
        public AutomaticGearBox(uint count) : base(GearBoxKind.Automatic, count)
        {
        }

        public override void Change(int speed)
        {
            if (speed <= 1)
            {
                Speed = speed;
            }
        }
    }

    internal class SequentalGearBox : GearBox
    {
        public SequentalGearBox(uint count) : base(GearBoxKind.Sequental, count)
        {
        }

        public override void Change(int speed)
        {
            bool isDiffSequental = Math.Abs(Math.Abs(Speed) - Math.Abs(speed)) == 1;
            
            if (isDiffSequental)
            {
                Speed = speed;
            }
        }
    }

    internal class Transmission
    {
        public GearBox GearBox;
        public string Drive;

        public Transmission(GearBox gearBox)
        {
            GearBox = gearBox;
            Drive = WheelsDriven.Rear;
        }

        public Transmission(GearBox gearBox, string drive)
        {
            GearBox = gearBox;
            Drive = drive;
        }
    }
}
