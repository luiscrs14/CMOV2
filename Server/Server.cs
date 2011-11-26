using System;
using System.ServiceModel;
using System.Net;
using System.IO;

public class Server {
   
  static void Main(string[] args) {
    ServiceHost host = new ServiceHost(typeof(ImageServer.ImageService));
    host.Open();
    Console.WriteLine("Server ready for requests. Press <CR> to terminate.");
 
    Console.ReadLine();
    host.Close();
  }
}