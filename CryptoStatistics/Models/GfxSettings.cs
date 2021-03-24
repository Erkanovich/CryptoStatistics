using System;
using System.Collections.Generic;

namespace CryptoStatistics.Models
{
    public class GfxSettings
    {
        public GfxSettings()
        {
            Sessions = new List<Session>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ClockFrequency { get; set; }
        public int Voltage { get; set; }
        public int MemoryFrequency { get; set; }
        public int Wattage { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}
