using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace CMOVServer {
  [ServiceContract]
  public interface IImageService {
    [OperationContract]
    double DoWork();

    [OperationContract]
    byte[] GetImage(int id);

    [OperationContract]
    object[] GetHouse(int id);

    [OperationContract]
    String SetUrl(Uri url);

    [OperationContract]
    void reset(Uri uri);

    [OperationContract]
    void discard(Uri url, int propId);
  }
}
