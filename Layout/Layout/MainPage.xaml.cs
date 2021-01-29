using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
       async private void Stack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayout());
        }

       async private void Grid_Cliked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayout());
        }

        async private void Absolute_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayout());
        }
    }
}
