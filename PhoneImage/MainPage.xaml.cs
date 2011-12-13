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
    
    int id = 0;
    Uri channelUri = null;
    public MainPage() {
      InitializeComponent();
        
      client = new ImageServiceClient();
      client.GetHouseCompleted += OnGetHouseCompleted;
      client.discardCompleted += OnDiscardCompleted;
      
    }

    void OnDiscardCompleted(object sender, discardCompletedEventArgs e) {
        id--;
        if (id <= 0)
        {
            button1.IsEnabled = false;
            id = 0;
        }
        client.GetHouseAsync(id, channelUri);
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
            MessageBox.Show("There are no properties to view");
            this.NavigationService.GoBack();

        }
    }




    private void button1_Click(object sender, RoutedEventArgs e)
    {
        id--;
        if(id==0)
            button1.IsEnabled = false;

        button2.IsEnabled = true;

        //pede a imagem anterior
        client.GetHouseAsync(id,channelUri);
    }

    private void button2_Click(object sender, RoutedEventArgs e)
    {
        id++;
        button1.IsEnabled = true;

        //pede a próxima imagem
        client.GetHouseAsync(id,channelUri);
    }

    private void button3_Click(object sender, RoutedEventArgs e)
    {
        //descartar propriedade em visualizacao
        client.discardAsync(channelUri,id);
       
        
    }

    protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
    {
        base.OnNavigatedTo(e);

        string msg = "";
       
        if (this.NavigationContext.QueryString.TryGetValue("uri", out msg))
        {
            channelUri = new Uri(msg);
        }

        client.GetHouseAsync(id, channelUri);
    }
      
  }
}