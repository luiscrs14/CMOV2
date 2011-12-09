﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace PhoneImage.ImageReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ImageReference.IImageService")]
    public interface IImageService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/DoWork", ReplyAction="http://tempuri.org/IImageService/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        double EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/GetImage", ReplyAction="http://tempuri.org/IImageService/GetImageResponse")]
        System.IAsyncResult BeginGetImage(int id, System.AsyncCallback callback, object asyncState);
        
        byte[] EndGetImage(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/SetUrl", ReplyAction="http://tempuri.org/IImageService/SetUrlResponse")]
        System.IAsyncResult BeginSetUrl(System.Uri url, System.AsyncCallback callback, object asyncState);
        
        string EndSetUrl(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/mandavir", ReplyAction="http://tempuri.org/IImageService/mandavirResponse")]
        System.IAsyncResult Beginmandavir(System.AsyncCallback callback, object asyncState);
        
        void Endmandavir(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImageServiceChannel : PhoneImage.ImageReference.IImageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DoWorkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DoWorkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public double Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetImageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetImageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public byte[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SetUrlCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public SetUrlCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImageServiceClient : System.ServiceModel.ClientBase<PhoneImage.ImageReference.IImageService>, PhoneImage.ImageReference.IImageService {
        
        private BeginOperationDelegate onBeginDoWorkDelegate;
        
        private EndOperationDelegate onEndDoWorkDelegate;
        
        private System.Threading.SendOrPostCallback onDoWorkCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetImageDelegate;
        
        private EndOperationDelegate onEndGetImageDelegate;
        
        private System.Threading.SendOrPostCallback onGetImageCompletedDelegate;
        
        private BeginOperationDelegate onBeginSetUrlDelegate;
        
        private EndOperationDelegate onEndSetUrlDelegate;
        
        private System.Threading.SendOrPostCallback onSetUrlCompletedDelegate;
        
        private BeginOperationDelegate onBeginmandavirDelegate;
        
        private EndOperationDelegate onEndmandavirDelegate;
        
        private System.Threading.SendOrPostCallback onmandavirCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ImageServiceClient() {
        }
        
        public ImageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<DoWorkCompletedEventArgs> DoWorkCompleted;
        
        public event System.EventHandler<GetImageCompletedEventArgs> GetImageCompleted;
        
        public event System.EventHandler<SetUrlCompletedEventArgs> SetUrlCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> mandavirCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneImage.ImageReference.IImageService.BeginDoWork(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        double PhoneImage.ImageReference.IImageService.EndDoWork(System.IAsyncResult result) {
            return base.Channel.EndDoWork(result);
        }
        
        private System.IAsyncResult OnBeginDoWork(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((PhoneImage.ImageReference.IImageService)(this)).BeginDoWork(callback, asyncState);
        }
        
        private object[] OnEndDoWork(System.IAsyncResult result) {
            double retVal = ((PhoneImage.ImageReference.IImageService)(this)).EndDoWork(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDoWorkCompleted(object state) {
            if ((this.DoWorkCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DoWorkCompleted(this, new DoWorkCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DoWorkAsync() {
            this.DoWorkAsync(null);
        }
        
        public void DoWorkAsync(object userState) {
            if ((this.onBeginDoWorkDelegate == null)) {
                this.onBeginDoWorkDelegate = new BeginOperationDelegate(this.OnBeginDoWork);
            }
            if ((this.onEndDoWorkDelegate == null)) {
                this.onEndDoWorkDelegate = new EndOperationDelegate(this.OnEndDoWork);
            }
            if ((this.onDoWorkCompletedDelegate == null)) {
                this.onDoWorkCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDoWorkCompleted);
            }
            base.InvokeAsync(this.onBeginDoWorkDelegate, null, this.onEndDoWorkDelegate, this.onDoWorkCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneImage.ImageReference.IImageService.BeginGetImage(int id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetImage(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        byte[] PhoneImage.ImageReference.IImageService.EndGetImage(System.IAsyncResult result) {
            return base.Channel.EndGetImage(result);
        }
        
        private System.IAsyncResult OnBeginGetImage(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            return ((PhoneImage.ImageReference.IImageService)(this)).BeginGetImage(id, callback, asyncState);
        }
        
        private object[] OnEndGetImage(System.IAsyncResult result) {
            byte[] retVal = ((PhoneImage.ImageReference.IImageService)(this)).EndGetImage(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetImageCompleted(object state) {
            if ((this.GetImageCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetImageCompleted(this, new GetImageCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetImageAsync(int id) {
            this.GetImageAsync(id, null);
        }
        
        public void GetImageAsync(int id, object userState) {
            if ((this.onBeginGetImageDelegate == null)) {
                this.onBeginGetImageDelegate = new BeginOperationDelegate(this.OnBeginGetImage);
            }
            if ((this.onEndGetImageDelegate == null)) {
                this.onEndGetImageDelegate = new EndOperationDelegate(this.OnEndGetImage);
            }
            if ((this.onGetImageCompletedDelegate == null)) {
                this.onGetImageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetImageCompleted);
            }
            base.InvokeAsync(this.onBeginGetImageDelegate, new object[] {
                        id}, this.onEndGetImageDelegate, this.onGetImageCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneImage.ImageReference.IImageService.BeginSetUrl(System.Uri url, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSetUrl(url, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string PhoneImage.ImageReference.IImageService.EndSetUrl(System.IAsyncResult result) {
            return base.Channel.EndSetUrl(result);
        }
        
        private System.IAsyncResult OnBeginSetUrl(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.Uri url = ((System.Uri)(inValues[0]));
            return ((PhoneImage.ImageReference.IImageService)(this)).BeginSetUrl(url, callback, asyncState);
        }
        
        private object[] OnEndSetUrl(System.IAsyncResult result) {
            string retVal = ((PhoneImage.ImageReference.IImageService)(this)).EndSetUrl(result);
            return new object[] {
                    retVal};
        }
        
        private void OnSetUrlCompleted(object state) {
            if ((this.SetUrlCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SetUrlCompleted(this, new SetUrlCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SetUrlAsync(System.Uri url) {
            this.SetUrlAsync(url, null);
        }
        
        public void SetUrlAsync(System.Uri url, object userState) {
            if ((this.onBeginSetUrlDelegate == null)) {
                this.onBeginSetUrlDelegate = new BeginOperationDelegate(this.OnBeginSetUrl);
            }
            if ((this.onEndSetUrlDelegate == null)) {
                this.onEndSetUrlDelegate = new EndOperationDelegate(this.OnEndSetUrl);
            }
            if ((this.onSetUrlCompletedDelegate == null)) {
                this.onSetUrlCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSetUrlCompleted);
            }
            base.InvokeAsync(this.onBeginSetUrlDelegate, new object[] {
                        url}, this.onEndSetUrlDelegate, this.onSetUrlCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneImage.ImageReference.IImageService.Beginmandavir(System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginmandavir(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void PhoneImage.ImageReference.IImageService.Endmandavir(System.IAsyncResult result) {
            base.Channel.Endmandavir(result);
        }
        
        private System.IAsyncResult OnBeginmandavir(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((PhoneImage.ImageReference.IImageService)(this)).Beginmandavir(callback, asyncState);
        }
        
        private object[] OnEndmandavir(System.IAsyncResult result) {
            ((PhoneImage.ImageReference.IImageService)(this)).Endmandavir(result);
            return null;
        }
        
        private void OnmandavirCompleted(object state) {
            if ((this.mandavirCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.mandavirCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void mandavirAsync() {
            this.mandavirAsync(null);
        }
        
        public void mandavirAsync(object userState) {
            if ((this.onBeginmandavirDelegate == null)) {
                this.onBeginmandavirDelegate = new BeginOperationDelegate(this.OnBeginmandavir);
            }
            if ((this.onEndmandavirDelegate == null)) {
                this.onEndmandavirDelegate = new EndOperationDelegate(this.OnEndmandavir);
            }
            if ((this.onmandavirCompletedDelegate == null)) {
                this.onmandavirCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnmandavirCompleted);
            }
            base.InvokeAsync(this.onBeginmandavirDelegate, null, this.onEndmandavirDelegate, this.onmandavirCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override PhoneImage.ImageReference.IImageService CreateChannel() {
            return new ImageServiceClientChannel(this);
        }
        
        private class ImageServiceClientChannel : ChannelBase<PhoneImage.ImageReference.IImageService>, PhoneImage.ImageReference.IImageService {
            
            public ImageServiceClientChannel(System.ServiceModel.ClientBase<PhoneImage.ImageReference.IImageService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("DoWork", _args, callback, asyncState);
                return _result;
            }
            
            public double EndDoWork(System.IAsyncResult result) {
                object[] _args = new object[0];
                double _result = ((double)(base.EndInvoke("DoWork", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetImage(int id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = id;
                System.IAsyncResult _result = base.BeginInvoke("GetImage", _args, callback, asyncState);
                return _result;
            }
            
            public byte[] EndGetImage(System.IAsyncResult result) {
                object[] _args = new object[0];
                byte[] _result = ((byte[])(base.EndInvoke("GetImage", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginSetUrl(System.Uri url, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = url;
                System.IAsyncResult _result = base.BeginInvoke("SetUrl", _args, callback, asyncState);
                return _result;
            }
            
            public string EndSetUrl(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("SetUrl", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult Beginmandavir(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("mandavir", _args, callback, asyncState);
                return _result;
            }
            
            public void Endmandavir(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("mandavir", _args, result);
            }
        }
    }
}