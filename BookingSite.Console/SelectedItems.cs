using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.ConsoleV
{
    class SelectedItems
    {
        public ViewOfProduct SelectedProduct { get; set; }
        public ViewOfTypeOfProduct SelectedTypeOfProduct { get; set; }
        public ViewOfStore SelectedStore { get; set; }
    }
}
