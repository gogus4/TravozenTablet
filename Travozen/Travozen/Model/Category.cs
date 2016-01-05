using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Travozen.Model
{
    public class Category : ItemListView
    {
        public string Name { get; set; }
        public string Picture { get; set; }

        public ImageSource ImageDisplay
        {
            get
            {
                if (Picture == "")
                    return null;

                return new BitmapImage(new Uri(ApplicationData.Current.LocalFolder.Path + "\\Categories\\" + this.Picture));
            }
        }
    }
}
