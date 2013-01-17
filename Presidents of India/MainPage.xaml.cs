using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;

namespace Presidents_of_India
{
    public partial class MainPage : PhoneApplicationPage
    {
        double a;
        // Constructor
        public MainPage()
        { 
            InitializeComponent();
            slider1.ValueChanged +=new RoutedPropertyChangedEventHandler<double>(slider1_ValueChanged);

            
            
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (textBlock4 != null)
            {
                
            
            
            a =Math.Round(slider1.Value);
            switch(Convert.ToInt32(a))
            { case 1950: textBlock4.Text = "Rajendra Prasad (1950-1962)";
                    Uri uri1 = new Uri("/Presidents of India;component/images/rp.jpg", UriKind.Relative);
            BitmapImage imgSource1 = new BitmapImage(uri1);
            this.image1.Source = imgSource1;
            button1.Content = "1";
                    break;
            case 1962: textBlock4.Text = "Sarvepalli RadhaKrishnan(1962-1967)";
                    Uri uri2 = new Uri("/Presidents of India;component/images/rk.jpg", UriKind.Relative);
            BitmapImage imgSource2 = new BitmapImage(uri2);
            this.image1.Source = imgSource2;
            button1.Content = "2";
                   break;
            case 1967: textBlock4.Text = "Zakir Hussain (1967-1969)";
                    Uri uri3 = new Uri("/Presidents of India;component/images/zk.jpg", UriKind.Relative);
            BitmapImage imgSource3 = new BitmapImage(uri3);
            this.image1.Source = imgSource3;
            button1.Content = "3";
                    break;
            case 1969: textBlock4.Text = " V V Giri (1969 -1974) ";
                    Uri uri4 = new Uri("/Presidents of India;component/images/vvg.jpg", UriKind.Relative);
            BitmapImage imgSource4 = new BitmapImage(uri4);
            this.image1.Source = imgSource4;
            button1.Content = "4";
                    break;
            case 1974: textBlock4.Text = "Fakhruddin Ali Ahmed (1974- 1977) ";
                    Uri uri5 = new Uri("/Presidents of India;component/images/faa.jpg", UriKind.Relative);
            BitmapImage imgSource5 = new BitmapImage(uri5);
            this.image1.Source = imgSource5;
            button1.Content = "5";
                    break;
            case 1977: textBlock4.Text = "Neelam Sanjiva Reddy (1977-1982) ";
                    Uri uri6 = new Uri("/Presidents of India;component/images/nsr.jpg", UriKind.Relative);
            BitmapImage imgSource6 = new BitmapImage(uri6);
            this.image1.Source = imgSource6;
            button1.Content = "6";
                    break;
            case 1982: textBlock4.Text = "Giani Zail Singh (1982- 1987) ";
                    Uri uri7 = new Uri("/Presidents of India;component/images/gzs.jpg", UriKind.Relative);
            BitmapImage imgSource7 = new BitmapImage(uri7);
            this.image1.Source = imgSource7;
            button1.Content = "7";
                    break;
            case 1987: textBlock4.Text = "Ramaswamy Venkataraman (1987- 1992) ";
                    Uri uri8 = new Uri("/Presidents of India;component/images/rvk.jpg", UriKind.Relative);
            BitmapImage imgSource8 = new BitmapImage(uri8);
            this.image1.Source = imgSource8;
            button1.Content = "8";
                    break;
            case 1992: textBlock4.Text = "Shankar Dayal Sharma (1992-1997) ";
                Uri uri9 = new Uri("/Presidents of India;component/images/sds.jpg", UriKind.Relative);
            BitmapImage imgSource9 = new BitmapImage(uri9);
            this.image1.Source = imgSource9;
            button1.Content = "9";
                    break;
            case 1997:textBlock4.Text="K R Narayanan (1997-2002)";
                    Uri uri10 = new Uri("/Presidents of India;component/images/krn.jpg", UriKind.Relative);
            BitmapImage imgSource10 = new BitmapImage(uri10);
            this.image1.Source = imgSource10;
            button1.Content = "10";
                    break;
            case 2002: textBlock4.Text = "APJ Abdul Kalam (2002-2007) ";
                    Uri uri11 = new Uri("/Presidents of India;component/images/apj.jpg", UriKind.Relative);
            BitmapImage imgSource11 = new BitmapImage(uri11);
            this.image1.Source = imgSource11;
            button1.Content = "11";
                   break;
            case 2007: textBlock4.Text = "Pratibha Patil (2007-2012)";
                    Uri uri12 = new Uri("/Presidents of India;component/images/pp.jpg", UriKind.Relative);
            BitmapImage imgSource12 = new BitmapImage(uri12);
            this.image1.Source = imgSource12;
            button1.Content = "12";
                    break;
            case 2012: textBlock4.Text = "Pranab Mukherjee (2012 - present)";
                    Uri uri13 = new Uri("/Presidents of India;component/images/pbm.jpg", UriKind.Relative);
            BitmapImage imgSource13 = new BitmapImage(uri13);
            this.image1.Source = imgSource13;
            button1.Content = "13";
                    break;
                default :
                    break;
            }
            }
            
            
            
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
          NavigationService.Navigate(new Uri(string.Format("/Page1.xaml?s={0}",button1.Content), UriKind.Relative));
                    
        }

        
        
    }
}