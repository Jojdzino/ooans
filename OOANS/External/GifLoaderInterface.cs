using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.External
{
    // TODO: this should not be interface ???
    class GifLoaderInterface
    {
        // TODO: upravit text
        public List<Base64> SearchGifsByTextSortedByLength(string text)
        {
            return new List<Base64>();
        }
        public List<Base64> SearchGifsByTextWithSpecificQuality(string text, int quality)
        {
            return new List<Base64>();
        }
        public List<Base64> SearchGifsByTextWithTreshold(string text, float treshold)
        {
            return new List<Base64>();
        }
    }
}
