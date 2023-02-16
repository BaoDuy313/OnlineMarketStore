using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineMarketStore.Models
{
    public partial class Category
    {
        public Category()
        {
            News = new HashSet<News>();
            Products = new HashSet<Product>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public string Alias { get; set; }
        public string MetaKey { get; set; }
        public string MetaDesc { get; set; }

        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
