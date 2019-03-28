using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UWPDemo.Models
{
    public class MenuItem
    {
        public MenuItem()
        {
            SubMenus = new ObservableCollection<MenuItem>();
        }

        public string Title { get; set; }
        public string IconPath { get; set; }

        public ObservableCollection<MenuItem> SubMenus { get; set; }
    }
}
