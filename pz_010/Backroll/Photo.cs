using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace pz_010.Backroll
{
    class Photo
    {
        public FlowDocument text { get; }
        public Photo(FlowDocument document)
        {
            text = document;
        }
    }
}
