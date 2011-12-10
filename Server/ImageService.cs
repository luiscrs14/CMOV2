using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Drawing;
using System.Data;

namespace CMOVServer {
  public class ImageService : IImageService {
    static Uri url;
    static int index = 0;
    Database1DataSet dataset = new Database1DataSet();
    Database1DataSetTableAdapters.PropertiesTableAdapter propTA = new Database1DataSetTableAdapters.PropertiesTableAdapter();
    public double DoWork() {
      Console.WriteLine("DoWork() called");
      return 3.14159;
    }

    public String SetUrl(Uri url1)
    {
        Console.WriteLine("SetUrl(" + url + ") called");
        url = url1;
        Database1DataSetTableAdapters.UsersTableAdapter usersTA = new Database1DataSetTableAdapters.UsersTableAdapter();
        Database1DataSetTableAdapters.PropertiesTableAdapter propsTA = new Database1DataSetTableAdapters.PropertiesTableAdapter();
        Database1DataSet dataset = new Database1DataSet();
       // propsTA.Insert(2, "piças", "2", "2", 2, 2, 2, "2", "2");
        //usersTA.Insert(3);
        usersTA.Update(dataset);
        propsTA.Update(dataset);
       // dataset.Properties.
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

    public object[] GetHouse(int id)
    {
        Console.WriteLine("GetHouse(index: " + index + " id: " + id+ ") called");
        propTA.Fill(dataset.Properties);
        if (dataset.Properties.Rows.Count == 0)
        {
            Console.WriteLine("No cols");
            return null;
        }
        if (id == -1){
            Console.WriteLine(dataset.Properties.Rows[0].ItemArray);
            object[] auxArray = new object[dataset.Properties.Rows[0].ItemArray.Length+1];
            dataset.Properties.Rows[0].ItemArray.CopyTo(auxArray, 0);
            //adiciona a imagem ao array
            auxArray[dataset.Properties.Rows[0].ItemArray.Length] = File.ReadAllBytes(auxArray[dataset.Properties.Rows[0].ItemArray.Length - 1].ToString());

            return auxArray;
        }
        if (id == 0){
            Console.WriteLine(dataset.Properties.Rows[index +1].ItemArray);
            object[] auxArray = new object[dataset.Properties.Rows[++index].ItemArray.Length + 1];
            dataset.Properties.Rows[index].ItemArray.CopyTo(auxArray, 0);

            auxArray[dataset.Properties.Rows[index].ItemArray.Length] = File.ReadAllBytes(auxArray[dataset.Properties.Rows[index].ItemArray.Length - 1].ToString());
            return auxArray;
        }
        else{
            Console.WriteLine(dataset.Properties.Rows[index -1].ItemArray);
            object[] auxArray = new object[dataset.Properties.Rows[--index].ItemArray.Length + 1];
            dataset.Properties.Rows[index].ItemArray.CopyTo(auxArray, 0);

            auxArray[dataset.Properties.Rows[index].ItemArray.Length] = File.ReadAllBytes(auxArray[dataset.Properties.Rows[index].ItemArray.Length - 1].ToString());
            return auxArray;
        }
    }

    internal static Uri getUrl()
    {
        return url;
    }

    public byte[] PrepareTile(int count, string text, String img )
    {
        XNamespace wp = "WPNotification";

        return Encoding.UTF8.GetBytes(
            new XDocument(
                new XDeclaration("1.0", "utf-8", "true")
                , new XElement(wp + "Notification"
                    , new XElement(wp + "Tile"
                        , new XElement(wp + "BackgroundImage", img)
                        , new XElement(wp + "Count", count)
                        , new XElement(wp + "Title", text)))).ToString());
    }


    public byte[] PrepareToast(string title, string message)
    {
        XNamespace wp = "WPNotification";

        return Encoding.UTF8.GetBytes(
            new XDocument(
                new XDeclaration("1.0", "utf-8", "false")
                , new XElement(wp + "Notification"
                    , new XElement(wp + "Toast"
                        , new XElement(wp + "Text1", title)
                        , new XElement(wp + "Text2", message)))).ToString());
    }

    public void mandavir(int type, byte[] strBytes)
    {
        Uri url = CMOVServer.ImageService.getUrl();
        if (url == null)
            return;
        Console.WriteLine("url: " + url);
        //byte[] strBytes = PrepareToast();// PrepareTile();
        HttpWebRequest sendNotificationRequest = (HttpWebRequest)WebRequest.Create(url);
        sendNotificationRequest.Method = "POST";
        sendNotificationRequest.Headers = new WebHeaderCollection();
        sendNotificationRequest.Headers["X-MessageID"] = Guid.NewGuid().ToString();
        if (type == 1)
        {
            sendNotificationRequest.Headers.Add("X-WindowsPhone-Target", "token");
            sendNotificationRequest.Headers.Add("X-NotificationClass", "1");
            sendNotificationRequest.ContentType = "text/xml";
        }
        else if (type == 2)
        {
            sendNotificationRequest.Headers.Add("X-WindowsPhone-Target", "toast");
            sendNotificationRequest.Headers.Add("X-NotificationClass", "2");
            sendNotificationRequest.ContentType = "text/xml";
        }
        else
        {
            sendNotificationRequest.Headers.Add("X-WindowsPhone-Target", "nonexistent");
            sendNotificationRequest.Headers.Add("X-NotificationClass", "3");
            sendNotificationRequest.ContentType = "nonexist";
        }

        sendNotificationRequest.ContentLength = strBytes.Length;
        using (Stream requestStream = sendNotificationRequest.GetRequestStream())
        {
            requestStream.Write(strBytes, 0, strBytes.Length);
        }
        HttpWebResponse response = (HttpWebResponse)sendNotificationRequest.GetResponse();
        string notificationStatus = response.Headers["X-NotificationStatus"];
        string deviceConnectionStatus = response.Headers["X-DeviceConnectionStatus"];
        string notificationChannelStatus = response.Headers["X-SubscriptionStatus"];

        Console.WriteLine("mandavir(" + response.StatusCode + " " + notificationChannelStatus + " " + notificationStatus + " " + deviceConnectionStatus + ") called");
    }
  }
}
