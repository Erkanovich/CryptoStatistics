using System;

namespace CryptoStatistics.Models
{
    public class Session
    {
        public Guid Id { get; set; }
        public DateTime SessionStart { get; set; }
        public DateTime SessionEnd { get; set; }
        public int MegaHashesPerSecond { get; set; }
        public int NumberOfCompletions { get; set; }
        public int NumberOfErrors { get; set; }
        public int NumberOfStales { get; set; }
        public GfxSettings GfxSettings { get; set; }
    }
}
