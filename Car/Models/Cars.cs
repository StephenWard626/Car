using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Models
{
    public enum EngineType
    {
        Petrol, Diesel, Hybrid, Electric
    }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public EngineType Engine { get; set; }
        public int EngineSize { get; set; }
        
    }
}
