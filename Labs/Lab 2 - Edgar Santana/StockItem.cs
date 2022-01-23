using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2___Edgar_Santana
{
    class StockItem
    {
        string description;
        static int id;
        double price;
        int quantity;

        public StockItem() { }

        public StockItem(string description, double price, int quantity)
        {
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }

        public string getDescription()
        {
            return description;
        }

        public int getId()
        {
            return id;
        }

        public double getPrice()
        {
            return price;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public override string ToString()
        {
            return "id: " + id + "\ndescription: " + description +
                "\nprice: " + price + "\nquantity: " + quantity;
        }
    }
}
