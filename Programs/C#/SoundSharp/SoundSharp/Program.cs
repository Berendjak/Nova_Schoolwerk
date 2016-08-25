using System;
using System.Collections;
using System.Linq;

namespace SoundSharp
{
    public class Load
    {
        internal static void LogIn()
        {
            Console.WriteLine("Name: ");
            string strName = Console.ReadLine();
            Console.WriteLine("Password: ");
            string strPass = Console.ReadLine();

            int a = 1;

            const string password = "ja";
            int passTry = 3;

            while (a == 1)
            {
                if (strName == String.Empty)
                {
                    Console.WriteLine("You didn't enter anything");
                    Console.WriteLine("Name: ");
                    strName = Console.ReadLine();
                }
                else
                {
                    a++;
                }
            }
            while (a == 2)
            {
                if (strPass == String.Empty)
                {
                    Console.WriteLine("You didn't enter anything");
                    Console.WriteLine("Password: ");
                    strPass = Console.ReadLine();
                }
                else if (strPass != password)
                {
                    passTry--;
                    if (passTry == 2)
                    {
                        Console.WriteLine("Invalid! 2 attemps left!");
                        Console.WriteLine("Password: ");
                        strPass = Console.ReadLine();
                    }
                    else if (passTry == 1)
                    {
                        Console.WriteLine("Invalid! 1 attemps left!");
                        Console.WriteLine("Password: ");
                        strPass = Console.ReadLine();
                    }
                    else if (passTry == 0)
                    {
                        Console.WriteLine("Invalid! 0 attemps left! System shut off!");
                        Console.ReadLine();
                        System.Environment.Exit(1);
                    }
                }
                else
                {
                    Console.WriteLine("\nWelcome to SoundSharp {0}\n", strName);
                    a++;
                }
            }
        }

        internal static void ShowMenu()
        {
            string strMenuInput = Console.ReadLine();
            int a = 2;
            while (a == 2)
            {
                if (string.IsNullOrEmpty(strMenuInput))
                {
                    Console.WriteLine("You didn't enter anything!");
                    a--;
                }
                else if (!strMenuInput.All(char.IsDigit))
                {
                    Console.WriteLine("\bPlease enter a number between 1 and 9");
                    a--;
                }

                else
                {
                    switch (strMenuInput)
                    {
                        case "1":
                            showProducts();
                            break;
                        case "2":
                            showStock();
                            break;
                        case "3":
                            NewStock();
                            break;
                        case "4":
                            showStats();
                            break;
                        case "5":
                            Mp3Add();
                            break;
                        case "8":
                            menuAgain();
                            break;
                        case "9":
                            menuLeave();
                            break;
                    }
                }
            }
        }

        static void showProducts()
        {
            foreach (ProductInfo p in MP3.GetPlayers())
            {
                Console.WriteLine("MP3 Player " + p.intId + "\n");
                Console.WriteLine("Make:\t\t" + p.strMake);
                Console.WriteLine("Model:\t\t" + p.strModel);
                Console.WriteLine("Size(Mb):\t" + p.dblSize);
                Console.WriteLine("Price:\t\t$" + p.dblPrice + "\n");
            }
            ShowMenu();
        }

        static void showStock()
        {
            foreach (ProductInfo p in MP3.GetPlayers())
            {
                Console.WriteLine("MP3 Player " + p.intId + "");
                Console.WriteLine("Stock: " + p.intStock + "\n");
            }
            ShowMenu();
        }

        static void NewStock()
        {
            Console.WriteLine("Vul het ID in van de MP3 speler: ");
            string mutateID = Console.ReadLine();
            if (string.IsNullOrEmpty(mutateID) || !mutateID.All(char.IsDigit))
            {
                Console.WriteLine("Wrong ID input!");
                NewStock();
            }
            else
            {
                int intMutateID = int.Parse(mutateID);
                foreach (ProductInfo p in MP3.GetPlayers())
                {
                    if (intMutateID == p.intId)
                    {
                        Console.WriteLine("Vul nieuwe stock waarde in:");
                        string strStock = Console.ReadLine();
                        int intNewStock = int.Parse(strStock);
                        if (strStock == string.Empty)
                        {
                            Console.WriteLine("You didn't enter anything");
                        }
                        else if (!strStock.All(char.IsDigit))
                        {
                            Console.WriteLine("You entered an invalid new stock!");
                        }
                        else
                        {
                            p.Storage = intNewStock;
                            Console.WriteLine("You have succesfully updated the stock for MP3 player {0} to {1}",
                                p.intId,
                                p.intStock);
                            ShowMenu();
                        }
                    }
                }
            }
            ShowMenu();
        }
        static void showStats()
        {
            string[] subMenuArray =
                    {
                        "\n1. Het totale aantal mp3 spelers dat in voorraad is",
                        "2. De totale waarde van de voorraad mp3 spelers",
                        "3. De gemiddelde prijs van een mp3 speler bij SoundSharp",
                        "4. De mp3 speler met de beste prijs per Mb (= prijs mp3 speler/opslagcapaciteit)"
                    };
            foreach (string Menu in subMenuArray)
            {
                Console.WriteLine(Menu);
            }
            ShowMenu();
        }

        static void Mp3Add()
        {
            Console.WriteLine("Enter a new Mp3 player");
            foreach (ProductInfo p in MP3.GetPlayers())
            {
                Console.WriteLine("Make: ");
                string make = Console.ReadLine();
                Console.WriteLine("Model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Mb Size: ");
                double size = double.Parse(Console.ReadLine());
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());

                int id = MP3.Product.Count + 1;

                MP3.Product.Add(new ProductInfo(id,make, model, size, price));
                ShowMenu();
            }
        }
        static void menuAgain()
        {
            string[] menuArray =
                    {
                        "1. Overview mp3 players", "2. Overview stock", "3. Mutate stock", "4. Statistics",
                        "5. Add new mp3",
                        "8. Menu", "9. Exit"
                    };
            foreach (string Menu in menuArray)
            {
                Console.WriteLine(Menu);
            }
            ShowMenu();
        }
        static void menuLeave()
        {
            Console.WriteLine("\bAre you sure you want to leave the menu?(y/n)");
            string charLeave = Console.ReadLine();
            if (charLeave == "y" || charLeave == "Y")
            {
                LogIn();
            }
            else if (charLeave == "n" || charLeave == "N")
            {
                ShowMenu();
            }
            else
            {
                Console.WriteLine("\bInvalid action!");
            }
        }
    }



class Program
    {
        private static void Main(string[] args)
        {
            int a = 1;
            Load check = new Load();
            MP3.Mp3Info();
            
            Console.WriteLine("SoundSharp\n");

            while (a == 1)
            {
                Load.LogIn();
                a++;
            }
            Console.WriteLine("----MENU----\n");
            string[] menuArray = {"1. Overview mp3 players", "2. Overview stock","3. Mutate stock", "4. Statistics", "5. Add new mp3",
             "8. Menu", "9. Exit"};

            foreach (string Menu in menuArray)
            {
                Console.WriteLine(Menu);
            }
            while (a == 2)
            {
                Load.ShowMenu();
            }
        }
    }
}
