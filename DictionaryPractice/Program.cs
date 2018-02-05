using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax - Dictionary<key data type, value data type> dictionaryName
            //when we see the word new - it automatically makes us think of instansiate
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                //body
               
                {"Kerry", 90 }, //"kerry" is the key, 90 is the value
                {"Barry", 85 },
                {"Michelle", 100 },

            }; //end of dictionary

            Dictionary<string, string> snackMachine = new Dictionary<string, string>
            {
                //body
                {"A1", "Snickers" }, // A1 is key, snickers is the value
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch Kids" },
                {"A4", "Funyuns" },
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //using the add method, let's add drinks to our drink machine.
            //this machine uses just a number to vend an item instead of  a letter-number pair.

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Mountain Dew");
            drinkMachine.Add(13, "Coke");
            drinkMachine.Add(14, "Sprite");
            drinkMachine.Add(15, "diet");

            Console.WriteLine(drinkMachine.Count);

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }//end foreach

            // create a dictionary for a theater coat check with 10 elements
            //the key will be a number and the value will be the coat style
            //print all values to the console.

            Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            coatCheck.Add(101, "Blue Pea Coat");
            coatCheck.Add(102, "Green leather jacket");
            coatCheck.Add(103, "red sport jacket");
            coatCheck.Add(104, "black leather");
            coatCheck.Add(105, "red raincoat");
            coatCheck.Add(106, "tuxedo");
            coatCheck.Add(107, "blue parka");
            coatCheck.Add(108, "blue leather jacket");
            coatCheck.Add(109, "yellow sweater jacket");
            coatCheck.Add(110, "black leather jacket");

            Console.WriteLine(coatCheck.Count);

            foreach (KeyValuePair<int, string> style in coatCheck)
            {
                Console.WriteLine(style.Key + " " + style.Value);
            }//end foreach

            //create a dictionary for a car valet service 10 cars
            //the key will be the customers last name and the value will be car make. print all keys to console.

            Dictionary<string, string> valetService = new Dictionary<string, string>();
            valetService.Add("Allison", "Volvo");
            valetService.Add("Betty", "Ford");
            valetService.Add("Carl", "Fiat");
            valetService.Add("Dave", "minivan");
            valetService.Add("Frank", "Soul");
            valetService.Add("Gina", "Civic");
            valetService.Add("Mia", "Mazda");
            valetService.Add("Steve", "Prius");
            valetService.Add("Rudy", "Cruze");
            valetService.Add("Bud", "Bolt");

            Console.WriteLine(valetService.Count);//this counts the number of items in valetService
            foreach (KeyValuePair<string, string> carType in valetService)
            {
                Console.WriteLine(carType.Value);
            }

            //create dictionary of 10 zoo animals. they key will be the animal type 
            //and the value will be the number of that animal type at the zoo.  print the animal with the highest quantity to the console..


            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                {"Lion", 4 },
                {"Bunny", 9 },
                {"Tiger", 8 },
            };

            int highest = 0;
            foreach(KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value > highest)
                {
                    highest = animal.Value;
                }
            }
            foreach (KeyValuePair<string, int> animal in zooAnimals)
            {
                if (animal.Value == highest)
                {
                    Console.WriteLine(animal.Key);
                }
            }










        }
    }
}

