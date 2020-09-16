using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LumememmAppKruglov
{
    public partial class MainPage : ContentPage
    {
        private Random rnd = new Random();
        public MainPage()
        {
            InitializeComponent();
        }

        private void destroybtn_Clicked(object sender, EventArgs e)
        {
            Head.IsVisible = false;
            Body.IsVisible = false;
            Lower.IsVisible = false;
        }

        private void build_Clicked(object sender, EventArgs e)
        {
            Head.IsVisible = true;
            Body.IsVisible = true;
            Lower.IsVisible = true;
        }

        private void col_Clicked(object sender, EventArgs e)
        {
            Head.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Body.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Lower.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }
}
