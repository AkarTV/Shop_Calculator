using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shop_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = OSAppTheme.Light;
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
                Add_Product();
        }
        private void Enter_button(object sender, EventArgs e)
        {
            Add_Product();
        }
        internal void Add_Product()
        {
            if (String.IsNullOrWhiteSpace(entry.Text))
            {
                DisplayAlert("Уведомление", "Введите название товара!", "ОK");
            }
            else
            {
                View1 view = new View1(this, entry.Text);
                mainlist.Children.Add(view);
                entry.Text = string.Empty;
            }
        }
        internal void write_total()
        {
            all_total_price.Text = Product.total_all.ToString();
        }
        internal void delete_item(View1 item)
        {
            mainlist.Children.Remove(item);
        }
        private void Delete_all(object sender, EventArgs e)
        {
            mainlist.Children.Clear();
            Product.delete_all();
            write_total();
        }
    }
}
