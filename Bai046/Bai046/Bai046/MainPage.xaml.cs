using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Bai046
{
    public partial class MainPage : ContentPage
    {
        private int id = 1;
        public MainPage()
        {
            id = 1;
            InitializeComponent();
            ImageLoad();
        }

        private void ImageLoad()
        {

            anh.Source = ImageSource.FromResource(String.Format("Bai046.MyImage.picture_{0}.jpg",id));
        }

        private void Previous_Clicked(object sender, EventArgs e)
        {
            id--;
            if (id == 0)
            {
                id = 8;
            }
            ImageLoad();
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            id++;
            if (id == 9)
            {
                id = 1;
            }
            ImageLoad();
        }
    }
}
