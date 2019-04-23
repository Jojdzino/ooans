using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOANS.Adapter
{
    interface IExternalAtachmentAdapter
    {
        List<Image> SearchGifsWithText(string text);
        List<Image> SearchMemesWithImage(Image image);
        List<Image> SearchMemesWithText(string text);
    }
}
