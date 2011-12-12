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
using PhoneImage.ImageReference;
using System.Windows.Media.Imaging;
using System.IO;
using Microsoft.Phone.Notification;
using System.Diagnostics;
using Microsoft.Phone.Shell;

namespace PhoneImage {
  public partial class MainPage : PhoneApplicationPage {
    ImageServiceClient client;
    Uri channelUri;
    HttpNotificationChannel httpChannel = null;
    int id = 0;

    public MainPage() {
      InitializeComponent();
      client = new ImageServiceClient();
      //client.DoWorkCompleted += WorkCompletedHandler;
      //client.GetImageCompleted += OnGetImageCompleted;
      client.GetHouseCompleted += OnGetHouseCompleted;
      //client.DoWorkAsync();
      //client.GetImageAsync(0);
      
        
      
     
      
      string channelName = "ChannelName";
      httpChannel = HttpNotificationChannel.Find(channelName);
      if (httpChannel != null)
      {
          channelUri = httpChannel.ChannelUri;
      }
      else
      {
          httpChannel = new HttpNotificationChannel(channelName);
          httpChannel.ChannelUriUpdated += OnChannelUriUpdated;
          httpChannel.ErrorOccurred += OnErrorOccurred;
          httpChannel.Open();
          channelUri = httpChannel.ChannelUri;

      }
      client.SetUrlAsync(channelUri);
      MessageBox.Show("url: " + channelUri);
      client.GetHouseAsync(-1);
    }

    public void WorkCompletedHandler(object sender, DoWorkCompletedEventArgs e) {
        ;//priceTB.Text = e.Result.ToString();
    }

    void OnGetImageCompleted(object sender, GetImageCompletedEventArgs e) {
      byte[] img = e.Result;
      MemoryStream ms = new MemoryStream(img);
      BitmapImage bimg = new BitmapImage();
      bimg.SetSource(ms);
      imviewer.Source = bimg;
    }

    void OnGetHouseCompleted(object sender, GetHouseCompletedEventArgs e)
    {
        if (e.Result != null)
        {
            object[] house = e.Result.ToArray<object>();
            //set text field information
            cityTB.Text = house[3].ToString();
            priceTB.Text = house[6].ToString() + " €";

            //show image
            MemoryStream ms = new MemoryStream(house[8] as byte[]);
            BitmapImage bimg = new BitmapImage();
            bimg.SetSource(ms);
            imviewer.Source = bimg;

            if (house[9].ToString() == "1")
                button2.IsEnabled = false;
        }
        else
        {
            MessageBox.Show("There's no properties for purchase");
            this.NavigationService.GoBack();

        }
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

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        id--;
        if(id==0)
            button1.IsEnabled = false;

        button2.IsEnabled = true;

        //pede a imagem anterior
        client.GetHouseAsync(1);
    }

    private void button2_Click(object sender, RoutedEventArgs e)
    {
        id++;
        button1.IsEnabled = true;

        //pede a próxima imagem
        client.GetHouseAsync(0);
    }

    private void button3_Click(object sender, RoutedEventArgs e)
    {
        //descartar propriedade em visualizacao
        //apagando a entrada user,prop na tabela de relacao
        //passar a visualizacao da proxima casa
    }
  }
}