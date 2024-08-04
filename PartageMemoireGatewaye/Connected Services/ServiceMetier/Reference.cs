﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdus si
//     le code est regénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceMetier
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/MetierPM")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Personne", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceMetier.Etudiant))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ServiceMetier.Expert))]
    public partial class Personne : object
    {
        
        private int IdField;
        
        private string NomField;
        
        private string PrenomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom
        {
            get
            {
                return this.PrenomField;
            }
            set
            {
                this.PrenomField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Etudiant", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    public partial class Etudiant : ServiceMetier.Personne
    {
        
        private System.DateTime DateDeNaissanceField;
        
        private ServiceMetier.Departement DepartementField;
        
        private int DepartementIdField;
        
        private string EmailField;
        
        private string NumeroEtudiantField;
        
        private string ProgrammeEtudesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateDeNaissance
        {
            get
            {
                return this.DateDeNaissanceField;
            }
            set
            {
                this.DateDeNaissanceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceMetier.Departement Departement
        {
            get
            {
                return this.DepartementField;
            }
            set
            {
                this.DepartementField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DepartementId
        {
            get
            {
                return this.DepartementIdField;
            }
            set
            {
                this.DepartementIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email
        {
            get
            {
                return this.EmailField;
            }
            set
            {
                this.EmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroEtudiant
        {
            get
            {
                return this.NumeroEtudiantField;
            }
            set
            {
                this.NumeroEtudiantField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProgrammeEtudes
        {
            get
            {
                return this.ProgrammeEtudesField;
            }
            set
            {
                this.ProgrammeEtudesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Expert", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    public partial class Expert : ServiceMetier.Personne
    {
        
        private string SpecialisteField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Specialiste
        {
            get
            {
                return this.SpecialisteField;
            }
            set
            {
                this.SpecialisteField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Departement", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    public partial class Departement : object
    {
        
        private ServiceMetier.Etudiant[] EtudiantsField;
        
        private ServiceMetier.Faculte FaculteField;
        
        private int FacultéIdField;
        
        private int IdField;
        
        private string NomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceMetier.Etudiant[] Etudiants
        {
            get
            {
                return this.EtudiantsField;
            }
            set
            {
                this.EtudiantsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ServiceMetier.Faculte Faculte
        {
            get
            {
                return this.FaculteField;
            }
            set
            {
                this.FaculteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FacultéId
        {
            get
            {
                return this.FacultéIdField;
            }
            set
            {
                this.FacultéIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Faculte", Namespace="http://schemas.datacontract.org/2004/07/MetierPM.Model")]
    public partial class Faculte : object
    {
        
        private int IdField;
        
        private string NomField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom
        {
            get
            {
                return this.NomField;
            }
            set
            {
                this.NomField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMetier.IService1")]
    public interface IService1
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ServiceMetier.CompositeType GetDataUsingDataContract(ServiceMetier.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ServiceMetier.CompositeType> GetDataUsingDataContractAsync(ServiceMetier.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addExpert", ReplyAction="http://tempuri.org/IService1/addExpertResponse")]
        bool addExpert(ServiceMetier.Expert expert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addExpert", ReplyAction="http://tempuri.org/IService1/addExpertResponse")]
        System.Threading.Tasks.Task<bool> addExpertAsync(ServiceMetier.Expert expert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateExpert", ReplyAction="http://tempuri.org/IService1/updateExpertResponse")]
        bool updateExpert(ServiceMetier.Expert expert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateExpert", ReplyAction="http://tempuri.org/IService1/updateExpertResponse")]
        System.Threading.Tasks.Task<bool> updateExpertAsync(ServiceMetier.Expert expert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteExpert", ReplyAction="http://tempuri.org/IService1/deleteExpertResponse")]
        bool deleteExpert(System.Nullable<int> IdExpert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteExpert", ReplyAction="http://tempuri.org/IService1/deleteExpertResponse")]
        System.Threading.Tasks.Task<bool> deleteExpertAsync(System.Nullable<int> IdExpert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllExpert", ReplyAction="http://tempuri.org/IService1/getAllExpertResponse")]
        ServiceMetier.Expert[] getAllExpert();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllExpert", ReplyAction="http://tempuri.org/IService1/getAllExpertResponse")]
        System.Threading.Tasks.Task<ServiceMetier.Expert[]> getAllExpertAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getExpert", ReplyAction="http://tempuri.org/IService1/getExpertResponse")]
        ServiceMetier.Expert getExpert(System.Nullable<int> IdExpert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getExpert", ReplyAction="http://tempuri.org/IService1/getExpertResponse")]
        System.Threading.Tasks.Task<ServiceMetier.Expert> getExpertAsync(System.Nullable<int> IdExpert);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEtudiant", ReplyAction="http://tempuri.org/IService1/AddEtudiantResponse")]
        bool AddEtudiant(ServiceMetier.Etudiant etudiant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEtudiant", ReplyAction="http://tempuri.org/IService1/AddEtudiantResponse")]
        System.Threading.Tasks.Task<bool> AddEtudiantAsync(ServiceMetier.Etudiant etudiant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllEtudiant", ReplyAction="http://tempuri.org/IService1/getAllEtudiantResponse")]
        ServiceMetier.Etudiant[] getAllEtudiant();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllEtudiant", ReplyAction="http://tempuri.org/IService1/getAllEtudiantResponse")]
        System.Threading.Tasks.Task<ServiceMetier.Etudiant[]> getAllEtudiantAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateEtudiant", ReplyAction="http://tempuri.org/IService1/updateEtudiantResponse")]
        bool updateEtudiant(ServiceMetier.Etudiant etudiant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateEtudiant", ReplyAction="http://tempuri.org/IService1/updateEtudiantResponse")]
        System.Threading.Tasks.Task<bool> updateEtudiantAsync(ServiceMetier.Etudiant etudiant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteEtudiant", ReplyAction="http://tempuri.org/IService1/deleteEtudiantResponse")]
        bool deleteEtudiant(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deleteEtudiant", ReplyAction="http://tempuri.org/IService1/deleteEtudiantResponse")]
        System.Threading.Tasks.Task<bool> deleteEtudiantAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getEtudiant", ReplyAction="http://tempuri.org/IService1/getEtudiantResponse")]
        ServiceMetier.Etudiant getEtudiant(System.Nullable<int> IdEtudiant);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getEtudiant", ReplyAction="http://tempuri.org/IService1/getEtudiantResponse")]
        System.Threading.Tasks.Task<ServiceMetier.Etudiant> getEtudiantAsync(System.Nullable<int> IdEtudiant);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IService1Channel : ServiceMetier.IService1, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceMetier.IService1>, ServiceMetier.IService1
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
        
        public ServiceMetier.CompositeType GetDataUsingDataContract(ServiceMetier.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ServiceMetier.CompositeType> GetDataUsingDataContractAsync(ServiceMetier.CompositeType composite)
        {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool addExpert(ServiceMetier.Expert expert)
        {
            return base.Channel.addExpert(expert);
        }
        
        public System.Threading.Tasks.Task<bool> addExpertAsync(ServiceMetier.Expert expert)
        {
            return base.Channel.addExpertAsync(expert);
        }
        
        public bool updateExpert(ServiceMetier.Expert expert)
        {
            return base.Channel.updateExpert(expert);
        }
        
        public System.Threading.Tasks.Task<bool> updateExpertAsync(ServiceMetier.Expert expert)
        {
            return base.Channel.updateExpertAsync(expert);
        }
        
        public bool deleteExpert(System.Nullable<int> IdExpert)
        {
            return base.Channel.deleteExpert(IdExpert);
        }
        
        public System.Threading.Tasks.Task<bool> deleteExpertAsync(System.Nullable<int> IdExpert)
        {
            return base.Channel.deleteExpertAsync(IdExpert);
        }
        
        public ServiceMetier.Expert[] getAllExpert()
        {
            return base.Channel.getAllExpert();
        }
        
        public System.Threading.Tasks.Task<ServiceMetier.Expert[]> getAllExpertAsync()
        {
            return base.Channel.getAllExpertAsync();
        }
        
        public ServiceMetier.Expert getExpert(System.Nullable<int> IdExpert)
        {
            return base.Channel.getExpert(IdExpert);
        }
        
        public System.Threading.Tasks.Task<ServiceMetier.Expert> getExpertAsync(System.Nullable<int> IdExpert)
        {
            return base.Channel.getExpertAsync(IdExpert);
        }
        
        public bool AddEtudiant(ServiceMetier.Etudiant etudiant)
        {
            return base.Channel.AddEtudiant(etudiant);
        }
        
        public System.Threading.Tasks.Task<bool> AddEtudiantAsync(ServiceMetier.Etudiant etudiant)
        {
            return base.Channel.AddEtudiantAsync(etudiant);
        }
        
        public ServiceMetier.Etudiant[] getAllEtudiant()
        {
            return base.Channel.getAllEtudiant();
        }
        
        public System.Threading.Tasks.Task<ServiceMetier.Etudiant[]> getAllEtudiantAsync()
        {
            return base.Channel.getAllEtudiantAsync();
        }
        
        public bool updateEtudiant(ServiceMetier.Etudiant etudiant)
        {
            return base.Channel.updateEtudiant(etudiant);
        }
        
        public System.Threading.Tasks.Task<bool> updateEtudiantAsync(ServiceMetier.Etudiant etudiant)
        {
            return base.Channel.updateEtudiantAsync(etudiant);
        }
        
        public bool deleteEtudiant(System.Nullable<int> id)
        {
            return base.Channel.deleteEtudiant(id);
        }
        
        public System.Threading.Tasks.Task<bool> deleteEtudiantAsync(System.Nullable<int> id)
        {
            return base.Channel.deleteEtudiantAsync(id);
        }
        
        public ServiceMetier.Etudiant getEtudiant(System.Nullable<int> IdEtudiant)
        {
            return base.Channel.getEtudiant(IdEtudiant);
        }
        
        public System.Threading.Tasks.Task<ServiceMetier.Etudiant> getEtudiantAsync(System.Nullable<int> IdEtudiant)
        {
            return base.Channel.getEtudiantAsync(IdEtudiant);
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
                return new System.ServiceModel.EndpointAddress("http://localhost:11315/Service1.svc");
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
