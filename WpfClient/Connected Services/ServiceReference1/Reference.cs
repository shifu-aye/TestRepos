﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService", CallbackContract=typeof(WpfClient.ServiceReference1.IServiceCallback))]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Authentication", ReplyAction="http://tempuri.org/IService/AuthenticationResponse")]
        WpfClient.ServiceReference1.AuthenticationResponse Authentication(WpfClient.ServiceReference1.AuthenticationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Authentication", ReplyAction="http://tempuri.org/IService/AuthenticationResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.AuthenticationResponse> AuthenticationAsync(WpfClient.ServiceReference1.AuthenticationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordR", ReplyAction="http://tempuri.org/IService/CoordRResponse")]
        WpfClient.ServiceReference1.CoordRResponse CoordR(WpfClient.ServiceReference1.CoordRRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordR", ReplyAction="http://tempuri.org/IService/CoordRResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordRResponse> CoordRAsync(WpfClient.ServiceReference1.CoordRRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordL", ReplyAction="http://tempuri.org/IService/CoordLResponse")]
        WpfClient.ServiceReference1.CoordLResponse CoordL(WpfClient.ServiceReference1.CoordLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordL", ReplyAction="http://tempuri.org/IService/CoordLResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordLResponse> CoordLAsync(WpfClient.ServiceReference1.CoordLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordU", ReplyAction="http://tempuri.org/IService/CoordUResponse")]
        WpfClient.ServiceReference1.CoordUResponse CoordU(WpfClient.ServiceReference1.CoordURequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordU", ReplyAction="http://tempuri.org/IService/CoordUResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordUResponse> CoordUAsync(WpfClient.ServiceReference1.CoordURequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordD", ReplyAction="http://tempuri.org/IService/CoordDResponse")]
        WpfClient.ServiceReference1.CoordDResponse CoordD(WpfClient.ServiceReference1.CoordDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordD", ReplyAction="http://tempuri.org/IService/CoordDResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordDResponse> CoordDAsync(WpfClient.ServiceReference1.CoordDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseL", ReplyAction="http://tempuri.org/IService/CoordMouseLResponse")]
        WpfClient.ServiceReference1.CoordMouseLResponse CoordMouseL(WpfClient.ServiceReference1.CoordMouseLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseL", ReplyAction="http://tempuri.org/IService/CoordMouseLResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordMouseLResponse> CoordMouseLAsync(WpfClient.ServiceReference1.CoordMouseLRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseR", ReplyAction="http://tempuri.org/IService/CoordMouseRResponse")]
        WpfClient.ServiceReference1.CoordMouseRResponse CoordMouseR(WpfClient.ServiceReference1.CoordMouseRRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseR", ReplyAction="http://tempuri.org/IService/CoordMouseRResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordMouseRResponse> CoordMouseRAsync(WpfClient.ServiceReference1.CoordMouseRRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseM", ReplyAction="http://tempuri.org/IService/CoordMouseMResponse")]
        WpfClient.ServiceReference1.CoordMouseMResponse CoordMouseM(WpfClient.ServiceReference1.CoordMouseMRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseM", ReplyAction="http://tempuri.org/IService/CoordMouseMResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordMouseMResponse> CoordMouseMAsync(WpfClient.ServiceReference1.CoordMouseMRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendEmail", ReplyAction="http://tempuri.org/IService/SendEmailResponse")]
        WpfClient.ServiceReference1.SendEmailResponse SendEmail(WpfClient.ServiceReference1.SendEmailRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendEmail", ReplyAction="http://tempuri.org/IService/SendEmailResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.SendEmailResponse> SendEmailAsync(WpfClient.ServiceReference1.SendEmailRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendWhatsApp", ReplyAction="http://tempuri.org/IService/SendWhatsAppResponse")]
        WpfClient.ServiceReference1.SendWhatsAppResponse SendWhatsApp(WpfClient.ServiceReference1.SendWhatsAppRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendWhatsApp", ReplyAction="http://tempuri.org/IService/SendWhatsAppResponse")]
        System.Threading.Tasks.Task<WpfClient.ServiceReference1.SendWhatsAppResponse> SendWhatsAppAsync(WpfClient.ServiceReference1.SendWhatsAppRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/MessageCallBack")]
        void MessageCallBack(WpfClient.ServiceReference1.MessageCallBack request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Authentication", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthenticationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string login;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string password;
        
        public AuthenticationRequest() {
        }
        
        public AuthenticationRequest(string login, string password) {
            this.login = login;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticationResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthenticationResponse {
        
        public AuthenticationResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordR", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordRRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string screenPosition;
        
        public CoordRRequest() {
        }
        
        public CoordRRequest(string screenPosition) {
            this.screenPosition = screenPosition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordRResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordRResponse {
        
        public CoordRResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordL", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string screenPosition;
        
        public CoordLRequest() {
        }
        
        public CoordLRequest(string screenPosition) {
            this.screenPosition = screenPosition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordLResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordLResponse {
        
        public CoordLResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordU", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordURequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string screenPosition;
        
        public CoordURequest() {
        }
        
        public CoordURequest(string screenPosition) {
            this.screenPosition = screenPosition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordUResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordUResponse {
        
        public CoordUResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordD", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string screenPosition;
        
        public CoordDRequest() {
        }
        
        public CoordDRequest(string screenPosition) {
            this.screenPosition = screenPosition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordDResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordDResponse {
        
        public CoordDResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordMouseL", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordMouseLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string screenPosition;
        
        public CoordMouseLRequest() {
        }
        
        public CoordMouseLRequest(string screenPosition) {
            this.screenPosition = screenPosition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordMouseLResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordMouseLResponse {
        
        public CoordMouseLResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordMouseR", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordMouseRRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string screenPosition;
        
        public CoordMouseRRequest() {
        }
        
        public CoordMouseRRequest(string screenPosition) {
            this.screenPosition = screenPosition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordMouseRResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordMouseRResponse {
        
        public CoordMouseRResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordMouseM", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordMouseMRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string screenPosition;
        
        public CoordMouseMRequest() {
        }
        
        public CoordMouseMRequest(string screenPosition) {
            this.screenPosition = screenPosition;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CoordMouseMResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CoordMouseMResponse {
        
        public CoordMouseMResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendEmail", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendEmailRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int counter;
        
        public SendEmailRequest() {
        }
        
        public SendEmailRequest(int counter) {
            this.counter = counter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendEmailResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendEmailResponse {
        
        public SendEmailResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendWhatsApp", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendWhatsAppRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int counter;
        
        public SendWhatsAppRequest() {
        }
        
        public SendWhatsAppRequest(int counter) {
            this.counter = counter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SendWhatsAppResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SendWhatsAppResponse {
        
        public SendWhatsAppResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MessageCallBack", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MessageCallBack {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string message;
        
        public MessageCallBack() {
        }
        
        public MessageCallBack(string message) {
            this.message = message;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WpfClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.DuplexClientBase<WpfClient.ServiceReference1.IService>, WpfClient.ServiceReference1.IService {
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public WpfClient.ServiceReference1.AuthenticationResponse Authentication(WpfClient.ServiceReference1.AuthenticationRequest request) {
            return base.Channel.Authentication(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.AuthenticationResponse> AuthenticationAsync(WpfClient.ServiceReference1.AuthenticationRequest request) {
            return base.Channel.AuthenticationAsync(request);
        }
        
        public WpfClient.ServiceReference1.CoordRResponse CoordR(WpfClient.ServiceReference1.CoordRRequest request) {
            return base.Channel.CoordR(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordRResponse> CoordRAsync(WpfClient.ServiceReference1.CoordRRequest request) {
            return base.Channel.CoordRAsync(request);
        }
        
        public WpfClient.ServiceReference1.CoordLResponse CoordL(WpfClient.ServiceReference1.CoordLRequest request) {
            return base.Channel.CoordL(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordLResponse> CoordLAsync(WpfClient.ServiceReference1.CoordLRequest request) {
            return base.Channel.CoordLAsync(request);
        }
        
        public WpfClient.ServiceReference1.CoordUResponse CoordU(WpfClient.ServiceReference1.CoordURequest request) {
            return base.Channel.CoordU(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordUResponse> CoordUAsync(WpfClient.ServiceReference1.CoordURequest request) {
            return base.Channel.CoordUAsync(request);
        }
        
        public WpfClient.ServiceReference1.CoordDResponse CoordD(WpfClient.ServiceReference1.CoordDRequest request) {
            return base.Channel.CoordD(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordDResponse> CoordDAsync(WpfClient.ServiceReference1.CoordDRequest request) {
            return base.Channel.CoordDAsync(request);
        }
        
        public WpfClient.ServiceReference1.CoordMouseLResponse CoordMouseL(WpfClient.ServiceReference1.CoordMouseLRequest request) {
            return base.Channel.CoordMouseL(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordMouseLResponse> CoordMouseLAsync(WpfClient.ServiceReference1.CoordMouseLRequest request) {
            return base.Channel.CoordMouseLAsync(request);
        }
        
        public WpfClient.ServiceReference1.CoordMouseRResponse CoordMouseR(WpfClient.ServiceReference1.CoordMouseRRequest request) {
            return base.Channel.CoordMouseR(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordMouseRResponse> CoordMouseRAsync(WpfClient.ServiceReference1.CoordMouseRRequest request) {
            return base.Channel.CoordMouseRAsync(request);
        }
        
        public WpfClient.ServiceReference1.CoordMouseMResponse CoordMouseM(WpfClient.ServiceReference1.CoordMouseMRequest request) {
            return base.Channel.CoordMouseM(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.CoordMouseMResponse> CoordMouseMAsync(WpfClient.ServiceReference1.CoordMouseMRequest request) {
            return base.Channel.CoordMouseMAsync(request);
        }
        
        public WpfClient.ServiceReference1.SendEmailResponse SendEmail(WpfClient.ServiceReference1.SendEmailRequest request) {
            return base.Channel.SendEmail(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.SendEmailResponse> SendEmailAsync(WpfClient.ServiceReference1.SendEmailRequest request) {
            return base.Channel.SendEmailAsync(request);
        }
        
        public WpfClient.ServiceReference1.SendWhatsAppResponse SendWhatsApp(WpfClient.ServiceReference1.SendWhatsAppRequest request) {
            return base.Channel.SendWhatsApp(request);
        }
        
        public System.Threading.Tasks.Task<WpfClient.ServiceReference1.SendWhatsAppResponse> SendWhatsAppAsync(WpfClient.ServiceReference1.SendWhatsAppRequest request) {
            return base.Channel.SendWhatsAppAsync(request);
        }
    }
}
