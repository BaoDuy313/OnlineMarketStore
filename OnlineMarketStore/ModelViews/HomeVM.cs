using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMarketStore.Models;

namespace OnlineMarketStore.ModelViews
{
    public class HomeVM
    {

        public List<News> News { get; set; }
        public List<ProductHomeVM> Products { get; set; }
    }
}
