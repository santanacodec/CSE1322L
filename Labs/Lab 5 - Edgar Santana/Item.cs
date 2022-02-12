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

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public abstract void getListing();

        public override string ToString()
        {
            return title;
        }
    }
}
