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
        public ObservableCollection<Customer> Customers { get; set; }

        public DatasVM()
        {
            Categories = new ObservableCollection<Category>();
            Customers = new ObservableCollection<Customer>();

            GetDatas();
        }

        private void FillCustomers()
        {
            Customers.Add(new Customer() { CustomerNumber = "000001" });

            var customerTwo = new Customer() { CustomerNumber = "000002" };
            customerTwo.Constructions.Add(new Construction() { Name = "Rénovation chambre", PictureAfter = "img-modified.jpg", PictureBefore = "img-original.jpg" });
            customerTwo.Constructions.Add(new Construction() { Name = "Rénovation chambre 1", PictureAfter = "after_city.jpg", PictureBefore = "before_city.jpg" });
            customerTwo.Constructions.Add(new Construction() { Name = "Rénovation chambre 2", PictureAfter = "img-modified.jpg", PictureBefore = "img-original.jpg" });
            customerTwo.Constructions.Add(new Construction() { Name = "Rénovation chambre 3", PictureAfter = "after_city.jpg", PictureBefore = "before_city.jpg" });
            customerTwo.Constructions.Add(new Construction() { Name = "Rénovation chambre 4", PictureAfter = "img-modified.jpg", PictureBefore = "img-original.jpg" });
            customerTwo.Constructions.Add(new Construction() { Name = "Rénovation chambre 5", PictureAfter = "after_city.jpg", PictureBefore = "before_city.jpg" });

            Customers.Add(customerTwo);

            var customerThree = new Customer() { CustomerNumber = "000003" };
            customerThree.Constructions.Add(new Construction() { Name = "Rénovation cuisine", PictureAfter = "after_cuisine.jpg", PictureBefore = "before_cuisine.jpg" });
            customerThree.Constructions.Add(new Construction() { Name = "Rénovation cuisine 1", PictureAfter = "after_cuisine.jpg", PictureBefore = "before_cuisine.jpg" });
            customerThree.Constructions.Add(new Construction() { Name = "Rénovation cuisine 2", PictureAfter = "after_cuisine.jpg", PictureBefore = "before_cuisine.jpg" });
            customerThree.Constructions.Add(new Construction() { Name = "Rénovation cuisine 3", PictureAfter = "after_cuisine.jpg", PictureBefore = "before_cuisine.jpg" });

            Customers.Add(customerThree);

            Customers.Add(new Customer() { CustomerNumber = "000003" });
            Customers.Add(new Customer() { CustomerNumber = "000004" });
            Customers.Add(new Customer() { CustomerNumber = "000005" });

            var customerSix = new Customer() { CustomerNumber = "000006" };
            customerSix.Constructions.Add(new Construction() { Name = "Rénovation salle de bain", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });
            customerSix.Constructions.Add(new Construction() { Name = "Rénovation salle de bain 1", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });
            customerSix.Constructions.Add(new Construction() { Name = "Rénovation salle de bain 2", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });
            customerSix.Constructions.Add(new Construction() { Name = "Rénovation salle de bain 3", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });
            customerSix.Constructions.Add(new Construction() { Name = "Rénovation salle de bain 4", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });

            Customers.Add(customerSix);

            Customers.Add(new Customer() { CustomerNumber = "000007" });
        }

        private void FillCategories()
        {
            Categories.Add(new Category() { Name = "Carrelage", Picture = "carrelage.jpg" });

            var categoryChambre = new Category() { Name = "Chambre", Picture = "chambre.jpg" };
            categoryChambre.Constructions.Add(new Construction() { Name = "Rénovation chambre", PictureAfter = "img-modified.jpg", PictureBefore = "img-original.jpg" });
            categoryChambre.Constructions.Add(new Construction() { Name = "Rénovation chambre 1", PictureAfter = "after_city.jpg", PictureBefore = "before_city.jpg" });
            categoryChambre.Constructions.Add(new Construction() { Name = "Rénovation chambre 2", PictureAfter = "img-modified.jpg", PictureBefore = "img-original.jpg" });
            categoryChambre.Constructions.Add(new Construction() { Name = "Rénovation chambre 3", PictureAfter = "after_city.jpg", PictureBefore = "before_city.jpg" });
            categoryChambre.Constructions.Add(new Construction() { Name = "Rénovation chambre 4", PictureAfter = "img-modified.jpg", PictureBefore = "img-original.jpg" });
            categoryChambre.Constructions.Add(new Construction() { Name = "Rénovation chambre 5", PictureAfter = "after_city.jpg", PictureBefore = "before_city.jpg" });

            Categories.Add(categoryChambre);

            var categoryCuisine = new Category() { Name = "Cuisine", Picture = "cuisine.jpg" };
            categoryCuisine.Constructions.Add(new Construction() { Name = "Rénovation cuisine", PictureAfter = "after_cuisine.jpg", PictureBefore = "before_cuisine.jpg" });
            categoryCuisine.Constructions.Add(new Construction() { Name = "Rénovation cuisine 1", PictureAfter = "after_cuisine.jpg", PictureBefore = "before_cuisine.jpg" });
            categoryCuisine.Constructions.Add(new Construction() { Name = "Rénovation cuisine 2", PictureAfter = "after_cuisine.jpg", PictureBefore = "before_cuisine.jpg" });
            categoryCuisine.Constructions.Add(new Construction() { Name = "Rénovation cuisine 3", PictureAfter = "after_cuisine.jpg", PictureBefore = "before_cuisine.jpg" });

            Categories.Add(categoryCuisine);

            Categories.Add(new Category() { Name = "Escalier", Picture = "escalier.jpg" });
            Categories.Add(new Category() { Name = "Fenêtre", Picture = "fenetre.jpg" });
            Categories.Add(new Category() { Name = "Jardin", Picture = "jardin.jpg" });

            var categorySDB = new Category() { Name = "Salle de bain", Picture = "salle_de_bain.jpg" };
            categorySDB.Constructions.Add(new Construction() { Name = "Rénovation salle de bain", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });
            categorySDB.Constructions.Add(new Construction() { Name = "Rénovation salle de bain 1", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });
            categorySDB.Constructions.Add(new Construction() { Name = "Rénovation salle de bain 2", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });
            categorySDB.Constructions.Add(new Construction() { Name = "Rénovation salle de bain 3", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });
            categorySDB.Constructions.Add(new Construction() { Name = "Rénovation salle de bain 4", PictureAfter = "after_sdb.jpg", PictureBefore = "before_sdb.jpg" });

            Categories.Add(categorySDB);

            Categories.Add(new Category() { Name = "Salon", Picture = "salon.jpg" });
        }

        public void GetDatas()
        {
            FillCategories();
            FillCustomers();
        }
    }
}
