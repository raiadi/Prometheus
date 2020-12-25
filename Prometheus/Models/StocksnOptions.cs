using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prometheus.Models
{
    public class StocksnOptions
    {
        public object Stocks { get; set; }
        public List<OptionRead> Options { get; set; }
    }
}
