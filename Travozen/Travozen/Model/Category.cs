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
    public class Category
    {
        public string Name { get; set; }
        public string Picture { get; set; }
        public ObservableCollection<Construction> Constructions { get; set; }

        public ImageSource ImageDisplay
        {
            get
            {
                if (Picture == "")
                    return null;

                return new BitmapImage(new Uri(ApplicationData.Current.LocalFolder.Path + "\\Categories\\" + this.Picture));
            }
        }

        public Category()
        {
            Constructions = new ObservableCollection<Construction>();

            /*Constructions.Add(new Construction() { PictureAfter = "after.jpg", PictureBefore = "before.jpg", Name = "Titre du chantier" });
            Constructions.Add(new Construction() { PictureAfter = "after.jpg", PictureBefore = "before.jpg", Name = "Titre du chantier" });
            Constructions.Add(new Construction() { PictureAfter = "after.jpg", PictureBefore = "before.jpg", Name = "Titre du chantier" });
            Constructions.Add(new Construction() { PictureAfter = "after.jpg", PictureBefore = "before.jpg", Name = "Titre du chantier" });
            Constructions.Add(new Construction() { PictureAfter = "after.jpg", PictureBefore = "before.jpg", Name = "Titre du chantier" });*/
        }
    }
}
