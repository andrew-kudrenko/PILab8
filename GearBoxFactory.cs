using System;
using System.Collections.Generic;

namespace PILab8
{
    using CreateDelegates = Dictionary<string, GearBoxCreateDelegate>;
    
    internal delegate GearBox GearBoxCreateDelegate(uint count);
    
    internal class GearBoxFactory
    {

        public static readonly CreateDelegates CreateDelegates = new CreateDelegates() 
        {
            { "Manual", count => new ManualGearBox(count) },
            { "Automatic", count => new AutomaticGearBox(count) },
            { "Sequental", count => new SequentalGearBox(count) },
        };

        public static GearBox Create(string kind, uint count)
        {
            if (!CreateDelegates.ContainsKey(kind)) 
            { 
                throw new NotImplementedException($"GearBox actory method for {kind} isn't implemented");       
            }

            return CreateDelegates[kind](count);
        }
    }
}
