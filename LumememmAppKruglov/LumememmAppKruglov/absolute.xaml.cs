using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LumememmAppKruglov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class absolute : ContentPage
    {
        public absolute()
        {
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();

            BoxView redBox = new BoxView { BackgroundColor = Color.Red, CornerRadius=90 };
            BoxView greenBox = new BoxView { BackgroundColor = Color.Green, CornerRadius = 90 };
            BoxView blueBox = new BoxView { BackgroundColor = Color.Blue, CornerRadius = 90 };
            BoxView blackBox = new BoxView { BackgroundColor = Color.Black, CornerRadius = 90 };
            BoxView black2Box = new BoxView { BackgroundColor = Color.Black, CornerRadius = 90 };

            AbsoluteLayout.SetLayoutBounds(redBox, new Rectangle(0.5, 0.29, 60, 60));
            AbsoluteLayout.SetLayoutFlags(redBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(greenBox, new Rectangle(0.5, 0.4, 100, 80));
            AbsoluteLayout.SetLayoutFlags(greenBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(blueBox, new Rectangle(0.5, 0.59, 0.4, 0.2));
            AbsoluteLayout.SetLayoutFlags(blueBox, AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(blackBox, new Rectangle(0.47, 0.29, 5, 5));
            AbsoluteLayout.SetLayoutFlags(blackBox, AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(black2Box, new Rectangle(0.53, 0.29, 5, 5));
            AbsoluteLayout.SetLayoutFlags(black2Box, AbsoluteLayoutFlags.PositionProportional);

            absoluteLayout.Children.Add(redBox);
            absoluteLayout.Children.Add(greenBox);
            absoluteLayout.Children.Add(blueBox);
            absoluteLayout.Children.Add(blackBox);
            absoluteLayout.Children.Add(black2Box);

            Content = absoluteLayout;
        }
    }
}