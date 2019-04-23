using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.External
{
    // TODO: this should not be interface ???
    class MemeLoaderInterface
    {
        public List<Base64> SearchMemesByPictureWithTreshold(Base64 image, float treshold)
        {
            return new List<Base64>();
        }
        public List<Base64> SearchMemesByTextWithSpecificQuality(string text, int quality)
        {
            return new List<Base64>();
        }
        public List<Base64> SearchMemesByTextWithTreshold(string text, float treshold)
        {
            return new List<Base64>();
        }
    }
}
