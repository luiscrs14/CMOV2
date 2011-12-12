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
using Microsoft.Phone.Shell;

namespace PhoneImage
{
    public partial class EntryPage : PhoneApplicationPage
    {
        public EntryPage()
        {
            InitializeComponent();
            StandardTileData sd = new StandardTileData
            {
                Title = "Property Viewer",
                BackgroundImage = new Uri("Background.png", UriKind.Relative),
                Count = 0
            };
            
            ShellTile st = ShellTile.ActiveTiles.ElementAt(0);
            MessageBox.Show(ShellTile.ActiveTiles.Count().ToString());
            st.Update(sd);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //reset dos descartados
        }


    }
}