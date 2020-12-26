using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prometheus.Models
{
    public class ListUsers
    {
        public int page;
        public int per_page;
        public int total;
        public int total_pages;
        public List<SingleUser> data { get; set; }
    }
}
