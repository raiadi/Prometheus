using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prometheus.Models
{
    public class OptionDetails
    {
        public string symbol;
        public double strike;
        public double last;
        public double bid;
        public double ask;
        public double open_interest;
        public double volume;
        public double change;
        public double percentChange;
        public double iv;
    }
}
