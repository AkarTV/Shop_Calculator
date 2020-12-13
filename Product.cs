using System;

namespace Shop_app
{
    public class Product
    {
        public string name;
        public double price;
        public int quantity;
        public double total_price;
        static public double total_all = 0;

        public Product() { name = "noname"; price = 0.0; quantity = 0; }
        public Product(string pr_name) { name = pr_name; price = 0.0; quantity = 0; }
        public Product(string pr_name, double pr_price = 0.0, int pr_quan = 0) { name = pr_name; price = pr_price; quantity = pr_quan; }

        public void change_name(string nm)
        {
            name = nm;
        }
        public void change_price(double pr)
        {
            price = pr;
        }
        public void change_quan(int quan)
        {
            quantity = quan;
        }
        public void calculate_total(string nm, double arg)
        {
            total_price = price * quantity;
            if (this.name == nm)
            {
                if (total_all <= 0)
                {
                    total_all += total_price;
                }
                else
                {
                    total_all -= arg;
                    total_all += total_price;
                }
            }
            else
                total_all += total_price;
        }
        public void delete()
        {
            total_all -= total_price;
        }
    }
}
