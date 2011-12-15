using System;
using System.ServiceModel;
using CMOVServer;
using System.Windows.Forms;

public class Server {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ServiceHost host = new ServiceHost(typeof(ImageService));
        host.Open();
        Console.WriteLine("Server ready for requests.");  
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new ServerGUI());
        host.Close();
        }

  
}