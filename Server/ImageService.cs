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

    static int counter = 0;
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
        counter = 0;
        Console.WriteLine("SetUrl(" + url1 + ") called");

        if (url1 != null && usersTA.FindUrl(url1.AbsoluteUri.ToString()) == null)
        {
            Console.WriteLine("cenas " + usersTA.FindUrl(url1.AbsoluteUri.ToString()));
            usersTA.Insert(url1.AbsoluteUri.ToString());
        }
        else
            return "";
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
        int id= (int)usersTA.GetIdByUrl(url.AbsoluteUri);

        foreach (DataRow row in propsTA.GetData())
        {
            upTA.Insert(id, Convert.ToInt32(row["id"]));
        }
        upTA.Update(dataset.Users_Properties);
        Console.WriteLine("Reset done to user " + id);
    }

      public bool discard(Uri url,int propId)
      {
          int UId = Convert.ToInt32(usersTA.GetIdByUrl(url.AbsoluteUri));
          int PId = Convert.ToInt32(upTA.GetDataByUserId(UId).Rows[propId]["idP"]);
          upTA.Delete(UId, PId);
          upTA.Update(dataset.Users_Properties);
          return true;
      }



    public object[] GetHouse(int index, Uri url)
    {
        

        int idU = 0;
        try
        {
            idU = (int)usersTA.GetIdByUrl(url.AbsoluteUri);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
        DataRowCollection rows = upTA.GetDataByUserId(idU).Rows;
        DataRow dt;

        if (rows.Count == 0)
        {
            Console.WriteLine("No cols in get house");
            return null;
        }
        dt = propsTA.GetDataById(Convert.ToInt32(rows[index]["idP"])).Rows[0];
        Console.WriteLine(dt.ItemArray);
        object[] auxArray = new object[dt.ItemArray.Length+1];
        dt.ItemArray.CopyTo(auxArray, 0);
        //adiciona a imagem ao array
        auxArray[dt.ItemArray.Length - 1] = File.ReadAllBytes(auxArray[dt.ItemArray.Length - 1].ToString());
        if (index + 1 == rows.Count)
            auxArray[dt.ItemArray.Length] = 1;
        else
            auxArray[dt.ItemArray.Length] = 0;

        return auxArray;
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

        int counterAux = counter;
        Console.WriteLine("Counter: " + counter + " counterAux: " + counterAux + " count: " + count);
        counter += count;
        Console.WriteLine("Counter: " + counter + " counterAux: " + counterAux + " count: " + count);
        return Encoding.UTF8.GetBytes(
            new XDocument(
                new XDeclaration("1.0", "utf-8", "true")
                , new XElement(wp + "Notification"
                    , new XElement(wp + "Tile"
                        , new XElement(wp + "BackgroundImage", img)
                        , new XElement(wp + "Count", count + counterAux)
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

            Console.WriteLine("SendNotification(" + response.StatusCode + " " + notificationChannelStatus + " " + notificationStatus + " " + deviceConnectionStatus + ") called");
        }
    }
  }
}
