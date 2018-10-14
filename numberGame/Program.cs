using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Boolean ok = true;
                string viesti = "";
                int arvaus = 0;
                int rLuku = 0;
                Random rnd = new Random();                         //Funktiota kutsutaan pääohjelmasta näin: nopanHeitto();  															   
                rLuku = rnd.Next(1, 100);
                Console.WriteLine();
                Console.WriteLine("The computer has chosen number between 1 - 100");
                //Console.WriteLine("Luvun " + i + " silmäluku on: " + rLuku);                    
                List<int> kierrokset = new List<int>();
                while (ok == true)
                {
                    Console.WriteLine();
                    Console.Write("Guess the number? ");
                     arvaus = int.Parse(Console.ReadLine());
                    if (arvaus < rLuku)
                    {
                        Console.WriteLine();
                        viesti = "Try again. " + arvaus + "  The number is bigger.";
                        Console.WriteLine(viesti);
                        kierrokset.Add(arvaus);
                        ok = true;
                    }
                    else if (arvaus > rLuku)
                    {
                        Console.WriteLine();
                        viesti = "Try again: " + arvaus + " The number is smaller.";
                        Console.WriteLine(viesti);
                        kierrokset.Add(arvaus);
                        ok = true;
                    }
                    else
                    {
                        kierrokset.Add(arvaus);
                        Console.WriteLine();
                        viesti = "Congratulations!!!";
                        Console.WriteLine(viesti);
                        Console.WriteLine();
                        Console.WriteLine("You were right in Round {0}. Right number is: " + rLuku, kierrokset.Count);
                        Console.WriteLine();
                        Console.WriteLine();
                        ok = false;
                    }
                }
                for (int i = 0; i < kierrokset.Count; i++)      //aloitetaan FOR -silmukka. Kierroksia niin monta, kuin LISTASSA on alkioita
                {
                    Console.WriteLine();
                    Console.WriteLine("In round " + (i + 1) + " your guess was: " + kierrokset[i].ToString());
                }
                Console.WriteLine();
                Console.Write("Press enter to stop"); //Annetaan ohje siitä miten ohjelman suoritus päätetään
                Console.ReadLine();
            }
        }
}
