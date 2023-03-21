﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_007
{
    public class Store
    {
        public List<Order> AllPurchases { get; set; }

        public Store()
        {
            AllPurchases = new List<Order>();
        }

        public void SaveOrder(Client x, params Product[] a)
        {
            var temp = new Order(x, a);
            AllPurchases.Add(temp);
            
        }
    }
}
