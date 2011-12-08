using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Net;
using System.Xml.Linq;

namespace CMOVServer {
  public class ImageService : IImageService {
    static Uri url;
    public double DoWork() {
      Console.WriteLine("DoWork() called");
      return 3.14159;
    }

    public String SetUrl(Uri url1)
    {
        Console.WriteLine("SetUrl(" + url + ") called");
        url = url1;
        return "URL set";
        
    }

    public byte[] GetImage(int id) {
      string fimage;

      Console.WriteLine("GetImage(" + id + ") called");
      switch (id) {
        case 0:
          fimage = "Images\\home1.png";
          break;
        case 1:
          fimage = "Images\\home2.png";
          break;
        case 2:
          fimage = "Images\\home3.png";
          break;
        case 3:
          fimage = "Images\\home4.png";
          break;
        default:
          fimage = "Images\\home5.png";
          break;
      }
      
      byte[] buf = File.ReadAllBytes(fimage);
      return buf;
    }

    internal static Uri getUrl()
    {
        return url;
    }

    public byte[] PrepareTile()
    {
        XNamespace wp = "WPNotification";

        Console.WriteLine("Tou aki");

        return Encoding.UTF8.GetBytes(
            new XDocument(
                new XDeclaration("1.0", "utf-8", "true")
                , new XElement(wp + "Notification"
                    , new XElement(wp + "Tile"
                        , new XElement(wp + "BackgroundImage", null)//"http://www.pontoxp.com/wp-content/uploads/2009/08/como-melhorar-o-desempenho-de-programas-no-windows.jpg")
                        , new XElement(wp + "Count", 1)
                        , new XElement(wp + "Title", "ola")))).ToString());
    }


    public byte[] PrepareToast()
    {
        XNamespace wp = "WPNotification";

        return Encoding.UTF8.GetBytes(
            new XDocument(
                new XDeclaration("1.0", "utf-8", "false")
                , new XElement(wp + "Notification"
                    , new XElement(wp + "Toast"
                        , new XElement(wp + "Text1", "New Property")
                        , new XElement(wp + "Text2", "Cenas")))).ToString());
    }

    public void mandavir()
    {
        Uri url = CMOVServer.ImageService.getUrl();
        byte[] strBytes = PrepareToast();// PrepareTile();
        HttpWebRequest sendNotificationRequest = (HttpWebRequest)WebRequest.Create(url);
        sendNotificationRequest.Method = "POST";
        sendNotificationRequest.Headers = new WebHeaderCollection();
        sendNotificationRequest.Headers["X-MessageID"] = Guid.NewGuid().ToString();
        sendNotificationRequest.Headers.Add("X-WindowsPhone-Target", "toast");
        sendNotificationRequest.Headers.Add("X-NotificationClass", "2");
        sendNotificationRequest.ContentType = "text/xml";//"nonexist";
        sendNotificationRequest.ContentLength = strBytes.Length;
        using (Stream requestStream = sendNotificationRequest.GetRequestStream())
        {
            requestStream.Write(strBytes, 0, strBytes.Length);
        }
        HttpWebResponse response = (HttpWebResponse)sendNotificationRequest.GetResponse();
        string notificationStatus = response.Headers["X-NotificationStatus"];
        string deviceConnectionStatus = response.Headers["X-DeviceConnectionStatus"];
        string notificationChannelStatus = response.Headers["X-SubscriptionStatus"];

        Console.WriteLine("mandavir(" + notificationChannelStatus + notificationStatus + " " + deviceConnectionStatus + ") called");
    }
  }
}
