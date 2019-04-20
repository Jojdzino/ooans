using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Adapter
{
    interface IExternalAtachmentAdapter
    {
        // TODO: upravit model, chyba parameter (pre vsetky)
        List<Image> SearchGifsWithText(string text);
        List<Image> SearchMemesWithImage(Image image);
        List<Image> SearchMemesWithText(string text);
    }
}
