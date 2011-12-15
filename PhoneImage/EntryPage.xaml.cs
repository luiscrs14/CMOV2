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
using PhoneImage.ImageReference;
using Microsoft.Phone.Notification;
using System.Diagnostics;
using System.IO;

namespace PhoneImage
{
    public partial class EntryPage : PhoneApplicationPage
    {
        ImageServiceClient client;
        Uri channelUri;
        HttpNotificationChannel httpChannel = null;
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
            st.Update(sd);
            client = new ImageServiceClient();

            string channelName = "ChannelName";
            httpChannel = HttpNotificationChannel.Find(channelName);
            if (httpChannel != null)
            {
                channelUri = httpChannel.ChannelUri;
                client.SetUrlAsync(channelUri);
            }
            else
            {
                httpChannel = new HttpNotificationChannel(channelName);
                httpChannel.ErrorOccurred += OnErrorOccurred;
                httpChannel.Open();
                channelUri = httpChannel.ChannelUri;

            }
            httpChannel.ChannelUriUpdated += OnChannelUriUpdated;
            client.resetCompleted += OnResetCompleted;
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Uri("/MainPage.xaml?uri=" + channelUri.AbsoluteUri, UriKind.Relative));
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            //reset dos descartados
            client.resetAsync(channelUri);
        }

        
        void OnResetCompleted(object sender, resetCompletedEventArgs e)
        {
            if (e.Result == true)
                MessageBox.Show("Reset successful");
            else
                MessageBox.Show("No houses to reset");
        }


        void OnChannelUriUpdated(object sender, NotificationChannelUriEventArgs e)
        {
            channelUri = e.ChannelUri;
            
            httpChannel.BindToShellTile();
            httpChannel.BindToShellToast();

            httpChannel.HttpNotificationReceived += OnHttpNotification;
            httpChannel.ShellToastNotificationReceived += OnToastNotification;

        }
        void OnErrorOccurred(object sender, NotificationChannelErrorEventArgs e)
        {
            MessageBox.Show("Error connecting to MPNS");
            Debug.WriteLine("Error on communication with MPNS");
        }

        void OnToastNotification(object sender, NotificationEventArgs e)
        {
            if (e.Collection != null)
            {
                Dictionary<string, string> collection = (Dictionary<string, string>)e.Collection;
                foreach (string elementName in collection.Keys)
                {
                    Debug.WriteLine(elementName + " : " + collection[elementName]);
                }
            }
        }
        private void OnHttpNotification(object sender, HttpNotificationEventArgs e)
        {
            Debug.WriteLine("Got raw notification:");
            // The client and server must agree on the format of this notification: it's just bytes
            // as far as the phone is concerned. If the application is not running, this notification will
            // be dropped. In this case, we suppose the payload is a string that was serialized with
            // BinaryWriter.
            BinaryReader reader = new BinaryReader(e.Notification.Body, System.Text.Encoding.UTF8);
            string notificationText = reader.ReadString();
            Debug.WriteLine(notificationText);
        }


    }
}