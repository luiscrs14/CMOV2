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
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/GetHouse", ReplyAction="http://tempuri.org/IImageService/GetHouseResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.ObjectModel.ObservableCollection<object>))]
        System.IAsyncResult BeginGetHouse(int index, System.Uri url, System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<object> EndGetHouse(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/SetUrl", ReplyAction="http://tempuri.org/IImageService/SetUrlResponse")]
        System.IAsyncResult BeginSetUrl(System.Uri url, System.AsyncCallback callback, object asyncState);
        
        string EndSetUrl(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/reset", ReplyAction="http://tempuri.org/IImageService/resetResponse")]
        System.IAsyncResult Beginreset(System.Uri url, System.AsyncCallback callback, object asyncState);
        
        bool Endreset(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IImageService/discard", ReplyAction="http://tempuri.org/IImageService/discardResponse")]
        System.IAsyncResult Begindiscard(System.Uri url, int propId, System.AsyncCallback callback, object asyncState);
        
        bool Enddiscard(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImageServiceChannel : PhoneImage.ImageReference.IImageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetHouseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetHouseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<object> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<object>)(this.results[0]));
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
    public partial class resetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public resetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class discardCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public discardCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImageServiceClient : System.ServiceModel.ClientBase<PhoneImage.ImageReference.IImageService>, PhoneImage.ImageReference.IImageService {
        
        private BeginOperationDelegate onBeginGetHouseDelegate;
        
        private EndOperationDelegate onEndGetHouseDelegate;
        
        private System.Threading.SendOrPostCallback onGetHouseCompletedDelegate;
        
        private BeginOperationDelegate onBeginSetUrlDelegate;
        
        private EndOperationDelegate onEndSetUrlDelegate;
        
        private System.Threading.SendOrPostCallback onSetUrlCompletedDelegate;
        
        private BeginOperationDelegate onBeginresetDelegate;
        
        private EndOperationDelegate onEndresetDelegate;
        
        private System.Threading.SendOrPostCallback onresetCompletedDelegate;
        
        private BeginOperationDelegate onBegindiscardDelegate;
        
        private EndOperationDelegate onEnddiscardDelegate;
        
        private System.Threading.SendOrPostCallback ondiscardCompletedDelegate;
        
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
        
        public event System.EventHandler<GetHouseCompletedEventArgs> GetHouseCompleted;
        
        public event System.EventHandler<SetUrlCompletedEventArgs> SetUrlCompleted;
        
        public event System.EventHandler<resetCompletedEventArgs> resetCompleted;
        
        public event System.EventHandler<discardCompletedEventArgs> discardCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneImage.ImageReference.IImageService.BeginGetHouse(int index, System.Uri url, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetHouse(index, url, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<object> PhoneImage.ImageReference.IImageService.EndGetHouse(System.IAsyncResult result) {
            return base.Channel.EndGetHouse(result);
        }
        
        private System.IAsyncResult OnBeginGetHouse(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int index = ((int)(inValues[0]));
            System.Uri url = ((System.Uri)(inValues[1]));
            return ((PhoneImage.ImageReference.IImageService)(this)).BeginGetHouse(index, url, callback, asyncState);
        }
        
        private object[] OnEndGetHouse(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<object> retVal = ((PhoneImage.ImageReference.IImageService)(this)).EndGetHouse(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetHouseCompleted(object state) {
            if ((this.GetHouseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetHouseCompleted(this, new GetHouseCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetHouseAsync(int index, System.Uri url) {
            this.GetHouseAsync(index, url, null);
        }
        
        public void GetHouseAsync(int index, System.Uri url, object userState) {
            if ((this.onBeginGetHouseDelegate == null)) {
                this.onBeginGetHouseDelegate = new BeginOperationDelegate(this.OnBeginGetHouse);
            }
            if ((this.onEndGetHouseDelegate == null)) {
                this.onEndGetHouseDelegate = new EndOperationDelegate(this.OnEndGetHouse);
            }
            if ((this.onGetHouseCompletedDelegate == null)) {
                this.onGetHouseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetHouseCompleted);
            }
            base.InvokeAsync(this.onBeginGetHouseDelegate, new object[] {
                        index,
                        url}, this.onEndGetHouseDelegate, this.onGetHouseCompletedDelegate, userState);
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
        System.IAsyncResult PhoneImage.ImageReference.IImageService.Beginreset(System.Uri url, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginreset(url, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool PhoneImage.ImageReference.IImageService.Endreset(System.IAsyncResult result) {
            return base.Channel.Endreset(result);
        }
        
        private System.IAsyncResult OnBeginreset(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.Uri url = ((System.Uri)(inValues[0]));
            return ((PhoneImage.ImageReference.IImageService)(this)).Beginreset(url, callback, asyncState);
        }
        
        private object[] OnEndreset(System.IAsyncResult result) {
            bool retVal = ((PhoneImage.ImageReference.IImageService)(this)).Endreset(result);
            return new object[] {
                    retVal};
        }
        
        private void OnresetCompleted(object state) {
            if ((this.resetCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.resetCompleted(this, new resetCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void resetAsync(System.Uri url) {
            this.resetAsync(url, null);
        }
        
        public void resetAsync(System.Uri url, object userState) {
            if ((this.onBeginresetDelegate == null)) {
                this.onBeginresetDelegate = new BeginOperationDelegate(this.OnBeginreset);
            }
            if ((this.onEndresetDelegate == null)) {
                this.onEndresetDelegate = new EndOperationDelegate(this.OnEndreset);
            }
            if ((this.onresetCompletedDelegate == null)) {
                this.onresetCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnresetCompleted);
            }
            base.InvokeAsync(this.onBeginresetDelegate, new object[] {
                        url}, this.onEndresetDelegate, this.onresetCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult PhoneImage.ImageReference.IImageService.Begindiscard(System.Uri url, int propId, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Begindiscard(url, propId, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool PhoneImage.ImageReference.IImageService.Enddiscard(System.IAsyncResult result) {
            return base.Channel.Enddiscard(result);
        }
        
        private System.IAsyncResult OnBegindiscard(object[] inValues, System.AsyncCallback callback, object asyncState) {
            System.Uri url = ((System.Uri)(inValues[0]));
            int propId = ((int)(inValues[1]));
            return ((PhoneImage.ImageReference.IImageService)(this)).Begindiscard(url, propId, callback, asyncState);
        }
        
        private object[] OnEnddiscard(System.IAsyncResult result) {
            bool retVal = ((PhoneImage.ImageReference.IImageService)(this)).Enddiscard(result);
            return new object[] {
                    retVal};
        }
        
        private void OndiscardCompleted(object state) {
            if ((this.discardCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.discardCompleted(this, new discardCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void discardAsync(System.Uri url, int propId) {
            this.discardAsync(url, propId, null);
        }
        
        public void discardAsync(System.Uri url, int propId, object userState) {
            if ((this.onBegindiscardDelegate == null)) {
                this.onBegindiscardDelegate = new BeginOperationDelegate(this.OnBegindiscard);
            }
            if ((this.onEnddiscardDelegate == null)) {
                this.onEnddiscardDelegate = new EndOperationDelegate(this.OnEnddiscard);
            }
            if ((this.ondiscardCompletedDelegate == null)) {
                this.ondiscardCompletedDelegate = new System.Threading.SendOrPostCallback(this.OndiscardCompleted);
            }
            base.InvokeAsync(this.onBegindiscardDelegate, new object[] {
                        url,
                        propId}, this.onEnddiscardDelegate, this.ondiscardCompletedDelegate, userState);
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
            
            public System.IAsyncResult BeginGetHouse(int index, System.Uri url, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = index;
                _args[1] = url;
                System.IAsyncResult _result = base.BeginInvoke("GetHouse", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<object> EndGetHouse(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<object> _result = ((System.Collections.ObjectModel.ObservableCollection<object>)(base.EndInvoke("GetHouse", _args, result)));
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
            
            public System.IAsyncResult Beginreset(System.Uri url, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = url;
                System.IAsyncResult _result = base.BeginInvoke("reset", _args, callback, asyncState);
                return _result;
            }
            
            public bool Endreset(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("reset", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult Begindiscard(System.Uri url, int propId, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = url;
                _args[1] = propId;
                System.IAsyncResult _result = base.BeginInvoke("discard", _args, callback, asyncState);
                return _result;
            }
            
            public bool Enddiscard(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("discard", _args, result)));
                return _result;
            }
        }
    }
}
