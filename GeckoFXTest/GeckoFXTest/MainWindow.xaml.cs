using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Gecko;

namespace GeckoFXTest
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Xpcom.Initialize("Firefox");
            GeckoWebBrowser geckoWebBrowser = new GeckoWebBrowser();
            geckoWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            geckoWebBrowser.Width = 800;
            geckoWebBrowser.Height = 600;
            //geckoWebBrowser.Location = new System.Drawing.Point(0, 50);
            geckoWebBrowser.Navigate("http://www.yahoo.co.jp");
            windowsFormsHost.Child = geckoWebBrowser;
            
        }
    }
}
