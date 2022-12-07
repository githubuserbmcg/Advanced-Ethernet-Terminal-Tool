using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Advanced_Ethernet_Terminal_Tool
{
    public class Category
    {
        public String Name { get; set; }
        public String CategoryIcon { get; set; }
        public ObservableCollection<Category> Children { get; set; }
        public bool IsLeaf { get; set; }

        
    }

    public enum eCategoryIcon
    {
        Home,
        Keyboard,
        Page,
        Mail
    }


}
