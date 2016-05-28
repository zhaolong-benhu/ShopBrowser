using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ShopBrowser2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            bRightWebviewIsOpen = false;
            bFlag = false;
        }

        private string nowUri;
        private string leftUri;
        private string rightUri;

        private bool bRightWebviewIsOpen;

        private bool bFlag;

        private void HideHPShowUser()
        {
            Home_Page.Visibility = Visibility.Collapsed;
            Now_Page.Visibility = Visibility.Visible;
        }

        //主页选项点击事件
        private void Often_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            HideHPShowUser();

            Button  btn =  (Button)sender;
            String xName = btn.Name.ToString();
         
            if (xName == "OFTENBTN_1")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI1));
            }
            else if(xName == "OFTENBTN_2")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI2));
            }
            else if (xName == "OFTENBTN_3")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI3));
            }
            else if (xName == "OFTENBTN_4")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI4));
            }
            else if (xName == "OFTENBTN_5")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI5));
            }
            else if (xName == "OFTENBTN_6")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI6));
            }
            else if (xName == "OFTENBTN_7")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI7));
            }
            else if (xName == "OFTENBTN_8")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI8));
            }
            else if (xName == "OFTENBTN_9")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI9));
            }
            else if (xName == "OFTENBTN_10")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI10));
            }
            else if (xName == "OFTENBTN_11")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI11));
            }
            else if (xName == "OFTENBTN_12")
            {
                CommonWebView.Navigate(new Uri(ConstClass.OFTEN_URI12));
            }
            else
            {

            }
            


        }
        private void B2C_Btn_Clicked(object sender, RoutedEventArgs e)
        {

            HideHPShowUser();

            Button btn = (Button)sender;
            String xName = btn.Name.ToString();
      
            if (xName == "B2CBTN_1")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI1));
            }
            else if (xName == "B2CBTN_2")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI2));
            }
            else if (xName == "B2CBTN_3")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI3));
            }
            else if (xName == "B2CBTN_4")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI4));
            }
            else if (xName == "B2CBTN_5")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI5));
            }
            else if (xName == "B2CBTN_6")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI6));
            }
            else if (xName == "B2CBTN_7")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI7));
            }
            else if (xName == "B2CBTN_8")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI8));
            }
            else if (xName == "B2CBTN_9")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI9));
            }
            else if (xName == "B2CBTN_10")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI10));
            }
            else if (xName == "B2CBTN_11")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI11));
            }
            else if (xName == "B2CBTN_12")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI12));
            }
            else if (xName == "B2CBTN_13")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI13));
            }
            else if (xName == "B2CBTN_14")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI14));
            }
            else if (xName == "B2CBTN_15")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI15));
            }
            else if (xName == "B2CBTN_16")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI16));
            }
            else if (xName == "B2CBTN_17")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI17));
            }
            else if (xName == "B2CBTN_18")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI18));
            }
            else if (xName == "B2CBTN_19")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI19));
            }
            else if (xName == "B2CBTN_20")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI20));
            }
            else if (xName == "B2CBTN_21")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI21));
            }
            else if (xName == "B2CBTN_22")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI22));
            }
            else if (xName == "B2CBTN_23")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI23));
            }
            else if (xName == "B2CBTN_24")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI24));
            }
            else if (xName == "B2CBTN_25")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI25));
            }
            else if (xName == "B2CBTN_26")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI26));
            }
            else if (xName == "B2CBTN_27")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI27));
            }
            else if (xName == "B2CBTN_28")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI28));
            }
            else if (xName == "B2CBTN_29")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI29));
            }
            else if (xName == "B2CBTN_30")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI30));
            }
            else if (xName == "B2CBTN_31")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI31));
            }
            else if (xName == "B2CBTN_32")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI32));
            }
            else if (xName == "B2CBTN_33")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI33));
            }
            else if (xName == "B2CBTN_34")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI34));
            }
            else if (xName == "B2CBTN_35")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI35));
            }
            else if (xName == "B2CBTN_36")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI36));
            }
            else if (xName == "B2CBTN_37")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI37));
            }
            else if (xName == "B2CBTN_38")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI38));
            }
            else if (xName == "B2CBTN_39")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI39));
            }
            else if (xName == "B2CBTN_40")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI40));
            }
            else if (xName == "B2CBTN_41")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI41));
            }
            else if (xName == "B2CBTN_42")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI42));
            }
            else if (xName == "B2CBTN_43")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI43));
            }
            else if (xName == "B2CBTN_44")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI44));
            }
            else if (xName == "B2CBTN_45")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI45));
            }
            else if (xName == "B2CBTN_46")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI46));
            }
            else if (xName == "B2CBTN_47")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI47));
            }
            else if (xName == "B2CBTN_48")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI48));
            }
            else if (xName == "B2CBTN_49")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI49));
            }
            else if (xName == "B2CBTN_50")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI50));
            }
            else if (xName == "B2CBTN_51")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI51));
            }
            else if (xName == "B2CBTN_52")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI52));
            }
            else if (xName == "B2CBTN_53")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI53));
            }
            else if (xName == "B2CBTN_54")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI54));
            }
            else if (xName == "B2CBTN_55")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI55));
            }
            else if (xName == "B2CBTN_56")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI56));
            }
            else if (xName == "B2CBTN_57")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI57));
            }
            else if (xName == "B2CBTN_58")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI58));
            }
            else if (xName == "B2CBTN_59")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI59));
            }
            else if (xName == "B2CBTN_60")
            {
                CommonWebView.Navigate(new Uri(ConstClass.B2C_URI60));
            }
            else
            {

            }
        }
        private void HaiTao_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            HideHPShowUser();

            Button btn = (Button)sender;
            String xName = btn.Name.ToString();

            if (xName == "HAITAO_URI1")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI1));
            }
            else if (xName == "HAITAO_URI2")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI2));
            }
            else if (xName == "HAITAO_URI3")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI3));
            }
            else if (xName == "HAITAO_URI4")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI4));
            }
            else if (xName == "HAITAO_URI5")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI5));
            }
            else if (xName == "HAITAO_URI6")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI6));
            }
            else if (xName == "HAITAO_URI7")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI7));
            }
            else if (xName == "HAITAO_URI8")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI8));
            }
            else if (xName == "HAITAO_URI9")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI9));
            }
            else if (xName == "HAITAO_URI10")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI10));
            }
            else if (xName == "HAITAO_URI11")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI11));
            }
            else if (xName == "HAITAO_URI12")
            {
                CommonWebView.Navigate(new Uri(ConstClass.HAITAO_URI12));
            }
            else
            {

            }
        }
        private void YouHuiQuan_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            HideHPShowUser();

            Button btn = (Button)sender;
            String xName = btn.Name.ToString();

            if (xName == "YOUHUIQUANBTN_1")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI1));
            }
            else if (xName == "YOUHUIQUANBTN_2")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI2));
            }
            else if (xName == "YOUHUIQUANBTN_3")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI3));
            }
            else if (xName == "YOUHUIQUANBTN_4")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI4));
            }
            else if (xName == "YOUHUIQUANBTN_5")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI5));
            }
            else if (xName == "YOUHUIQUANBTN_6")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI6));
            }
            else if (xName == "YOUHUIQUANBTN_7")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI7));
            }
            else if (xName == "YOUHUIQUANBTN_8")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI8));
            }
            else if (xName == "YOUHUIQUANBTN_9")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI9));
            }
            else if (xName == "YOUHUIQUANBTN_10")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI10));
            }
            else if (xName == "YOUHUIQUANBTN_11")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI12));
            }
            else if (xName == "YOUHUIQUANBTN_12")
            {
                CommonWebView.Navigate(new Uri(ConstClass.YOUHUIQUAN_URI12));
            }
            else
            {

            }
        }


        //主页选项鼠标Hover事件
        private void Often_Btn_Hover(Object sender, RoutedEventArgs e)
        {
            Button  btn = (Button) sender;
            string xName = btn.Name.ToString();

            ImageBrush  imgBrush =  new ImageBrush();

            if (xName == "OFTENBTN_1")
            {
                imgBrush.ImageSource =  new BitmapImage(new Uri("ms-appx:///Assets/Hot1_1.png"));
            }
            else if (xName == "OFTENBTN_2")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot2_1.png"));
            }
            else if (xName == "OFTENBTN_3")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot3_1.png"));
            }
            else if (xName == "OFTENBTN_4")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot4_1.png"));
            }
            else if (xName == "OFTENBTN_5")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot5_1.png"));
            }
            else if (xName == "OFTENBTN_6")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot6_1.png"));
            }
            else if (xName == "OFTENBTN_7")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot7_1.png"));
            }
            else if (xName == "OFTENBTN_8")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot8_1.png"));
            }
            else if (xName == "OFTENBTN_9")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot9_1.png"));
            }
            else if (xName == "OFTENBTN_10")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot10_1.png"));
            }
            else if (xName == "OFTENBTN_11")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot11_1.png"));
            }
            else if (xName == "OFTENBTN_12")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot12_1.png"));
            }
            else
            {

            }
            btn.Background = imgBrush;

        }
        private void B2C_Btn_Hover(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string xName = btn.Name.ToString();

            ImageBrush imgBrush = new ImageBrush();

            if (xName == "B2CBTN_1")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/1_1.png"));
            }
            else if (xName == "B2CBTN_2")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/2_1.png"));
            }
            else if (xName == "B2CBTN_3")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/3_1.png"));
            }
            else if (xName == "B2CBTN_4")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/4_1.png"));
            }
            else if (xName == "B2CBTN_5")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/5_1.png"));
            }
            else if (xName == "B2CBTN_6")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/6_1.png"));
            }
            else if (xName == "B2CBTN_7")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/7_1.png"));
            }
            else if (xName == "B2CBTN_8")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/8_1.png"));
            }
            else if (xName == "B2CBTN_9")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/9_1.png"));
            }
            else if (xName == "B2CBTN_10")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/10_1.png"));
            }
            else if (xName == "B2CBTN_11")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/11_1.png"));
            }
            else if (xName == "B2CBTN_12")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/12_1.png"));
            }
            else if (xName == "B2CBTN_13")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/13_1.png"));
            }
            else if (xName == "B2CBTN_14")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/14_1.png"));
            }
            else if (xName == "B2CBTN_15")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/15_1.png"));
            }
            else if (xName == "B2CBTN_16")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/16_1.png"));
            }
            else if (xName == "B2CBTN_17")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/17_1.png"));
            }
            else if (xName == "B2CBTN_18")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/18_1.png"));
            }
            else if (xName == "B2CBTN_19")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/19_1.png"));
            }
            else if (xName == "B2CBTN_20")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/20_1.png"));
            }
            else if (xName == "B2CBTN_21")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/21_1.png"));
            }
            else if (xName == "B2CBTN_22")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/22_1.png"));
            }
            else if (xName == "B2CBTN_23")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/23_1.png"));
            }
            else if (xName == "B2CBTN_24")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/24_1.png"));
            }
            else if (xName == "B2CBTN_25")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/25_1.png"));
            }
            else if (xName == "B2CBTN_26")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/26_1.png"));
            }
            else if (xName == "B2CBTN_27")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/27_1.png"));
            }
            else if (xName == "B2CBTN_28")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/28_1.png"));
            }
            else if (xName == "B2CBTN_29")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/29_1.png"));
            }
            else if (xName == "B2CBTN_30")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/30_1.png"));
            }
            else if (xName == "B2CBTN_31")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/31_1.png"));
            }
            else if (xName == "B2CBTN_32")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/32_1.png"));
            }
            else if (xName == "B2CBTN_33")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/33_1.png"));
            }
            else if (xName == "B2CBTN_34")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/34_1.png"));
            }
            else if (xName == "B2CBTN_35")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/35_1.png"));
            }
            else if (xName == "B2CBTN_36")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/36_1.png"));
            }
            else
            {

            }
            btn.Background = imgBrush;
        }
        private void HaiTao_Btn_Hover(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string xName = btn.Name.ToString();

            ImageBrush imgBrush = new ImageBrush();

            if (xName == "HAITAOBTN_1")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO1_1.png"));
            }
            else if (xName == "HAITAOBTN_2")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO2_1.png"));
            }
            else if (xName == "HAITAOBTN_3")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO3_1.png"));
            }
            else if (xName == "HAITAOBTN_4")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO4_1.png"));
            }
            else if (xName == "HAITAOBTN_5")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO5_1.png"));
            }
            else if (xName == "HAITAOBTN_6")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO6_1.png"));
            }
            else if (xName == "HAITAOBTN_7")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO7_1.png"));
            }
            else if (xName == "HAITAOBTN_8")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO8_1.png"));
            }
            else if (xName == "HAITAOBTN_9")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO9_1.png"));
            }
            else if (xName == "HAITAOBTN_10")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO10_1.png"));
            }
            else if (xName == "HAITAOBTN_11")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO11_1.png"));
            }
            else if (xName == "HAITAOBTN_12")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO12_1.png"));
            }
            else
            {

            }
            btn.Background = imgBrush;
        }
        private void YouHuiQuan_Btn_Hover(Object sender, RoutedEventArgs e)
        {


            Button btn = (Button)sender;
            string xName = btn.Name.ToString();

            ImageBrush imgBrush = new ImageBrush();

            if (xName == "YOUHUIQUANBTN_1")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN1_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_2")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN2_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_3")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN3_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_4")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN4_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_5")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN5_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_6")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN6_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_7")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN7_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_8")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN8_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_9")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN9_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_10")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN10_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_11")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN11_1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_12")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN12_1.png"));
            }
            else
            {

            }
            btn.Background = imgBrush;
        }


        //主页选项鼠标Leave事件
        private void Often_Btn_Leave(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string xName = btn.Name.ToString();

            ImageBrush imgBrush = new ImageBrush();

            if (xName == "OFTENBTN_1")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot1.png"));
            }
            else if (xName == "OFTENBTN_2")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot2.png"));
            }
            else if (xName == "OFTENBTN_3")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot3.png"));
            }
            else if (xName == "OFTENBTN_4")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot4.png"));
            }
            else if (xName == "OFTENBTN_5")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot5.png"));
            }
            else if (xName == "OFTENBTN_6")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot6.png"));
            }
            else if (xName == "OFTENBTN_7")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot7.png"));
            }
            else if (xName == "OFTENBTN_8")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot8.png"));
            }
            else if (xName == "OFTENBTN_9")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot9.png"));
            }
            else if (xName == "OFTENBTN_10")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot10.png"));
            }
            else if (xName == "OFTENBTN_11")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot11.png"));
            }
            else if (xName == "OFTENBTN_12")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/Hot12.png"));
            }
            else
            {

            }
            btn.Background = imgBrush;
        }
        private void B2C_Btn_Leave(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string xName = btn.Name.ToString();

            ImageBrush imgBrush = new ImageBrush();

            if (xName == "B2CBTN_1")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/1.png"));
            }
            else if (xName == "B2CBTN_2")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/2.png"));
            }
            else if (xName == "B2CBTN_3")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/3.png"));
            }
            else if (xName == "B2CBTN_4")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/4.png"));
            }
            else if (xName == "B2CBTN_5")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/5.png"));
            }
            else if (xName == "B2CBTN_6")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/6.png"));
            }
            else if (xName == "B2CBTN_7")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/7.png"));
            }
            else if (xName == "B2CBTN_8")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/8.png"));
            }
            else if (xName == "B2CBTN_9")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/9.png"));
            }
            else if (xName == "B2CBTN_10")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/10.png"));
            }
            else if (xName == "B2CBTN_11")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/11.png"));
            }
            else if (xName == "B2CBTN_12")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/12.png"));
            }
            else if (xName == "B2CBTN_13")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/13.png"));
            }
            else if (xName == "B2CBTN_14")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/14.png"));
            }
            else if (xName == "B2CBTN_15")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/15.png"));
            }
            else if (xName == "B2CBTN_16")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/16.png"));
            }
            else if (xName == "B2CBTN_17")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/17.png"));
            }
            else if (xName == "B2CBTN_18")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/18.png"));
            }
            else if (xName == "B2CBTN_19")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/19.png"));
            }
            else if (xName == "B2CBTN_20")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/20.png"));
            }
            else if (xName == "B2CBTN_21")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/21.png"));
            }
            else if (xName == "B2CBTN_22")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/22.png"));
            }
            else if (xName == "B2CBTN_23")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/23.png"));
            }
            else if (xName == "B2CBTN_24")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/24.png"));
            }
            else if (xName == "B2CBTN_25")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/25.png"));
            }
            else if (xName == "B2CBTN_26")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/26.png"));
            }
            else if (xName == "B2CBTN_27")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/27.png"));
            }
            else if (xName == "B2CBTN_28")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/28.png"));
            }
            else if (xName == "B2CBTN_29")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/29.png"));
            }
            else if (xName == "B2CBTN_30")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/30.png"));
            }
            else if (xName == "B2CBTN_31")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/31.png"));
            }
            else if (xName == "B2CBTN_32")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/32.png"));
            }
            else if (xName == "B2CBTN_33")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/33.png"));
            }
            else if (xName == "B2CBTN_34")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/34.png"));
            }
            else if (xName == "B2CBTN_35")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/35.png"));
            }
            else if (xName == "B2CBTN_36")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/36.png"));
            }
            else
            {

            }
            btn.Background = imgBrush;
        }
        void HaiTao_Btn_Leave(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string xName = btn.Name.ToString();

            ImageBrush imgBrush = new ImageBrush();

            if (xName == "HAITAOBTN_1")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO1.png"));
            }
            else if (xName == "HAITAOBTN_2")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO2.png"));
            }
            else if (xName == "HAITAOBTN_3")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO3.png"));
            }
            else if (xName == "HAITAOBTN_4")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO4.png"));
            }
            else if (xName == "HAITAOBTN_5")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO5.png"));
            }
            else if (xName == "HAITAOBTN_6")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO6.png"));
            }
            else if (xName == "HAITAOBTN_7")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO7.png"));
            }
            else if (xName == "HAITAOBTN_8")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO8.png"));
            }
            else if (xName == "HAITAOBTN_9")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO9.png"));
            }
            else if (xName == "HAITAOBTN_10")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO10.png"));
            }
            else if (xName == "HAITAOBTN_11")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO11.png"));
            }
            else if (xName == "HAITAOBTN_12")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/HAITAO12_12.png"));
            }
            else
            {

            }
            btn.Background = imgBrush;
        }
        private void YouHuiQuan_Btn_Leave(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string xName = btn.Name.ToString();

            ImageBrush imgBrush = new ImageBrush();

            if (xName == "YOUHUIQUANBTN_1")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN1.png"));
            }
            else if (xName == "YOUHUIQUANBTN_2")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN2.png"));
            }
            else if (xName == "YOUHUIQUANBTN_3")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN3.png"));
            }
            else if (xName == "YOUHUIQUANBTN_4")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN4.png"));
            }
            else if (xName == "YOUHUIQUANBTN_5")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN5.png"));
            }
            else if (xName == "YOUHUIQUANBTN_6")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN6.png"));
            }
            else if (xName == "YOUHUIQUANBTN_7")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN7.png"));
            }
            else if (xName == "YOUHUIQUANBTN_8")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN8.png"));
            }
            else if (xName == "YOUHUIQUANBTN_9")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN9.png"));
            }
            else if (xName == "YOUHUIQUANBTN_10")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN10.png"));
            }
            else if (xName == "YOUHUIQUANBTN_11")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN11.png"));
            }
            else if (xName == "YOUHUIQUANBTN_12")
            {
                imgBrush.ImageSource = new BitmapImage(new Uri("ms-appx:///Assets/YOUHUIQUAN12.png"));
            }
            else
            {

            }
            btn.Background = imgBrush;
        }


        //超链接消息处理
        private void HpperLink1(Object sender, RoutedEventArgs e)
        {

        }

        //Option选择按钮消息处理
        //返回首页
        void ClickedToBack(Object sender, RoutedEventArgs e)
        {
            //需要判断能否后退 
            if (CommonWebView.CanGoBack)
            {
                CommonWebView.GoBack();
            }
            else
            {
                Now_Page.Visibility = Visibility.Collapsed;
                Home_Page.Visibility = Visibility.Visible;
            }
        }
        //双屏
        void ClickedTwoScreen(Object sender, RoutedEventArgs e)
        {
            Now_Page.Visibility = Visibility.Collapsed;
            Double_Page.Visibility = Visibility.Visible;


            Uri  Left_uri =  new Uri(leftUri);
            LeftWebView.Navigate(Left_uri);

            if (!bRightWebviewIsOpen)
            {
                Uri  Right_uri =  new Uri(leftUri);
                RightWebView.Navigate(Right_uri);
            }
            else
            {
                Uri Right_uri =  new Uri(rightUri);
                RightWebView.Navigate(Right_uri);
            }
        }
        //刷新
        private void ClickedReFresh(Object sender, RoutedEventArgs e)
        {
            CommonWebView.Refresh();

        }
        //首页
        private void ClickedToHomePage(Object sender, RoutedEventArgs e)
        {
            Home_Page.Visibility = Visibility.Visible;
            Now_Page.Visibility = Visibility.Collapsed;
            Double_Page.Visibility = Visibility.Collapsed;
        }
        //返回首页
        private void ClickedToBack2(Object sender, RoutedEventArgs e)
        {
            if (LeftWebView.CanGoBack)
            {
                LeftWebView.GoBack();
            }
        }
        //双屏
        private void ClickedTwoScreen2(Object sender, RoutedEventArgs e)
        {
            Now_Page.Visibility = Visibility.Visible;
            Double_Page.Visibility = Visibility.Collapsed;

            Uri  CurentUri =  new Uri(nowUri);
            CommonWebView.Navigate(CurentUri);
        }
        //刷新
        private void ClickedReFresh2(Object sender, RoutedEventArgs e)
        {
            LeftWebView.Refresh();

        }
        //首页
        private void ClickedToHomePage2(Object sender, RoutedEventArgs e)
        {
            Home_Page.Visibility = Visibility.Visible;
            Now_Page.Visibility = Visibility.Collapsed;
            Double_Page.Visibility = Visibility.Collapsed;
        }

        //返回首页
        private void ClickedToBack3(Object sender, RoutedEventArgs e)
        {
         
            if (RightWebView.CanGoBack)
            {
                RightWebView.GoBack();
            }
        }
        //双屏同步
        private void ClickedTwoScreen3(Object sender, RoutedEventArgs e)
        {
            Uri  Right_uri =  new Uri(nowUri);
            RightWebView.Navigate(Right_uri);
        }

        /**************************************
        ********对WebView相关属性设置***********	
        **************************************/
        //打开新的浏览页面请求																				  
        void CommonWebView_NewWindowRequested(WebView sender, WebViewNewWindowRequestedEventArgs args)	
        {
            sender.Navigate(args.Uri);
            args.Handled = true;
        }
       

        private void CommonWebView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            CommonRing.IsActive = true;

            nowUri = args.Uri.ToString();
            leftUri = nowUri;
        }

        private void CommonWebView_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            CommonRing.IsActive = false;

            nowUri = args.Uri.ToString();
        }

        private void CommonWebView_NavigationStarting2(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            LeftRing.IsActive = true;
            leftUri = args.Uri.ToString();
        }

        private void CommonWebView_NavigationCompleted2(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            LeftRing.IsActive = false;
            leftUri = args.Uri.ToString();
        }

        private void CommonWebView_NavigationStarting3(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            RightRing.IsActive = true;
            rightUri = args.Uri.ToString();
            bRightWebviewIsOpen = true;
        }

        private void CommonWebView_NavigationCompleted3(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            RightRing.IsActive = false;
            rightUri = args.Uri.ToString();
            bRightWebviewIsOpen = true;
        }

       
      
    }


}
