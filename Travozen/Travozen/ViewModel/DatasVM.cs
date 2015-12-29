using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travozen.Model;

namespace Travozen.ViewModel
{
    public class DatasVM
    {
        private static DatasVM _instance = null;
        public static DatasVM Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatasVM();
                return _instance;
            }
        }

        public ObservableCollection<Category> Categories { get; set; }

        public DatasVM()
        {
            Categories = new ObservableCollection<Category>();
            GetDatas();
        }

        public void GetDatas()
        {
            Categories.Add(new Category() { Name = "Carrelage", Picture = "carrelage.jpg" });
            Categories.Add(new Category() { Name = "Chambre", Picture = "chambre.jpg" });
            Categories.Add(new Category() { Name = "Cuisine", Picture = "cuisine.jpg" });
            Categories.Add(new Category() { Name = "Escalier", Picture = "escalier.jpg" });
            Categories.Add(new Category() { Name = "Fenêtre", Picture = "fenetre.jpg" });
            Categories.Add(new Category() { Name = "Jardin", Picture = "jardin.jpg" });
            Categories.Add(new Category() { Name = "Salle de bain", Picture = "salle_de_bain.jpg" });
            Categories.Add(new Category() { Name = "Salon", Picture = "salon.jpg" });
        }
    }
}
