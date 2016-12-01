using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WebBrowsers
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SetRegistryKey.Init();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // WPFのWebBrowserでJavaScriptのエラーのポップアップを抑止する
            // http://qiita.com/hbsnow/items/3b92775c75b8a6dc171f
            System.Reflection.PropertyInfo axIWebBrowser2 = typeof(WebBrowser).GetProperty("AxIWebBrowser2", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            object comObj = axIWebBrowser2.GetValue(webBrowser, null);
            // JavaScriptのエラー表示を抑止する
            comObj.GetType().InvokeMember("Silent", System.Reflection.BindingFlags.SetProperty, null, comObj, new object[] { true });

            chromiumWebBrowser.Rendering += ChromiumWebBrowser_Rendering;
            
            eoWebControl.WebView.UrlChanged += WebView_UrlChanged;

            setURI();
        }

        private void setURI()
        {
            string uriString = textBox.Text;
            webBrowser.Source = new Uri(uriString);
            chromiumWebBrowser.Address = uriString;
            eoWebControl.WebView.Url = uriString;
        }

        private void webBrowser_Navigated(object sender, NavigationEventArgs e)
        {
            webBrowserTextBlock.Text = "WebBrowser " + e.Uri.AbsoluteUri;
        }

        private void ChromiumWebBrowser_Rendering(object sender, CefSharp.Wpf.RenderingEventArgs e)
        {
            chromiumWebBrowserTextBlock.Text = "ChromiumWebBrowser " + chromiumWebBrowser.Address;
        }

        private void WebView_UrlChanged(object sender, EventArgs e)
        {
            eoWebControlTextBlock.Text = "EO.WebBrowser " + eoWebControl.WebView.Url;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetRegistryKey.Closing();
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                setURI();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "http://www.yahoo.co.jp";
            setURI();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text = "http://cgi.b4iine.net/env/";
            setURI();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox.Text = "http://www.mztm.jp";
            setURI();
        }
    }
}
