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
        void Authentication(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Authentication", ReplyAction="http://tempuri.org/IService/AuthenticationResponse")]
        System.Threading.Tasks.Task AuthenticationAsync(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordR", ReplyAction="http://tempuri.org/IService/CoordRResponse")]
        void CoordR(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordR", ReplyAction="http://tempuri.org/IService/CoordRResponse")]
        System.Threading.Tasks.Task CoordRAsync(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordL", ReplyAction="http://tempuri.org/IService/CoordLResponse")]
        void CoordL(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordL", ReplyAction="http://tempuri.org/IService/CoordLResponse")]
        System.Threading.Tasks.Task CoordLAsync(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordU", ReplyAction="http://tempuri.org/IService/CoordUResponse")]
        void CoordU(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordU", ReplyAction="http://tempuri.org/IService/CoordUResponse")]
        System.Threading.Tasks.Task CoordUAsync(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordD", ReplyAction="http://tempuri.org/IService/CoordDResponse")]
        void CoordD(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordD", ReplyAction="http://tempuri.org/IService/CoordDResponse")]
        System.Threading.Tasks.Task CoordDAsync(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseL", ReplyAction="http://tempuri.org/IService/CoordMouseLResponse")]
        void CoordMouseL(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseL", ReplyAction="http://tempuri.org/IService/CoordMouseLResponse")]
        System.Threading.Tasks.Task CoordMouseLAsync(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseR", ReplyAction="http://tempuri.org/IService/CoordMouseRResponse")]
        void CoordMouseR(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseR", ReplyAction="http://tempuri.org/IService/CoordMouseRResponse")]
        System.Threading.Tasks.Task CoordMouseRAsync(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseM", ReplyAction="http://tempuri.org/IService/CoordMouseMResponse")]
        void CoordMouseM(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CoordMouseM", ReplyAction="http://tempuri.org/IService/CoordMouseMResponse")]
        System.Threading.Tasks.Task CoordMouseMAsync(string screenPosition);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendEmail", ReplyAction="http://tempuri.org/IService/SendEmailResponse")]
        void SendEmail(int counter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendEmail", ReplyAction="http://tempuri.org/IService/SendEmailResponse")]
        System.Threading.Tasks.Task SendEmailAsync(int counter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendWhatsApp", ReplyAction="http://tempuri.org/IService/SendWhatsAppResponse")]
        void SendWhatsApp(int counter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendWhatsApp", ReplyAction="http://tempuri.org/IService/SendWhatsAppResponse")]
        System.Threading.Tasks.Task SendWhatsAppAsync(int counter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/MessageCallBack")]
        void MessageCallBack(string message);
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
        
        public void Authentication(string login, string password) {
            base.Channel.Authentication(login, password);
        }
        
        public System.Threading.Tasks.Task AuthenticationAsync(string login, string password) {
            return base.Channel.AuthenticationAsync(login, password);
        }
        
        public void CoordR(string screenPosition) {
            base.Channel.CoordR(screenPosition);
        }
        
        public System.Threading.Tasks.Task CoordRAsync(string screenPosition) {
            return base.Channel.CoordRAsync(screenPosition);
        }
        
        public void CoordL(string screenPosition) {
            base.Channel.CoordL(screenPosition);
        }
        
        public System.Threading.Tasks.Task CoordLAsync(string screenPosition) {
            return base.Channel.CoordLAsync(screenPosition);
        }
        
        public void CoordU(string screenPosition) {
            base.Channel.CoordU(screenPosition);
        }
        
        public System.Threading.Tasks.Task CoordUAsync(string screenPosition) {
            return base.Channel.CoordUAsync(screenPosition);
        }
        
        public void CoordD(string screenPosition) {
            base.Channel.CoordD(screenPosition);
        }
        
        public System.Threading.Tasks.Task CoordDAsync(string screenPosition) {
            return base.Channel.CoordDAsync(screenPosition);
        }
        
        public void CoordMouseL(string screenPosition) {
            base.Channel.CoordMouseL(screenPosition);
        }
        
        public System.Threading.Tasks.Task CoordMouseLAsync(string screenPosition) {
            return base.Channel.CoordMouseLAsync(screenPosition);
        }
        
        public void CoordMouseR(string screenPosition) {
            base.Channel.CoordMouseR(screenPosition);
        }
        
        public System.Threading.Tasks.Task CoordMouseRAsync(string screenPosition) {
            return base.Channel.CoordMouseRAsync(screenPosition);
        }
        
        public void CoordMouseM(string screenPosition) {
            base.Channel.CoordMouseM(screenPosition);
        }
        
        public System.Threading.Tasks.Task CoordMouseMAsync(string screenPosition) {
            return base.Channel.CoordMouseMAsync(screenPosition);
        }
        
        public void SendEmail(int counter) {
            base.Channel.SendEmail(counter);
        }
        
        public System.Threading.Tasks.Task SendEmailAsync(int counter) {
            return base.Channel.SendEmailAsync(counter);
        }
        
        public void SendWhatsApp(int counter) {
            base.Channel.SendWhatsApp(counter);
        }
        
        public System.Threading.Tasks.Task SendWhatsAppAsync(int counter) {
            return base.Channel.SendWhatsAppAsync(counter);
        }
    }
}