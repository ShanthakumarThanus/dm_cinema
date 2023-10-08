using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Acteur
    {
        private int anneeNaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur() { }

        public Acteur(int anneeNaissance, int id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Acteur getInstance(int AnneeNaissance, int Id, string Nom, string Prenom)
        {
            Acteur a = new Acteur(AnneeNaissance, Id, Nom, Prenom);
            return a;
        }

        public int getId()
        {
            return Id;
        }

        public int getAnneeNaissance()
        {
            return AnneeNaissance;
        }

        public string getNom()
        {
            return Nom;
        }

        public string getPrenom()
        {
            return Prenom;
        }

        public int AnneeNaissance
        {
            get { return anneeNaissance; }
            set { anneeNaissance = value;}
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public override string ToString()
        {
            return $"Nom : {Nom}\n Prénom : {Prenom}\nAnnée de naissance : {AnneeNaissance}\nID : {Id}\n ";
        }
    }
}
