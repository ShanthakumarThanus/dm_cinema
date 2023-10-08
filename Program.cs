using System;
using System.Net.Http.Headers;

namespace dm_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> lstFilms = new List<Film>();
            List<Acteur> lstActeur = new List<Acteur>();


            Acteur monActeur = new Acteur(1942, 1, "Ford", "Harisson");
            monActeur = monActeur.getInstance(1942, 1, "Ford", "Harisson");

            Acteur monActeur2 = new Acteur();
            monActeur2 = monActeur2.getInstance(1956, 2, "Hanks", "Tom");



            Film monFilm = new Film();
            monFilm = monFilm.getInstance(1982, "Science-Fiction", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner", monActeur);

            Film monFilm2 = new Film();
            monFilm2 = monFilm2.getInstance(1992, "Animation", 2, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.", "Toy Story", monActeur2);


            Cinema monCinema = new Cinema();
            monCinema.getActeur(monActeur);
            monCinema.getActeur(monActeur2);


            lstFilms.Add(monFilm);
            lstFilms.Add(monFilm2);

            lstActeur.Add(monActeur);
            lstActeur.Add(monActeur2);


            foreach (Film film in lstFilms)
            {
                Console.WriteLine(film.ToString());
            }
        }
    }
}

