﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceFile
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/FilePartageMemoire")]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceFile.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ServiceFile.CompositeType GetDataUsingDataContract(ServiceFile.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServiceFile.CompositeType> GetDataUsingDataContractAsync(ServiceFile.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UploadToTempFolder", ReplyAction="http://tempuri.org/IService1/UploadToTempFolderResponse")]
        bool UploadToTempFolder(byte[] pFileBytes, string pFileName, string pathFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UploadToTempFolder", ReplyAction="http://tempuri.org/IService1/UploadToTempFolderResponse")]
        System.Threading.Tasks.Task<bool> UploadToTempFolderAsync(byte[] pFileBytes, string pFileName, string pathFolder);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFileFromFolder", ReplyAction="http://tempuri.org/IService1/GetFileFromFolderResponse")]
        byte[] GetFileFromFolder(string pFileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetFileFromFolder", ReplyAction="http://tempuri.org/IService1/GetFileFromFolderResponse")]
        System.Threading.Tasks.Task<byte[]> GetFileFromFolderAsync(string pFileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TableauDeByteVersFicher", ReplyAction="http://tempuri.org/IService1/TableauDeByteVersFicherResponse")]
        bool TableauDeByteVersFicher(string CheminRep, string CheminFichier, byte[] TableauDeByte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TableauDeByteVersFicher", ReplyAction="http://tempuri.org/IService1/TableauDeByteVersFicherResponse")]
        System.Threading.Tasks.Task<bool> TableauDeByteVersFicherAsync(string CheminRep, string CheminFichier, byte[] TableauDeByte);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FichierVersTableauDeByte", ReplyAction="http://tempuri.org/IService1/FichierVersTableauDeByteResponse")]
        byte[] FichierVersTableauDeByte(string CheminFichier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FichierVersTableauDeByte", ReplyAction="http://tempuri.org/IService1/FichierVersTableauDeByteResponse")]
        System.Threading.Tasks.Task<byte[]> FichierVersTableauDeByteAsync(string CheminFichier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/fileExistOnFolder", ReplyAction="http://tempuri.org/IService1/fileExistOnFolderResponse")]
        bool fileExistOnFolder(string path, string idDossier);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/fileExistOnFolder", ReplyAction="http://tempuri.org/IService1/fileExistOnFolderResponse")]
        System.Threading.Tasks.Task<bool> fileExistOnFolderAsync(string path, string idDossier);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IService1Channel : ServiceFile.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceFile.IService1>, ServiceFile.IService1
    {
        
        /// <summary>
        /// Implémentez cette méthode partielle pour configurer le point de terminaison de service.
        /// </summary>
        /// <param name="serviceEndpoint">Point de terminaison à configurer</param>
        /// <param name="clientCredentials">Informations d'identification du client</param>
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
        
        public string GetData(int value)
        {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value)
        {
            return base.Channel.GetDataAsync(value);
        }
        
        public ServiceFile.CompositeType GetDataUsingDataContract(ServiceFile.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ServiceFile.CompositeType> GetDataUsingDataContractAsync(ServiceFile.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool UploadToTempFolder(byte[] pFileBytes, string pFileName, string pathFolder)
        {
            return base.Channel.UploadToTempFolder(pFileBytes, pFileName, pathFolder);
        }
        
        public System.Threading.Tasks.Task<bool> UploadToTempFolderAsync(byte[] pFileBytes, string pFileName, string pathFolder)
        {
            return base.Channel.UploadToTempFolderAsync(pFileBytes, pFileName, pathFolder);
        }
        
        public byte[] GetFileFromFolder(string pFileName)
        {
            return base.Channel.GetFileFromFolder(pFileName);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetFileFromFolderAsync(string pFileName)
        {
            return base.Channel.GetFileFromFolderAsync(pFileName);
        }
        
        public bool TableauDeByteVersFicher(string CheminRep, string CheminFichier, byte[] TableauDeByte)
        {
            return base.Channel.TableauDeByteVersFicher(CheminRep, CheminFichier, TableauDeByte);
        }
        
        public System.Threading.Tasks.Task<bool> TableauDeByteVersFicherAsync(string CheminRep, string CheminFichier, byte[] TableauDeByte)
        {
            return base.Channel.TableauDeByteVersFicherAsync(CheminRep, CheminFichier, TableauDeByte);
        }
        
        public byte[] FichierVersTableauDeByte(string CheminFichier)
        {
            return base.Channel.FichierVersTableauDeByte(CheminFichier);
        }
        
        public System.Threading.Tasks.Task<byte[]> FichierVersTableauDeByteAsync(string CheminFichier)
        {
            return base.Channel.FichierVersTableauDeByteAsync(CheminFichier);
        }
        
        public bool fileExistOnFolder(string path, string idDossier)
        {
            return base.Channel.fileExistOnFolder(path, idDossier);
        }
        
        public System.Threading.Tasks.Task<bool> fileExistOnFolderAsync(string path, string idDossier)
        {
            return base.Channel.fileExistOnFolderAsync(path, idDossier);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
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
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IService1))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:9270/Service1.svc/Service1.svc");
            }
            throw new System.InvalidOperationException(string.Format("Le point de terminaison nommé \'{0}\' est introuvable.", endpointConfiguration));
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
