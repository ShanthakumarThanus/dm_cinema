using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    public class Film
    {
        private int annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film() { }
        public Film(int annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurPrincipal;
        }

        public int getAnnee()
        {
            return Annee;
        }

        public string getGenre()
        {
            return Genre;
        }

        public int getIdFilm()
        {
            return IdFilm;
        }

        public string getResume()
        {
            return Resume;
        }

        public string getTitre()
        {
            return Titre;
        }

        public Film getInstance(int Annee, string Genre, int IdFilm, string Resume, string Titre, Acteur ActeurPrincipal)
        {
            Film f = new Film(Annee, Genre, IdFilm, Resume, Titre, ActeurPrincipal);
            return f;
        }

        public Acteur getActeurPrincipal(Acteur a)
        {
            return a;
        }

        public int Annee
        {
            set { annee = value; }
            get { return annee; }
        }

        public string Genre
        {
            set { genre = value; }
            get { return genre; }
        }

        public int IdFilm
        {
            set { idFilm = value; }
            get { return idFilm; }
        }

        public string Resume
        {
            set { resume = value; }
            get { return resume; }
        }

        public string Titre
        {
            set { titre = value; }
            get { return titre; }
        }

        public Acteur ActeurPrincipal
        {
            set { acteurPrincipal = value; }
            get { return  acteurPrincipal; }
        }

        public override string ToString()
        {
            return $"Titre : {Titre}\nAnnée : {Annee}\nGenre : {Genre}\nRésumé : {Resume}\nActeur Principal :{ActeurPrincipal}";
        }
    }
}
