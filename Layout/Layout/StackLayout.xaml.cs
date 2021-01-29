using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayout : TabbedPage
    {
        public StackLayout()
        {
            InitializeComponent();
            var imagesource = new UriImageSource { Uri = new Uri("https://media.vov.vn/uploaded/ubmlf0ys1pg/2019_10_01/bien_3_pfgs.jpg") };
            imagesource.CachingEnabled = false;
            img.Source = imagesource;
        }
    }
}