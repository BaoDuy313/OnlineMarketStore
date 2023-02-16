using OnlineMarketStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketStore.ModelViews
{
    public class OrderDetailVM
    {
        public Order Order { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
    }
}
