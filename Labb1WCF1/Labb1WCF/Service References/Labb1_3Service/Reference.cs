﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Labb1WCF.Labb1_3Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Labb1_3Service.Labb1_3ServiceSoap")]
    public interface Labb1_3ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddThreeNumbers", ReplyAction="*")]
        double AddThreeNumbers(double x, double y, double z);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddThreeNumbers", ReplyAction="*")]
        System.Threading.Tasks.Task<double> AddThreeNumbersAsync(double x, double y, double z);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Labb1_3ServiceSoapChannel : Labb1WCF.Labb1_3Service.Labb1_3ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Labb1_3ServiceSoapClient : System.ServiceModel.ClientBase<Labb1WCF.Labb1_3Service.Labb1_3ServiceSoap>, Labb1WCF.Labb1_3Service.Labb1_3ServiceSoap {
        
        public Labb1_3ServiceSoapClient() {
        }
        
        public Labb1_3ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Labb1_3ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Labb1_3ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Labb1_3ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double AddThreeNumbers(double x, double y, double z) {
            return base.Channel.AddThreeNumbers(x, y, z);
        }
        
        public System.Threading.Tasks.Task<double> AddThreeNumbersAsync(double x, double y, double z) {
            return base.Channel.AddThreeNumbersAsync(x, y, z);
        }
    }
}