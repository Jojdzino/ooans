using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOANS.Facade;

namespace OOANS.Adapter
{
    class ExternalAtachmentAdapter : IExternalAtachmentAdapter
    {
        ExternalAttachmentFacade facade = new ExternalAttachmentFacade();

        public List<Image> SearchMemesWithImage(Image image)
        {
            // Convert our Image to Base64 format (used for external API)
            Base64 bImage = new Base64();
            // bImage = ToBase64(image);
            // call external API
            List<Base64> results = facade.SearchMemesWithImage(bImage);
            // Convert array of Base64 from external API
            // foreach base64 do FromBase64(base64)
            List<Image> memes = new List<Image>();
            return memes;
        }

        public List<Image> SearchGifsWithText(string text)
        {
            // call external API
            List<Base64> results = facade.SearchGifsWithText(text);
            // Convert array of Base64 from external API
            // foreach base64 do FromBase64(base64)
            List<Image> gifs = new List<Image>();
            return gifs;
        }

        public List<Image> SearchMemesWithText(string text)
        {
            // call external API
            List<Base64> results = facade.SearchMemesWithText(text);
            // Convert array of Base64 from external API
            // foreach base64 do FromBase64(base64)
            List<Image> memes = new List<Image>();
            return memes;
        }
    }
}
