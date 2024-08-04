using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MetierPM.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdMemoireContext : DbContext
    {

     
        public BdMemoireContext() : base("conBdMemoire1")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Expert> experts { get; set; }
        public DbSet<Etudiant> etudiants { get; set; }
        public DbSet<Directeur> directeurs { get; set; }
        public DbSet<Departement> departements { get; set; }
        public DbSet<MembreDeJury> membreDeJuries { get; set; }
        public DbSet<Memoire> memoires { get; set; }
        public DbSet<Evaluation> evaluations { get; set; }
        public DbSet<Commentaire> commentaires { get; set; }
        public DbSet<Soutenance> soutenances { get; set; }
        public DbSet<Faculte> facultes { get; set; }

        public DbSet<Td_Erreur> td_erreurs { get; set; }
    }




    
}