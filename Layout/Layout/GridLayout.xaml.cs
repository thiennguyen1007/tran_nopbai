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
    public partial class GridLayout : ContentPage
    {
        public GridLayout()
        {
            InitializeComponent();
        }
        private void ButtonCong(object sender, EventArgs e)
        {
            lblhienthi.Text += '+';



        }
        private void ButtonTru(object sender, EventArgs e)
        {
            lblhienthi.Text += '-';
        }
        private void ButtonNhan(object sender, EventArgs e)
        {
            lblhienthi.Text += 'X';
        }
        private void ButtonChia(object sender, EventArgs e)
        {
            lblhienthi.Text += '/';
        }

        private void N1_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 1;
        }

        private void N2_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 2;
        }

        private void N3_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 3;
        }

        private void N4_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 4;
        }

        private void N5_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 5;
        }

        private void N6_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 6;
        }

        private void N7_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 7;
        }

        private void N8_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 8;
        }

        private void N9_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 9;
        }

        private void N0_Clicked(object sender, EventArgs e)
        {
            lblhienthi.Text += 0;
        }

        private void ButtonTinh(object sender, EventArgs e)
        {

            string tt = lblhienthi.Text;
            //tính phép cộng
            if (tt.Contains('+'))
            {
                if (tt.Split('+').Length == 2)
                {
                    string[] number = tt.Split('+');
                    try
                    {

                        var sohang1 = double.TryParse(number[0], out double sh1);
                        var sohang2 = double.TryParse(number[1], out double sh2);
                        double kq = sh1 * sh2;

                        lblhienthi.Text = kq + "";
                    }
                    catch
                    {
                        Console.WriteLine("lỗi nhập dữ liệu");
                    }
                }
            }
            //tính phép chia
            if (tt.Contains('/'))
            {
                if (tt.Split('/').Length == 2)
                {
                    string[] number = tt.Split('/');
                    try
                    {

                        var sohang1 = double.TryParse(number[0], out double sh1);
                        var sohang2 = double.TryParse(number[1], out double sh2);
                        double kq = sh1 / sh2;

                        lblhienthi.Text = kq.ToString();
                    }
                    catch
                    {
                        lblhienthi.Text = "không có phép chia cho 0";
                    }
                }
            }
            ////tính phép nhân
            //if (tt.Contains('X'))
            //{
            //    if (tt.Split('X').Length == 2)
            //    {
            //        string[] number = tt.Split('X');
            //        try
            //        {

            //            double sh1 = Single.Parse(number[0]);
            //            double sh2 = Single.Parse(number[1]);
            //            double kq = sh1 * sh2;

            //            lblhienthi.Text = kq + "";
            //        }
            //        catch
            //        {
            //            Console.WriteLine("Đã có lỗi xảy ra");
            //        }
            //    }

            //}

            //tinhs phep nhan 2
            if (tt.Contains('X'))
            {
                double kq = 1;
                string[] dscacsohang = tt.Split('X');
                int d = dscacsohang.Length;
                for (int i = 0; i < d; i++)
                {
                    double[] demsh = new double[d];
                    demsh[i] = double.Parse(dscacsohang[i]);
                    double tg = demsh[i];
                    kq = kq * demsh[i];
                }

                lblhienthi.Text = kq.ToString();
            }


            //tính phép trừ
            if (tt.Contains('-'))
            {
                if (tt.Split('-').Length == 2)
                {
                    string[] number = tt.Split('-');
                    try
                    {

                        var sohang1 = double.TryParse(number[0], out double sh1);
                        var sohang2 = double.TryParse(number[1], out double sh2);
                        double kq = sh1 - sh2;

                        lblhienthi.Text = kq + "";
                    }
                    catch
                    {
                        Console.WriteLine("Đã có lỗi xảy ra");
                    }
                }
            }
        }
        private void ButtonAC(object sender, EventArgs e)
        {
            lblhienthi.Text = "";
        }
    }
}