using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace pz_010.Backroll
{
    class Photo
    {
        public FlowDocument text { get; }
        public Photo(FlowDocument document)
        {
            FlowDocument temp = new();
            TextRange a = new(document.ContentStart, document.ContentEnd);
            MemoryStream ms = new();
            a.Save(ms, DataFormats.Rtf);
            a = new(temp.ContentStart, temp.ContentEnd);
            a.Load(ms, DataFormats.Rtf);

            text = temp;
        }
    }
}
