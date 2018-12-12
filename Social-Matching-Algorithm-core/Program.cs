using Social_Matching_Algorithm_core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Social_Matching_Algorithm_core
{
    internal class Program
    {
        const int interestCount = 6;

        // Initialisation des centres d'intérêts
        static List<Interest> Interests = new List<Interest>
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

        static List<Personne> Parrains = new List<Personne>
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
                        Interests[19],
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

        static List<Personne> Filleuls = new List<Personne>
        {
                new Personne
                {
                    FirstName = "P", LastName= "",PersonneType = PersonneType.Filleul,
                    PersonneInterests = new List<Interest>{
                        Interests[8],
                        Interests[4],
                        Interests[12],
                        Interests[10],
                        Interests[19],
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
                        Interests[19],
                    }
                },
                new Personne
                {
                    FirstName = "S", LastName= "",PersonneType = PersonneType.Filleul,
                    PersonneInterests = new List<Interest>{
                        Interests[19],
                        Interests[14],
                        Interests[18],
                        Interests[0],
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
                        Interests[19],
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
                        Interests[0],
                        Interests[11],
                        Interests[19],
                        Interests[11],
                        Interests[13],
                    }
                }
        };

        private static void Main(string[] args)
        {
            var i = 0;

            while (i < interestCount)
            { 
                foreach (Personne item in Parrains)
                {
                    var score = 0;
                    foreach (Personne filleul in Filleuls)
                    {
                        if (filleul.PersonneInterests.Contains(item.PersonneInterests[i]))
                        {
                            var fInterestIndex = filleul.PersonneInterests.IndexOf(item.PersonneInterests[i]);
                            score = (fInterestIndex - i != 0) ? 1 : 5;

                            if (item.MatchingPersonnes == null)
                                item.MatchingPersonnes = new Dictionary<Personne, int>();

                            if (!item.MatchingPersonnes.ContainsKey(filleul))
                                item.MatchingPersonnes.Add(filleul, score);
                            else
                            {
                                item.MatchingPersonnes[filleul] += score;
                            }
                        }
                    }
                }
                i++;
            }

            Console.WriteLine("All potential matching");
            foreach (var item in Parrains)
            {
                Console.WriteLine($"Parrain: { item.FirstName}");
                foreach (var match in item.MatchingPersonnes.OrderByDescending(p=>p.Value))
                {
                    Console.Write($"match with :  {match.Key.FirstName} at {match.Value}  ");
                }
                Console.WriteLine("");
            }


            // choose best matching 
            var maxcount = Parrains.Max(p => p.MatchingPersonnes.Count);
            foreach (var item in Parrains)
            {
                var currentParrain = item;
                var others = Parrains.Where(p => p != item).ToList();

                BestMatch(ref currentParrain, ref others);
            }

            Console.WriteLine("All best matching");
            foreach (var item in Parrains)
            {
                Console.WriteLine($"Parrain: { item.FirstName}");
                foreach (var match in item.MatchingPersonnes.OrderByDescending(p => p.Value))
                {
                    Console.Write($"match with :  {match.Key.FirstName} at {match.Value}  ");
                }
                Console.WriteLine("");
            }


            Console.ReadLine();
        }

        static void BestMatch(ref Personne personne, ref List<Personne> others)
        {
            var count = personne.MatchingPersonnes.Count;
            var i = 1;
            while (count >= i)
            {
                var currentFilleul = personne.MatchingPersonnes.OrderByDescending(p=>p.Value).FirstOrDefault(p=> !p.Key.isMatched);
                foreach (var item in others)
                {
                    if(item.MatchingPersonnes.ContainsKey(currentFilleul.Key))
                    {
                        item.MatchingPersonnes.TryGetValue(currentFilleul.Key, out var filleulScore);
                        if (currentFilleul.Value >= filleulScore)
                        {
                            item.MatchingPersonnes.Remove(currentFilleul.Key);
                            personne.MatchingPersonnes.OrderByDescending(p => p.Value).FirstOrDefault().Key.isMatched = true;
                        }
                        else
                        {
                            personne.MatchingPersonnes.Remove(currentFilleul.Key);
                            break;
                        }
                    }
                }
                i++;
                //BestMatch(ref personne, ref others);
            }

        }

        private static List<Personne> GetPersonnesForInterest(Interest interest, List<Personne> personnes)
        {
            return personnes.Where(p => p.PersonneInterests.Contains(interest)).ToList();
        }
    }
}
