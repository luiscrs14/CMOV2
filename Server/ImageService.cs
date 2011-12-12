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
    
    static int index = 0;
    Database1DataSet dataset = new Database1DataSet();
    Database1DataSetTableAdapters.PropertiesTableAdapter propsTA = new Database1DataSetTableAdapters.PropertiesTableAdapter();
    Database1DataSetTableAdapters.UsersTableAdapter usersTA = new Database1DataSetTableAdapters.UsersTableAdapter();
    Database1DataSetTableAdapters.Users_PropertiesTableAdapter upTA = new Database1DataSetTableAdapters.Users_PropertiesTableAdapter();
    public double DoWork() {
      Console.WriteLine("DoWork() called");
      return 3.14159;
    }

    public String SetUrl(Uri url1)
    {
        Console.WriteLine("SetUrl(" + url1 + ") called");
       
         if (url1 != null && usersTA.FindUrl(url1.AbsoluteUri.ToString()) == null)
        {
            Console.WriteLine("cenas " + usersTA.FindUrl(url1.AbsoluteUri.ToString()));
            usersTA.Insert(url1.AbsoluteUri.ToString());
        }
        usersTA.Update(dataset);
        propsTA.Fill(dataset.Properties);
        int id = (int)usersTA.GetIdByUrl(url1.AbsoluteUri);
        foreach (DataRow row in dataset.Properties.Rows)
        {
            upTA.Insert(id, Convert.ToInt32(row["id"]));
        }
        upTA.Update(dataset.Users_Properties);
        
       
        return "URL set";
        
    }

    public void reset(Uri url)
    {
        int id= (int)usersTA.GetIdByUrl(url.AbsoluteUri.ToString());
        //se isto nao funcionar, por nao poder fazer overwrite,descomentar isto..
       /* upTA.GetDataByUserId(id);
        foreach (DataRow row in upTA.GetDataByUserId(id))
        {
            row.Delete();
        }*/
        foreach (DataRow row in dataset.Properties.Rows)
        {
            upTA.Insert(id, Convert.ToInt32(row["id"]));
        }
        upTA.Update(dataset.Users_Properties);
        Console.WriteLine("Reset done to user " + id);
    }

      public void discard(Uri url,int propId)
      {
          upTA.GetDataUrlAndId((int)usersTA.GetIdByUrl(url.AbsoluteUri.ToString()), propId);
          foreach(DataRow row in upTA.GetDataUrlAndId((int)usersTA.GetIdByUrl(url.AbsoluteUri.ToString()), propId)){
              row.Delete();
          }
          upTA.Update(dataset.Users_Properties);
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
        propsTA.Fill(dataset.Properties);
        if (dataset.Properties.Rows.Count == 0)
        {
            Console.WriteLine("No cols in get house");
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

    public Uri[] getUrls()
    {

        if (usersTA.GetData().Count != 0)
        {
            List<Uri> urls = new List<Uri>(usersTA.GetData().Count);
            foreach (DataRow myRow in usersTA.GetData())
            {
                Console.WriteLine(myRow["url"]);
                urls.Add(new Uri(myRow["url"].ToString()));

            }
            return urls.ToArray<Uri>();
        }
        else
            Console.WriteLine("Tenho 0 urls");
        return null;
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

    public void SendNotfication(int type, byte[] strBytes)
    {
        Uri[] urls = getUrls();
        if (urls == null)
            return;
        foreach (Uri url in urls)
        {
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
}
