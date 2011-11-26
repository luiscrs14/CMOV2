using System;
using System.ServiceModel;
using System.Net;
using System.IO;

public class Server {
   
  static void Main(string[] args) {
    ServiceHost host = new ServiceHost(typeof(ImageServer.ImageService));
    host.Open();
    Console.WriteLine("Server ready for requests. Press <CR> to terminate.");
   /* Uri url;
    byte[ ] strBytes = {1,1};
    HttpWebRequest sendNotificationRequest = (HttpWebRequest) WebRequest.Create(url);
    sendNotificationRequest.Method = "POST";
    sendNotificationRequest.Headers = new WebHeaderCollection();
    sendNotificationRequest.Headers["X-MessageID"] = Guid.NewGuid().ToString();
    sendNotificationRequest.Headers.Add("X-WindowsPhone-Target", "toast");
    sendNotificationRequest.Headers.Add("X-NotificationClass", "2");
    sendNotificationRequest.ContentType = "text/xml";
    sendNotificationRequest.ContentLength = strBytes.Length;
    using (Stream requestStream = sendNotificationRequest.GetRequestStream()) {
    requestStream.Write(strBytes, 0, strBytes.Length);
    }
    HttpWebResponse response = (HttpWebResponse)sendNotificationRequest.GetResponse();
    string notificationStatus = response.Headers["X-NotificationStatus"];
    string deviceConnectionStatus = response.Headers["X-DeviceConnectionStatus"];
      */
    Console.ReadLine();
    host.Close();
  }
}