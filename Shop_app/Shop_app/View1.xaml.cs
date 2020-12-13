using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shop_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class View1 : ContentView
    {
        private MainPage _ParentPage;
        Product product = new Product();
        public View1(MainPage parentPage, string name)
        {
            InitializeComponent();
            _ParentPage = parentPage;
            product.change_name(name);
            product_name.Text = name;
        }
        private void price_changed(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(product_price.Text))
                product.change_price(0);
            else
                product.change_price(Convert.ToDouble(product_price.Text));
            product.calculate_total(product.get_name(), Convert.ToDouble(total_price.Text));
            set_total();
            _ParentPage.write_total();
        }
        private void quantity_changed(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(product_quantity.Text))
                product.change_quan(0);
            else
                product.change_quan(Convert.ToInt32(product_quantity.Text));
            product.calculate_total(product.get_name(), Convert.ToDouble(total_price.Text));
            set_total();
            _ParentPage.write_total();
        }
        void set_total()
        {
            total_price.Text = Convert.ToString(product.get_total_price());
        }
        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            product.delete();
            _ParentPage.write_total();
            _ParentPage.delete_item(this);
        }
    }
}