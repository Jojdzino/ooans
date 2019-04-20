using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOANS.External;

namespace OOANS.Facade
{
    class ExternalAttachmentFacade
    {
        // something aggregated ?
        GifLoaderInterface gifLoader = new GifLoaderInterface();
        MemeLoaderInterface memeLoader = new MemeLoaderInterface();

        readonly float textTreshold = 0.66f;
        readonly float imageTreshold = 0.33f;

        public List<Base64> SearchGifsWithText(string text)
        {
            return gifLoader.SearchGifsByTextSortedByLength(text);
        }
        // TODO: check parameter (file->image)
        public List<Base64> SearchMemesWithImage(Base64 image)
        {
            return memeLoader.SearchMemesByPictureWithTreshold(image, imageTreshold);
        }
        public List<Base64> SearchMemesWithText(string text)
        {
            return memeLoader.SearchMemesByTextWithTreshold(text, textTreshold);
        }
    }
}
