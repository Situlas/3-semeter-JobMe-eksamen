﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobMe_Homepage.JobApplicationServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JobApplication", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class JobApplication : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ApplierIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ApplierId {
            get {
                return this.ApplierIdField;
            }
            set {
                if ((this.ApplierIdField.Equals(value) != true)) {
                    this.ApplierIdField = value;
                    this.RaisePropertyChanged("ApplierId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JobApplicationServiceReference.IJobApplicationService")]
    public interface IJobApplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/Create", ReplyAction="http://tempuri.org/IJobApplicationService/CreateResponse")]
        void Create(JobMe_Homepage.JobApplicationServiceReference.JobApplication jobApplication);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/Create", ReplyAction="http://tempuri.org/IJobApplicationService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(JobMe_Homepage.JobApplicationServiceReference.JobApplication jobApplication);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/Get", ReplyAction="http://tempuri.org/IJobApplicationService/GetResponse")]
        JobMe_Homepage.JobApplicationServiceReference.JobApplication Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/Get", ReplyAction="http://tempuri.org/IJobApplicationService/GetResponse")]
        System.Threading.Tasks.Task<JobMe_Homepage.JobApplicationServiceReference.JobApplication> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/GetAllByApplierId", ReplyAction="http://tempuri.org/IJobApplicationService/GetAllByApplierIdResponse")]
        JobMe_Homepage.JobApplicationServiceReference.JobApplication[] GetAllByApplierId(int applierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/GetAllByApplierId", ReplyAction="http://tempuri.org/IJobApplicationService/GetAllByApplierIdResponse")]
        System.Threading.Tasks.Task<JobMe_Homepage.JobApplicationServiceReference.JobApplication[]> GetAllByApplierIdAsync(int applierId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/Delete", ReplyAction="http://tempuri.org/IJobApplicationService/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/Delete", ReplyAction="http://tempuri.org/IJobApplicationService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/update", ReplyAction="http://tempuri.org/IJobApplicationService/updateResponse")]
        void update(JobMe_Homepage.JobApplicationServiceReference.JobApplication jobApplication);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IJobApplicationService/update", ReplyAction="http://tempuri.org/IJobApplicationService/updateResponse")]
        System.Threading.Tasks.Task updateAsync(JobMe_Homepage.JobApplicationServiceReference.JobApplication jobApplication);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IJobApplicationServiceChannel : JobMe_Homepage.JobApplicationServiceReference.IJobApplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class JobApplicationServiceClient : System.ServiceModel.ClientBase<JobMe_Homepage.JobApplicationServiceReference.IJobApplicationService>, JobMe_Homepage.JobApplicationServiceReference.IJobApplicationService {
        
        public JobApplicationServiceClient() {
        }
        
        public JobApplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public JobApplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobApplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public JobApplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(JobMe_Homepage.JobApplicationServiceReference.JobApplication jobApplication) {
            base.Channel.Create(jobApplication);
        }
        
        public System.Threading.Tasks.Task CreateAsync(JobMe_Homepage.JobApplicationServiceReference.JobApplication jobApplication) {
            return base.Channel.CreateAsync(jobApplication);
        }
        
        public JobMe_Homepage.JobApplicationServiceReference.JobApplication Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<JobMe_Homepage.JobApplicationServiceReference.JobApplication> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public JobMe_Homepage.JobApplicationServiceReference.JobApplication[] GetAllByApplierId(int applierId) {
            return base.Channel.GetAllByApplierId(applierId);
        }
        
        public System.Threading.Tasks.Task<JobMe_Homepage.JobApplicationServiceReference.JobApplication[]> GetAllByApplierIdAsync(int applierId) {
            return base.Channel.GetAllByApplierIdAsync(applierId);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public void update(JobMe_Homepage.JobApplicationServiceReference.JobApplication jobApplication) {
            base.Channel.update(jobApplication);
        }
        
        public System.Threading.Tasks.Task updateAsync(JobMe_Homepage.JobApplicationServiceReference.JobApplication jobApplication) {
            return base.Channel.updateAsync(jobApplication);
        }
    }
}
