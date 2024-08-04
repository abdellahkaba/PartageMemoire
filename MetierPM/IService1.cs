using MetierPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MetierPM
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        //Todo Expert

        [OperationContract]
        bool addExpert(Expert expert);

        [OperationContract]
        bool updateExpert(Expert expert);
        [OperationContract]
        bool deleteExpert(int? IdExpert);

        [OperationContract]
        List<Expert> getAllExpert();

        [OperationContract]
        Expert getExpert(int? IdExpert);

        //Todo Etudiant

        [OperationContract]
        bool AddEtudiant(Etudiant etudiant);
        [OperationContract]
        List<Etudiant> getAllEtudiant();
        [OperationContract]
        bool updateEtudiant(Etudiant etudiant);
        [OperationContract]
        bool deleteEtudiant(int? id);
        [OperationContract]
        Etudiant getEtudiant(int? IdEtudiant);

    }


    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
