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

        public void setPrice(double price)
        {
            this.price = price;
            if (price < 0)
            {
                throw new Exception("ERROR");
            }
        }

        public void setLowerQuantity(int quantity)
        {
            this.quantity -= quantity;

            if (quantity < 0)
            {
                throw new Exception("ERROR");
            }
        }

        public void setHigherQuantity(int quantity)
        {
            this.quantity += quantity;
        }

        public override string ToString()
        {
            return "id: " + id + "\ndescription: " + description +
                "\nprice: " + price + "\nquantity: " + quantity;
        }
    }
}
