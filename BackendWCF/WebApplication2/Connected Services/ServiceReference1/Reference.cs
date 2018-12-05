﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/BackendWCF")]
    public partial class CompositeType : object
    {
        
        private bool BoolValueField;
        
        private string StringValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue
        {
            get
            {
                return this.StringValueField;
            }
            set
            {
                this.StringValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Event", Namespace="http://schemas.datacontract.org/2004/07/BackendWCF")]
    public partial class Event : object
    {
        
        private string Beskrivelsek__BackingFieldField;
        
        private int Idk__BackingFieldField;
        
        private string Navnk__BackingFieldField;
        
        private string Stedk__BackingFieldField;
        
        private string Datok__BackingFieldField;
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Beskrivelse>k__BackingField", IsRequired=true)]
        public string Beskrivelsek__BackingField
        {
            get
            {
                return this.Beskrivelsek__BackingFieldField;
            }
            set
            {
                this.Beskrivelsek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Id>k__BackingField", IsRequired=true)]
        public int Idk__BackingField
        {
            get
            {
                return this.Idk__BackingFieldField;
            }
            set
            {
                this.Idk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Navn>k__BackingField", IsRequired=true)]
        public string Navnk__BackingField
        {
            get
            {
                return this.Navnk__BackingFieldField;
            }
            set
            {
                this.Navnk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Sted>k__BackingField", IsRequired=true)]
        public string Stedk__BackingField
        {
            get
            {
                return this.Stedk__BackingFieldField;
            }
            set
            {
                this.Stedk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Dato>k__BackingField", IsRequired=true)]
        public string Datok__BackingField
        {
            get
            {
                return this.Datok__BackingFieldField;
            }
            set
            {
                this.Datok__BackingFieldField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CreateEvent", ReplyAction="http://tempuri.org/IService1/CreateEventResponse")]
        System.Threading.Tasks.Task CreateEventAsync(string navn, string beskrivelse, string tidspunkt, string sted);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEvent", ReplyAction="http://tempuri.org/IService1/UpdateEventResponse")]
        System.Threading.Tasks.Task UpdateEventAsync(ServiceReference1.Event e);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEvent", ReplyAction="http://tempuri.org/IService1/DeleteEventResponse")]
        System.Threading.Tasks.Task DeleteEventAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEvent", ReplyAction="http://tempuri.org/IService1/GetEventResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Event> GetEventAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEvents", ReplyAction="http://tempuri.org/IService1/GetAllEventsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.Event[]> GetAllEventsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllEventString", ReplyAction="http://tempuri.org/IService1/GetAllEventStringResponse")]
        System.Threading.Tasks.Task<string> GetAllEventStringAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SignupForEvent", ReplyAction="http://tempuri.org/IService1/SignupForEventResponse")]
        System.Threading.Tasks.Task SignupForEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/CancelForEvent", ReplyAction="http://tempuri.org/IService1/CancelForEventResponse")]
        System.Threading.Tasks.Task CancelForEventAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface IService1Channel : ServiceReference1.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReference1.IService1>, ServiceReference1.IService1
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Service1Client() : 
                base(Service1Client.GetDefaultBinding(), Service1Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IService1.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value)
        {
            return base.Channel.GetDataAsync(value);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.CompositeType> GetDataUsingDataContractAsync(ServiceReference1.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public System.Threading.Tasks.Task CreateEventAsync(string navn, string beskrivelse, string tidspunkt, string sted)
        {
            return base.Channel.CreateEventAsync(navn, beskrivelse, tidspunkt, sted);
        }
        
        public System.Threading.Tasks.Task UpdateEventAsync(ServiceReference1.Event e)
        {
            return base.Channel.UpdateEventAsync(e);
        }
        
        public System.Threading.Tasks.Task DeleteEventAsync(int id)
        {
            return base.Channel.DeleteEventAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Event> GetEventAsync(int id)
        {
            return base.Channel.GetEventAsync(id);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.Event[]> GetAllEventsAsync()
        {
            return base.Channel.GetAllEventsAsync();
        }
        
        public System.Threading.Tasks.Task<string> GetAllEventStringAsync()
        {
            return base.Channel.GetAllEventStringAsync();
        }
        
        public System.Threading.Tasks.Task SignupForEventAsync()
        {
            return base.Channel.SignupForEventAsync();
        }
        
        public System.Threading.Tasks.Task CancelForEventAsync()
        {
            return base.Channel.CancelForEventAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:50722/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Service1Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Service1Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IService1);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IService1,
        }
    }
}
