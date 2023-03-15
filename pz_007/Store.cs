using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_007
{
    public class Store
    {
        public List<Order> AllPurchases { get; set; } = new List<Order>();

        public void SaveOrder(Client x, params Product[] a)
        {
            var temp = new Order() { Buyer = x, Items = a.ToList()};
            AllPurchases.Add(temp);
        }
    }
}
