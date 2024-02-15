using Microsoft.UI.Xaml.Controls;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        WebView2 wv;
        public MainPage()
        {
            wv = new WebView2()
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Width = 500,
                Height = 500,
            };

            this.InitializeComponent();

            this.Loaded += async (s, e) => 
            {
                await wv.EnsureCoreWebView2Async();
                var url = new Uri("https://www.seznam.cz");
                wv.Source = url;

                wv.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;
                wv.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;
                grd.Children.Add(wv);
            };
        }
    }
}
