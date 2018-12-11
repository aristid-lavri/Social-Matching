using Social_Matching_Algorithm_core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Social_Matching_Algorithm_core
{
    internal class Program
    {
        // Initialisation des centres d'intérêts

        private static void Main(string[] args)
        {
            Interest[] Interests =
            {
                new Interest { Code = 01, Name="Math"},
                new Interest { Code = 02, Name="Algorithme"},
                new Interest { Code = 03, Name="Programation"},
                new Interest { Code = 04, Name="Jeux Video"},
                new Interest { Code = 05, Name="Football"},
                new Interest { Code = 06, Name="Basket"},
                new Interest { Code = 07, Name="Basket"},
                new Interest { Code = 08, Name="Reseau sociaux"},
                new Interest { Code = 09, Name="Blog"},
                new Interest { Code = 10, Name="Lecture"},
                new Interest { Code = 11, Name="Music"},
                new Interest { Code = 12, Name="Gazoil"},
                new Interest { Code = 13, Name="3D"},
                new Interest { Code = 14, Name="Photographie"},
                new Interest { Code = 15, Name="Dessin"},
                new Interest { Code = 16, Name="Mangas"},
                new Interest { Code = 17, Name="TV"},
                new Interest { Code = 18, Name="Cafe"},
                new Interest { Code = 19, Name="Billard"},
                new Interest { Code = 20, Name="SMS"},
            };

            Personne[] Parrains = new Personne[6]
            {
                new Personne
                {
                    FirstName = "A", LastName= "",PersonneType = PersonneType.Parrain,
                    PersonneInterests = new List<Interest>{
                        Interests[2],
                        Interests[4],
                        Interests[8],
                        Interests[9],
                        Interests[15],
                        Interests[7],
                        Interests[6],
                        Interests[3],
                    }
                },
                new Personne
                {
                    FirstName = "B", LastName= "",PersonneType = PersonneType.Parrain,
                    PersonneInterests = new List<Interest>{
                        Interests[3],
                        Interests[4],
                        Interests[5],
                        Interests[6],
                        Interests[7],
                        Interests[9],
                        Interests[10],
                        Interests[20],
                    }
                },
                new Personne
                {
                    FirstName = "C", LastName= "",PersonneType = PersonneType.Parrain,
                    PersonneInterests = new List<Interest>{
                        Interests[11],
                        Interests[1],
                        Interests[8],
                        Interests[9],
                        Interests[17],
                        Interests[14],
                        Interests[16],
                        Interests[3],
                    }
                },
                new Personne
                {
                    FirstName = "D", LastName= "",PersonneType = PersonneType.Parrain,
                    PersonneInterests = new List<Interest>{
                        Interests[1],
                        Interests[4],
                        Interests[12],
                        Interests[9],
                        Interests[15],
                        Interests[13],
                        Interests[6],
                        Interests[11],
                    }
                },
                new Personne
                {
                    FirstName = "E", LastName= "",PersonneType = PersonneType.Parrain,
                    PersonneInterests = new List<Interest>{
                        Interests[2],
                        Interests[5],
                        Interests[8],
                        Interests[6],
                        Interests[10],
                        Interests[14],
                        Interests[9],
                        Interests[3],
                    }
                },
                new Personne
                {
                    FirstName = "F", LastName= "",PersonneType = PersonneType.Parrain,
                    PersonneInterests = new List<Interest>{
                        Interests[4],
                        Interests[8],
                        Interests[5],
                        Interests[9],
                        Interests[15],
                        Interests[11],
                        Interests[10],
                        Interests[2],
                    }}
            };

            Personne[] Filleuls = new Personne [6]
            {
                new Personne
                {
                    FirstName = "P", LastName= "",PersonneType = PersonneType.Filleul,
                    PersonneInterests = new List<Interest>{
                        Interests[8],
                        Interests[4],
                        Interests[12],
                        Interests[10],
                        Interests[20],
                        Interests[3],
                        Interests[2],
                        Interests[6],
                    }
                },
                new Personne
                {
                    FirstName = "Q", LastName= "",PersonneType = PersonneType.Filleul,
                    PersonneInterests = new List<Interest>{
                        Interests[11],
                        Interests[1],
                        Interests[6],
                        Interests[10],
                        Interests[9],
                        Interests[13],
                        Interests[6],
                        Interests[14],
                    }
                },
                new Personne
                {
                    FirstName = "R", LastName= "",PersonneType = PersonneType.Filleul,
                    PersonneInterests = new List<Interest>{
                        Interests[2],
                        Interests[7],
                        Interests[11],
                        Interests[9],
                        Interests[15],
                        Interests[5],
                        Interests[17],
                        Interests[20],
                    }
                },
                new Personne
                {
                    FirstName = "S", LastName= "",PersonneType = PersonneType.Filleul,
                    PersonneInterests = new List<Interest>{
                        Interests[20],
                        Interests[14],
                        Interests[18],
                        Interests[19],
                        Interests[4],
                        Interests[17],
                        Interests[16],
                        Interests[13],
                    }
                },
                new Personne
                {
                    FirstName = "T", LastName= "",PersonneType = PersonneType.Filleul,
                    PersonneInterests = new List<Interest>{
                        Interests[12],
                        Interests[16],
                        Interests[14],
                        Interests[9],
                        Interests[5],
                        Interests[20],
                        Interests[10],
                        Interests[2],
                    }
                },
                new Personne
                {
                    FirstName = "U", LastName= "",PersonneType = PersonneType.Filleul,
                    PersonneInterests = new List<Interest>{
                        Interests[7],
                        Interests[3],
                        Interests[6],
                        Interests[20],
                        Interests[11],
                        Interests[19],
                        Interests[11],
                        Interests[13],
                    }
                }
            };


            Dictionary<Interest, List<Personne>> interestNeeded = new Dictionary<Interest, List<Personne>>();
            foreach (Interest item in Interests)
            {
                bool IsAllreadyIn = interestNeeded.Keys.Contains(item);
                if (!IsAllreadyIn)
                {
                    interestNeeded.Add(item, GetPersonnesForInterest(item, Filleuls));
                }
            }



            Console.ReadLine();
        }

        private static List<Personne> GetPersonnesForInterest(Interest interest, Personne[] personnes)
        {
            return personnes.Where(p => p.PersonneInterests.Contains(interest)).ToList();
        }
    }
}
