// Program 4
// CIS 199-03
// Due:04/18/2022
// By: S2207

// This program outputs a list of superheros and their specific traits to the console 3 times 
// On the second and third output to the console changes are made to their specific traits 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class SuperHero
    {
        private string superHeroName; // private variable for the superhero's name
        private string birthCity; // private variable for the superhero's birth city
        private string firstPower; // private variable for the superhero's first super power
        private const int defaultBirthYear = 1999; // private constant variable for the default birth year
        private int birthYear; // private variable for the superhero's birth year
        private string secondPower; // private variable for the superhero's second super power
        private bool onPlanetEarth = true; // priavte bool for if the superhero is on planet earth or not 

        public SuperHero(string SuperHeroName, string BirthCity, string FirstPower, int BirthYear, string SecondPower) // 5 parameter constuctor
        {
            superHeroName = SuperHeroName; // setting variable to parameter
            birthCity = BirthCity; // setting variable to parameter
            firstPower = FirstPower; // setting variable to parameter
            birthYear = BirthYear; // setting variable to parameter
            secondPower = SecondPower; // setting variable to parameter
            OnPlanetEarth(); // on planet earth method
            OffPlantetEarth(); // off planet earth method
        }

        public string SuperHeroName // public string for the superhero's name
        {
            get { return superHeroName; } // return superhero name 
            set { superHeroName = value; } // set the value of the public varibale to superhero name 
        }

        public string BirthCity // public string for the birth city of the superhero 
        {
            get { return birthCity; } // return birth city 
            set { birthCity = value; } // set the value of the public variable to birth city 
        }

        public string FirstPower  // public string for the superhero's first power 
        {
            get { return firstPower; } // return the first power
            set { firstPower = value; } // set the value of the public variable to the first power 
        }

        public int BirthYear // public int for birth year
        {
            get { return birthYear; } // return birth year

            set 
            {
                if (birthYear >= 0) // if birth year is above 0 
                {
                    value = birthYear; // set the value of the public variable to birth year
                }

                else // else
                {
                    value = defaultBirthYear; // set the value of the public variable to the default birth year (1999)
                }
            }  
        }

        public string SecondPower // public string for the superhero's second power
        {
            get { return secondPower; } // return second power
            set { secondPower = value; } // set the value of the public variable to second power
        }

        public char FirstLetter // public char for the first intial of the superhero
        {
            get { return SuperHeroName[0]; } // return 1st letter of superhero name by using 0 in the idnex 
        }

        public void OffPlantetEarth() // off planet earth method
        {
            onPlanetEarth = false; // on planet earth bool = false
        }

        public void OnPlanetEarth() // on planet earth method
        {
            onPlanetEarth = true; // on planet earth = true
        }

        public bool IsOnPlanetEarth() // is on planet earth method
        {
            return onPlanetEarth; // returns on planet earth bool 
        }

        public override string ToString() // overide to output string
        {
            string output;
            string NL = Environment.NewLine; // NL = new line

            output = String.Format("Name: {0}" + NL + "City: {1}" + NL + "First Super Power: {2}" + NL + "Born in: {3}" + NL + "Second Super Power: {4}" + NL + 
                     "Planet Earth: " + IsOnPlanetEarth() + NL + "Intial: {5}" + NL, superHeroName, birthCity, firstPower, birthYear, secondPower, FirstLetter); // setups format of string 

            return output; // return string output
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            SuperHero SuperHero1 = new SuperHero("Aquaman", "Atlantis", "Telepathic control of the aquatic life", 1941, "Utilizing The Sacred Trident"); // superhero ones's original traits
            SuperHero SuperHero2 = new SuperHero("Batman", "Gotham City", "Genius-level intellect", 1939, "Master of Martial Arts"); // superhero two's original traits
            SuperHero SuperHero3 = new SuperHero("Iron Man", "Long Island", "Powered Aromor Suit", 1963, "Supersonic Flight"); // superhero three's original traits
            SuperHero SuperHero4 = new SuperHero("Hulk", "Dayton", "Super human strength", 1969, "Ability to heal himself"); // superhero four's original traits
            SuperHero SuperHero5 = new SuperHero("Spiderman", "New York City", "The ability to shoot spider webs from his wrist", 2001, "Has the senses of a spider"); // superhero five's original traits

            SuperHero[] superHeros = { SuperHero1, SuperHero2, SuperHero3, SuperHero4, SuperHero5 }; // array including all 5 superheros 

            Console.WriteLine("Original list of super heros"); // writeline shows that this is the original list
            Console.WriteLine("----------------------------"); 
            PrintSH(superHeros); // prints list to the cosnole 

            SuperHero1.FirstPower = "Can swim at extreme speeds"; // calls method to change first power of 1st superhero
            SuperHero2.SecondPower = "Has many high level gadgets"; // calls method to change second power of 2nd superhero
            SuperHero3.OnPlanetEarth(); // calls on planet earth method to set bool to true for 3rd superhero
            SuperHero4.FirstPower = "Jumps really high"; // calls method to change first power of 4th superhero 
            SuperHero5.OnPlanetEarth(); // calls on planet earth method to set bool to true for 5th superhero

            Console.WriteLine("List of super heros after first set of changes"); // writeline show that this is the list after first set of changes above
            Console.WriteLine("----------------------------------------------");
            PrintSH(superHeros); // prints list after 1st set of changes to the console

            SuperHero1.OnPlanetEarth(); // calls on planet earth method to set bool to true
            SuperHero2.SecondPower = "Has many high level gadgets"; // calls method to change second power of 2nd superhero
            SuperHero3.FirstPower = "Variety of different weapons through his suit"; // calls method to change the first power of 3rd superhero
            SuperHero4.OnPlanetEarth(); // calls on planet earth method to set bool to true
            SuperHero5.SecondPower = "Can fly through the city with his spider webs"; // calls method to change the second power of the 5th superhero

            Console.WriteLine("List of super heros after second set of changes"); // writeline shows that this is the list after second set of changes above
            Console.WriteLine("-----------------------------------------------");
            PrintSH(superHeros); // print list after 2nd set of changes to the console

            Console.ReadKey(); // holds console open 
        }

        public static void PrintSH(SuperHero[] superHeroes) // method to print out all of the superheros and their traits
        {
            for (int i = 0; i < superHeroes.Length; i++) // for loop 
            {
                Console.WriteLine("Superhero " + (i + 1) + ":"); // outputs Superhero X: 
                Console.WriteLine(superHeroes[i]); // outputs specfic superheros traits below it
            }
        }
    }
}
