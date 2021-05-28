using System;
/*
 * Austin Rogers
 * 3/5/2021
 * Warehouse Project
 * 
 */
namespace Warehouse
{
    class WareHouses
    {
        static void Main(string[] args)
        {
               /*
                * Read inventory file to setup Warehouse objects
                * 
                * May need to modify file path to run on other machines
                */
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"C:\Users\Austin\source\repos\Warehouse\Inventory.txt");
            String line;
            String[] word;
            String[] locations = { "Atlanta", "Baltimore", "Chicago", "Denver", "Ely", "Fargo" };
            Inventory[] arr = new Inventory[6];
            for(int i = 0; i < 6; i++)
            {
                line = file.ReadLine();
                word = line.Split(", ");
                arr[i] = new Inventory(locations[i], Int32.Parse(word[0]), Int32.Parse(word[1]), Int32.Parse(word[2]), Int32.Parse(word[3]), Int32.Parse(word[4]));
            }
            
            //Displays Initial State of each Warehouse
            Console.WriteLine("Initial State of Warehouses:");
            for (int i = 0; i < 6; i++)
            {
                arr[i].Display();
            }
            Console.WriteLine("\n");

            /*
             * Beginning of Transactions
             */
            String[] log = System.IO.File.ReadAllLines(@"C:\Users\Austin\source\repos\Warehouse\Transactions.txt");
            int count = 0;
            int part;
            for(int i = 0; i < log.Length; i++)
            {
                word = log[i].Split(", ");

                //determines which warehouse to buy or sell from.
                if (word[0].Equals("S")) //for sales transactions
                {
                    count = 0;
                    part = Int32.Parse(word[1]);
                    int numParts = Int32.Parse(word[2]);
                    for(int j = 1; j < 6; j++)
                    {
                        if (arr[count].getPart(part) < arr[j].getPart(part))
                        {
                            count = j;
                        }
                    }
                    arr[count].Transaction(word[0], part, numParts);
                    Console.WriteLine(locations[count] + " has made a transaction.");
                }
                else        //for purchases
                {
                    count = 0;
                    part = Int32.Parse(word[1]);
                    int numParts = Int32.Parse(word[2]);
                    for (int j = 1; j < 6; j++)
                    {
                        if (arr[count].getPart(part) > arr[j].getPart(part))
                        {
                            count = j;
                        }
                    }
                    arr[count].Transaction(word[0], part, numParts);
                    Console.WriteLine(locations[count] + " has made a transaction.");
                }
            }
            //Final Display
            Console.WriteLine("\n");
            Console.WriteLine("End of day:");
            for (int i = 0; i < 6; i++)
            {
                arr[i].Display();
            }
        }
    }
}
