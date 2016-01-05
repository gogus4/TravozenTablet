using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travozen.Model
{
    public class ItemListView
    {
        public string Id { get; set; }
        public ObservableCollection<Construction> Constructions { get; set; }

        public ItemListView()
        {
            Constructions = new ObservableCollection<Construction>();
        }
    }
}