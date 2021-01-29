using Bai068.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bai068
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity : ContentPage
    {
        public Activity()
        {
            InitializeComponent();

            list.ItemsSource = new List<Hoatdong>
            {
                new Hoatdong { UserId = 1, Description = "Your Facebook friend Jenny Dalby is on Instagram.",Name="Jenny Dalby",ImageUrl="https://img.thuthuatphanmem.vn/uploads/2018/10/09/anh-bien-thien-nhien-dep-nhat-the-gioi_041753368.jpg" },
                new Hoatdong { UserId = 2, Description = "Jonv started following you",Name = "Jonv",ImageUrl="https://img.thuthuatphanmem.vn/uploads/2018/10/09/anh-dep-nhat-the-gioi-trong-tu-nhien_041753399.jpg" },
                new Hoatdong { UserId = 3, Description = "RachelMartin liked your photo.",Name = "RachelMartin",ImageUrl="https://img.thuthuatphanmem.vn/uploads/2018/10/09/anh-dep-nhat-the-gioi-ve-thien-nhien_041753462.jpg" },
                new Hoatdong { UserId = 4, Description = "Your Facebook friend Nivan Jay is on Instagram.",Name = "Nivan Jay",ImageUrl="https://img.thuthuatphanmem.vn/uploads/2018/10/09/anh-dep-nhat-trong-thien-nhien_041753509.jpg" },
                new Hoatdong { UserId = 5, Description = "SanazZ sent a photo posted by @brookeisep.",Name = "SanazZ",ImageUrl="https://img.thuthuatphanmem.vn/uploads/2018/10/09/anh-phong-canh-thien-nhien-dep-nhat_041753602.jpg" },
                new Hoatdong { UserId = 6, Description = "NextLab started following you.", Name = "NextLab",ImageUrl="https://img.thuthuatphanmem.vn/uploads/2018/10/09/anh-thien-nhien-bang-gia-dep-nhat-the-gioi_041753634.jpg" },
                new Hoatdong { UserId = 7, Description = "Your Facebook friend Alex B is on Instagram.",Name = "AlexB",ImageUrl="https://img.thuthuatphanmem.vn/uploads/2018/10/09/anh-thien-nhien-bien-dep-nhat-the-gioi_041753649.jpg" },
                new Hoatdong { UserId = 8, Description = "Your Facebook friend Tara Chang is on Instagram.", Name = "Tara Chang",ImageUrl="https://img.thuthuatphanmem.vn/uploads/2018/10/09/anh-thien-nhien-cuc-dep_041753727.jpg" },
               
            };
        }

        private void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var chitiet = e.SelectedItem as Hoatdong;
            Navigation.PushAsync(new Details(chitiet));
        }
    }
}