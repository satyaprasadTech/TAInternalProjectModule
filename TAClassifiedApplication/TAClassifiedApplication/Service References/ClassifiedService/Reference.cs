﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAClassifiedApplication.ClassifiedService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ClassifiedService.IClassifiedService")]
    public interface IClassifiedService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClassifiedService/GetAdd", ReplyAction="http://tempuri.org/IClassifiedService/GetAddResponse")]
        void GetAdd();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClassifiedService/GetAdd", ReplyAction="http://tempuri.org/IClassifiedService/GetAddResponse")]
        System.Threading.Tasks.Task GetAddAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClassifiedService/GetUserDetails", ReplyAction="http://tempuri.org/IClassifiedService/GetUserDetailsResponse")]
        void GetUserDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClassifiedService/GetUserDetails", ReplyAction="http://tempuri.org/IClassifiedService/GetUserDetailsResponse")]
        System.Threading.Tasks.Task GetUserDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClassifiedService/GetLoginDetails", ReplyAction="http://tempuri.org/IClassifiedService/GetLoginDetailsResponse")]
        void GetLoginDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClassifiedService/GetLoginDetails", ReplyAction="http://tempuri.org/IClassifiedService/GetLoginDetailsResponse")]
        System.Threading.Tasks.Task GetLoginDetailsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClassifiedServiceChannel : TAClassifiedApplication.ClassifiedService.IClassifiedService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClassifiedServiceClient : System.ServiceModel.ClientBase<TAClassifiedApplication.ClassifiedService.IClassifiedService>, TAClassifiedApplication.ClassifiedService.IClassifiedService {
        
        public ClassifiedServiceClient() {
        }
        
        public ClassifiedServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClassifiedServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClassifiedServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClassifiedServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void GetAdd() {
            base.Channel.GetAdd();
        }
        
        public System.Threading.Tasks.Task GetAddAsync() {
            return base.Channel.GetAddAsync();
        }
        
        public void GetUserDetails() {
            base.Channel.GetUserDetails();
        }
        
        public System.Threading.Tasks.Task GetUserDetailsAsync() {
            return base.Channel.GetUserDetailsAsync();
        }
        
        public void GetLoginDetails() {
            base.Channel.GetLoginDetails();
        }
        
        public System.Threading.Tasks.Task GetLoginDetailsAsync() {
            return base.Channel.GetLoginDetailsAsync();
        }
    }
}
