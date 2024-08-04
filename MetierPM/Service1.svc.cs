using MetierPM.Model;
using MetierPM.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Entity;

namespace MetierPM
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        BdMemoireContext db = new BdMemoireContext();
        Logger logger = new Logger();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        /// <summary>
        /// Une methode  qui permet d'ajouter un expert
        /// </summary>
        /// <param name="expert"></param>
        /// <returns></returns>

        public bool addExpert(Expert expert)
        {
            try
            {
                db.experts.Add(expert);
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                logger.WriteDataError("Service1-AddExpert",ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Une methode qui permet de modifier un expert
        /// </summary>
        /// <param name="expert"></param>
        /// <returns></returns>

        public bool updateExpert(Expert expert)
        {
            try
            {
                var leExpert = db.experts.Find(expert.Id);
                if (leExpert != null)
                {
                    leExpert.Prenom = expert.Prenom;
                    leExpert.Nom = expert.Nom;
                    db.SaveChanges();
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                logger.WriteDataError("Service1-UpdateExpert", ex.ToString());
                return false;
            }

            return false;
        }

        /// <summary>
        /// Une methode qui permet de supprimer un expert
        /// </summary>
        /// <param name="IdExpert"></param>
        /// <returns></returns>

        public bool deleteExpert(int? IdExpert)
        {
            try
            {
                var leExpert = db.experts.Find(IdExpert);
                if (leExpert != null)
                {
                    db.experts.Remove(leExpert);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                logger.WriteDataError("Service1-DeleteExpert", ex.ToString());
                return false;
            }

            return false;
        }

        /// <summary>
        /// une methode qui permet d'afficher la liste des Experts
        /// </summary>
        /// <returns></returns>

        public List<Expert> getAllExpert ()
        {
            return db.experts.ToList();
        }

        /// <summary>
        /// une methode qui permet de retourner un expert
        /// </summary>
        /// <param name="idExpert"></param>
        /// <returns></returns>

        public Expert getExpert(int? IdExpert)
        {
            return db.experts.Find(IdExpert);
        }


        public bool AddEtudiant(Etudiant etudiant)
        {
            try
            {
                db.etudiants.Add(etudiant);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                logger.WriteDataError("Service1-AddExpert", ex.ToString());
                return false;
            }
        }

        public List<Etudiant> getAllEtudiant()
        {
            return db.etudiants.ToList();
        }

        public bool updateEtudiant(Etudiant etudiant)
        {
            try
            {
                var leEtudiant = db.etudiants.Find(etudiant.Id);
                if (leEtudiant != null)
                {
                    leEtudiant.Prenom = etudiant.Prenom;
                    leEtudiant.Nom = etudiant.Nom;
                    leEtudiant.Email = etudiant.Email;
                    leEtudiant.NumeroEtudiant = etudiant.NumeroEtudiant;
                    leEtudiant.DateDeNaissance = etudiant.DateDeNaissance;
                    leEtudiant.ProgrammeEtudes = etudiant.ProgrammeEtudes;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                logger.WriteDataError("Service1-UpdateEtudiant", ex.ToString());
                return false;
            }
        }

        public bool deleteEtudiant(int? id)
        {
            try
            {
                var letEtudiant = db.etudiants.Find(id);
                if (letEtudiant != null)
                {
                    db.etudiants.Remove(letEtudiant);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                logger.WriteDataError("Service1-DeleteEtudiant", ex.ToString());
                return false;
            }

            return false;
        }

        public Etudiant getEtudiant(int? IdEtudiant)
        {
            return db.etudiants.Find(IdEtudiant);
        }


        public List<Faculte> getAllFacultes()
        {
            return db.facultes.ToList();
        }



















        /// <summary>
        /// Rechercher les experts par nom, prenom et specialité
        /// </summary>
        /// <param name="Nom"></param>
        /// <param name="Prenom"></param>
        /// <param name="Specialite"></param>
        /// <returns></returns>

        /*public List<Expert> getExpertBySearch(string Nom, string Prenom, string Specialite)
        {
            var liste = db.experts.ToList();

            if(string.IsNullOrEmpty(Nom))
            {
                liste = liste.Where(a=>a.Nom.ToUpper().Contains(Nom.ToUpper())).ToList();   

            }

            if(string.IsNullOrEmpty(Prenom))
            {
                liste = liste.Where(a => a.Nom.ToUpper().Contains(Prenom.ToUpper())).ToList();

            }

            if (string.IsNullOrEmpty(Specialite))
            {
                liste = liste.Where(a => a.Nom.ToUpper().Contains(Specialite.ToUpper())).ToList();

            }

            return liste;
        }*/
    }
}
