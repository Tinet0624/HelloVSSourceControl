using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVSSourceControl
{
    /// <summary>
    /// Represents one vehicle
    /// with # in stock
    /// </summary>
    class Vehicle
    {
        /// <summary>
        /// Make of the vehicle ex. Honda
        /// </summary>
        public string Make { get; set; }
        /// <summary>
        /// Model of vehicle ex. Prelude
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// How many of the vehicles are in stock
        /// </summary>
        public byte QuantityInStock { get; set; }
    }
}
