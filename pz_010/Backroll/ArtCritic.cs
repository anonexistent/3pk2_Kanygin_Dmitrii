using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace pz_010.Backroll
{
    class ArtCritic
    {
        FlowDocument document { get; set; }
        public void SetPhoto(Photo photo)
        {
            document = photo.text;
        }
        public Photo GetPhoto() 
        {
            return new Photo(document);
        }
    }
}
