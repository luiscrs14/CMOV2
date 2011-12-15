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
    object[] GetHouse(int index, Uri url);

    [OperationContract]
    String SetUrl(Uri url);

    [OperationContract]
    bool reset(Uri url);

    [OperationContract]
    bool discard(Uri url, int propId);
  }
}
