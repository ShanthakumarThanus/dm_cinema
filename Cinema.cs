using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Cinema
    {
        private Cinema cine;
        private List<Acteur> lesActeurs;
        private List<Film> lesFilms;

        public Cinema()
        {
            this.lesActeurs = new List<Acteur>();
            this.lesFilms = new List<Film>();
        }

        public Cinema Cine
        {
            get { return cine; }
            set { cine = value; }
        }

        public List<Acteur> LesActeurs
        {
            get { return lesActeurs; }
            set { lesActeurs = value; }
        }

        public List<Film> LesFilms
        {
            get { return lesFilms; }
            set { lesFilms = value; }
        }

        public Cinema getInstance()
        {
            Cinema c = new Cinema();
            return c;
        }

        public Acteur getActeur(Acteur Id)
        {
            return Id;
        }

        public Film getFilm(Film Id)
        {
            return Id;
        }

        public int nbActeur()
        {
            return this.lesActeurs.Count();
        }

        public void setFilm(int Annee, string Genre, int IdFilm, string Resume, string Titre, Acteur Acteur)
        {
            this.LesFilms.Add(new Film(Annee,Genre,IdFilm,Resume,Titre, Acteur));
        }

        public void setActeur(int AnneeNaissance, int Id, string Nom, string Prenom)
        {
            this.LesActeurs.Add(new Acteur(AnneeNaissance, Id, Nom, Prenom));
        }
    }
}
