using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace ImageServer {
  public class ImageService : IImageService {
      Uri url;
    public double DoWork() {
      Console.WriteLine("DoWork() called");
      return 3.14159;
    }

    public String SetUrl(Uri url)
    {
        Console.WriteLine("SetUrl(" + url + ") called");
        this.url = url;
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
  }
}
