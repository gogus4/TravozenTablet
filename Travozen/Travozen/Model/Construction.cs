using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Travozen.Model
{
    public class Construction
    {
        public string Name { get; set; }
        public string PictureBefore { get; set; }
        public string PictureAfter { get; set; }

        public ImageSource ImageDisplayBefore
        {
            get
            {
                if (PictureBefore == "")
                    return null;

                return new BitmapImage(new Uri(ApplicationData.Current.LocalFolder.Path + "\\Constructions\\" + this.PictureBefore));
            }
        }

        public ImageSource ImageDisplayAfter
        {
            get
            {
                if (PictureAfter == "")
                    return null;

                return new BitmapImage(new Uri(ApplicationData.Current.LocalFolder.Path + "\\Constructions\\" + this.PictureAfter));
            }
        }
    }
}
