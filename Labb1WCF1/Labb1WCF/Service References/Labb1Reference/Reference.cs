﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Labb1WCF.Labb1Reference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Labb1Reference.myFirstServiceSoap")]
    public interface myFirstServiceSoap {
        
        // CODEGEN: Generating message contract since element name dayOfWeek from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTomorrowsWheater", ReplyAction="*")]
        Labb1WCF.Labb1Reference.GetTomorrowsWheaterResponse GetTomorrowsWheater(Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTomorrowsWheater", ReplyAction="*")]
        System.Threading.Tasks.Task<Labb1WCF.Labb1Reference.GetTomorrowsWheaterResponse> GetTomorrowsWheaterAsync(Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTomorrowsWheaterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTomorrowsWheater", Namespace="http://tempuri.org/", Order=0)]
        public Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequestBody Body;
        
        public GetTomorrowsWheaterRequest() {
        }
        
        public GetTomorrowsWheaterRequest(Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTomorrowsWheaterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string dayOfWeek;
        
        public GetTomorrowsWheaterRequestBody() {
        }
        
        public GetTomorrowsWheaterRequestBody(string dayOfWeek) {
            this.dayOfWeek = dayOfWeek;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTomorrowsWheaterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTomorrowsWheaterResponse", Namespace="http://tempuri.org/", Order=0)]
        public Labb1WCF.Labb1Reference.GetTomorrowsWheaterResponseBody Body;
        
        public GetTomorrowsWheaterResponse() {
        }
        
        public GetTomorrowsWheaterResponse(Labb1WCF.Labb1Reference.GetTomorrowsWheaterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetTomorrowsWheaterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetTomorrowsWheaterResult;
        
        public GetTomorrowsWheaterResponseBody() {
        }
        
        public GetTomorrowsWheaterResponseBody(string GetTomorrowsWheaterResult) {
            this.GetTomorrowsWheaterResult = GetTomorrowsWheaterResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface myFirstServiceSoapChannel : Labb1WCF.Labb1Reference.myFirstServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class myFirstServiceSoapClient : System.ServiceModel.ClientBase<Labb1WCF.Labb1Reference.myFirstServiceSoap>, Labb1WCF.Labb1Reference.myFirstServiceSoap {
        
        public myFirstServiceSoapClient() {
        }
        
        public myFirstServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public myFirstServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public myFirstServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public myFirstServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Labb1WCF.Labb1Reference.GetTomorrowsWheaterResponse Labb1WCF.Labb1Reference.myFirstServiceSoap.GetTomorrowsWheater(Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequest request) {
            return base.Channel.GetTomorrowsWheater(request);
        }
        
        public string GetTomorrowsWheater(string dayOfWeek) {
            Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequest inValue = new Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequest();
            inValue.Body = new Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequestBody();
            inValue.Body.dayOfWeek = dayOfWeek;
            Labb1WCF.Labb1Reference.GetTomorrowsWheaterResponse retVal = ((Labb1WCF.Labb1Reference.myFirstServiceSoap)(this)).GetTomorrowsWheater(inValue);
            return retVal.Body.GetTomorrowsWheaterResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Labb1WCF.Labb1Reference.GetTomorrowsWheaterResponse> Labb1WCF.Labb1Reference.myFirstServiceSoap.GetTomorrowsWheaterAsync(Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequest request) {
            return base.Channel.GetTomorrowsWheaterAsync(request);
        }
        
        public System.Threading.Tasks.Task<Labb1WCF.Labb1Reference.GetTomorrowsWheaterResponse> GetTomorrowsWheaterAsync(string dayOfWeek) {
            Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequest inValue = new Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequest();
            inValue.Body = new Labb1WCF.Labb1Reference.GetTomorrowsWheaterRequestBody();
            inValue.Body.dayOfWeek = dayOfWeek;
            return ((Labb1WCF.Labb1Reference.myFirstServiceSoap)(this)).GetTomorrowsWheaterAsync(inValue);
        }
    }
}
