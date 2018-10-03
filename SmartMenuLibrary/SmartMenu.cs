using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        string[] hovedsætningArrayDansk;

        string[] hovedsaetningArrayEngelsk;

        int caseSwitch;
        public void LoadMenu(string path)
        {
            // Gemmer den danske menu i et array:
            hovedsætningArrayDansk = File.ReadLines(@"..\..\" + path + "").Take(8).ToArray(); //Take(8) - så tager den kun 8 linjer 

            // Gemmer den engelske menu i et array:
            hovedsaetningArrayEngelsk = File.ReadLines(@"..\..\" + path + "").Skip(9).Take(6).ToArray(); // Skip(9) - den springer de første 9 linjer over
        }

        public void Activate()
        {

            Console.WriteLine("Tryk på 1 for dansk \nTryk på 2 for engelsk");

            int indtastAfSprog = int.Parse(Console.ReadLine());    // En indtast fra bruger om hvilket sprog, indtast er lavet om til et tal:

            // hvis bruger intaster 1 så udskriver den menu på dansk
            //hvis bruger intaster 2 så udskriver den menu på engelsk:
            if (indtastAfSprog == 1)
            {
                // udskriver på dansk:
                for (int i = 0; i < hovedsætningArrayDansk.Length; i++)
                {
                    Console.WriteLine(hovedsætningArrayDansk[i]);
                }
            }
            else if (indtastAfSprog == 2)
            {
                //udskriver på engelsk:
                for (int i = 0; i < hovedsaetningArrayEngelsk.Length; i++)
                {
                    Console.WriteLine(hovedsaetningArrayEngelsk[i]);
                }

            }

            Console.WriteLine();

            do      // loop der gentager vores menu, hvis input ikke er 0
            {

                Console.Write("intast et tal fra menu, eller tryk 0 for at afslutte: ");
                caseSwitch = int.Parse(Console.ReadLine());   //intast fra bruger til at angive et nummer fra menupunkt

                Console.WriteLine();

                //Vores switch:
                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("du har valgt nr. 1");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("du har valgt nummer 2");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("du har valgt nummer 3");
                        Console.ReadLine();
                        break;

                    default:
                        break;

                }
            } while (caseSwitch != 0);  // condition fra do-while loop. Nå input ikke er et 0 gentages loopet igen
        }
    }
}
