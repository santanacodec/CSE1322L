using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5___Edgar_Santana
{
    abstract class Item
    {
        private string title;
        public Item()
        {
            title = "";
        }

        public Item(string title)
        {
            this.title = title;
        }
    }
}
