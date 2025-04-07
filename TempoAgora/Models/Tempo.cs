using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempoAgora.Models
{
    public class Tempo
    {

        public double? lon { get; set; }
        public double? lat { get; set; }
        public double? temp_min { get; set; }
        public double? temp_max { get; set; }
        public int? visibility { get; set; }
        public string? main { get; set; }
        public string? description { get; set; }
        public double? windSpeed { get; set; }
        public DateTime? sunrise { get; set; }
        public DateTime? sunset { get; set; }

    }
}