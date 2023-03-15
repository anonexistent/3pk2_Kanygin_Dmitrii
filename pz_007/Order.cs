using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_007
{
    public class Order
    {

        /*
            сделать момент чтобы когда покупка проходит человекчку делалось ++++++
         */

        public Client Buyer { get; set; }
        public List<Product> Items { get; set; } = new List<Product>();
    }
}
