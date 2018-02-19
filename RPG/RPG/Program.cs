using RPG.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        private static Сharacter GetPersonFirst()
        {
            Сharacter PersonFirst = new Сharacter();
            PersonFirst.Name = "Donald";
            PersonFirst.Sex = TypeSex.Male;
            PersonFirst.Grade = new Grade()
            {
                GradePerson = TypePerson.Paladin
            };
            PersonFirst.Race = new Race()
            {
                RacePerson = TypeRace.Human
            };

            return PersonFirst;
        }

        private static Сharacter GetPersonSecond()
        {
            Сharacter PersonSecond = new Сharacter();
            PersonSecond.Name = "Schwartz";
            PersonSecond.Sex = TypeSex.Male;
            PersonSecond.Grade = new Grade()
            {
                GradePerson = TypePerson.Druid
            };
         
            PersonSecond.Race = new Race()
            {
                RacePerson = TypeRace.Dwarf
            };
            

            return PersonSecond;
        }

        private static Сharacter GetPersonThree()
        {
            Сharacter PersonThree = new Сharacter();
            PersonThree.Name = "Lisa";
            PersonThree.Sex = TypeSex.Female;
            PersonThree.Grade = new Grade()
            {
                GradePerson = TypePerson.Rogue
            };
            PersonThree.Race = new Race()
            {
                RacePerson = TypeRace.Elf
            };
           

            return PersonThree;
        }

        private static Сharacter GetPersonFourth()
        {
            Сharacter PersonFourth = new Сharacter();
            PersonFourth.Name = "Sonia";
            PersonFourth.Sex = TypeSex.Female;
            PersonFourth.Grade = new Grade()
            {
                GradePerson = TypePerson.Mage
            };
           
            PersonFourth.Race = new Race()
            {
                RacePerson = TypeRace.Gnome
            };
           

            return PersonFourth;
        }

        private static Сharacter GetPersonFifth()
        {
            Сharacter PersonFifth = new Сharacter();
            PersonFifth.Name = "Rexar";
            PersonFifth.Sex = TypeSex.Male;
            PersonFifth.Grade = new Grade()
            {
                GradePerson = TypePerson.Hunter
            };

            PersonFifth.Race = new Race()
            {
                RacePerson = TypeRace.Orc
            };


            return PersonFifth;
        }

        private static Сharacter GetPersonSixth()
        {
            Сharacter PersonSixth = new Сharacter();
            PersonSixth.Name = "Gul'dan";
            PersonSixth.Sex = TypeSex.Male;
            PersonSixth.Grade = new Grade()
            {
                GradePerson = TypePerson.Warlock
            };

            PersonSixth.Race = new Race()
            {
                RacePerson = TypeRace.Orc
            };


            return PersonSixth;
        }

        private static Сharacter GetPersonSeventh()
        {
            Сharacter PersonSeventh = new Сharacter();
            PersonSeventh.Name = "Garrosh";
            PersonSeventh.Sex = TypeSex.Male;
            PersonSeventh.Grade = new Grade()
            {
                GradePerson = TypePerson.Warrior
            };

            PersonSeventh.Race = new Race()
            {
                RacePerson = TypeRace.Dwarf
            };


            return PersonSeventh;
        }

        static void Main(string[] args)
        {
            Сharacter PersonFirst = GetPersonFirst();
            Сharacter PersonSecond = GetPersonSecond();
            Сharacter PersonThree = GetPersonThree();
            Сharacter PersonFourth = GetPersonFourth();
            Сharacter PersonFifth = GetPersonFifth();
            Сharacter PersonSixth = GetPersonSixth();
            Сharacter PersonSeventh = GetPersonSeventh();


            List<Сharacter> Persons = new List<Сharacter>
            {
                PersonFirst,
                PersonSecond,
                PersonThree,
                PersonFourth,
                PersonFifth,
                PersonSixth,
                PersonSeventh
            };
            WritePersonInfo(Persons);
            Console.WriteLine("Сортировка персонажей по полу ------------------;\n");
            SortByFretsCount(Persons);
            WritePersonInfo(Persons);
            Console.ReadKey();
        }

        private static void SortByFretsCount(List<Сharacter> Persons)
        {
            for (int i = 0; i < Persons.Count; i++)
            {
                for (int j = 0; j < Persons.Count - i - 1; j++)
                {
                    
                    
                        if (Persons[j].Sex > Persons[j + 1].Sex)
                        {
                            Сharacter temp = Persons[j];
                            Persons[j] = Persons[j + 1];
                            Persons[j + 1] = temp;
                        }
                    
                    else
                    {
                        if (Persons[j].Sex > Persons[j + 1].Sex)
                        {
                            Сharacter temp = Persons[j];
                            Persons[j] = Persons[j + 1];
                            Persons[j + 1] = temp;
                        }
                    }
                }
            }
        }

        private static void WritePersonInfo(List<Сharacter> Persons)
        {
            Console.WriteLine("list of characters:\r\n");
            int n = 1;
            foreach (var Person in Persons)
            {
                Console.WriteLine($"Сharacter {n}:\r\n");
                n++;
                string PersonInfo = $"Character's name: {Person.Name}\r\n" +
                    $"Character's sex: {Person.Sex}\r\n" +
                    $"Character's class: { Person.Grade.GradePerson}\r\n" +
                    $"Character's race: {Person.Race.RacePerson}\r\n";
                Console.WriteLine(PersonInfo);
                
            }
        }
    }
}
