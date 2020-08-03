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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SlotGameWorkshop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int dollars;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void buttonAddCash_Click(object sender, RoutedEventArgs e)
        {
            dollars = dollars + 10;                             // Add $10 to the total
            textBlockDollar.Text = "You have $" + dollars;      // Display the dollars
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        
        {
            imageWheel1.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png", UriKind.RelativeOrAbsolute));
            imageWheel2.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png", UriKind.RelativeOrAbsolute));
            imageWheel3.Source = new BitmapImage(new Uri("ms-appx:///Assets/win.png", UriKind.RelativeOrAbsolute));
            imageWinLose.Source = new BitmapImage(new Uri("ms-appx:///Assets/WinGame.png", UriKind.RelativeOrAbsolute));
        }
    }
}
