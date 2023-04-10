using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_010.Backroll
{
    class Album
    {
        public Stack<Photo> photos {  get; set; }

        public Album()
        {
            photos = new Stack<Photo>();
        }
    }
}
