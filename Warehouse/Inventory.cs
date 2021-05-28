using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    class Inventory
    {
        String location;
        public int part102 = 0;
        public int part215 = 0;
        public int part410 = 0;
        public int part525 = 0;
        public int part711 = 0;

        public Inventory(String loc, int p1, int p2, int p4, int p5, int p7) //contructor 
        {
            location = loc;
            part102 = p1;
            part215 = p2;
            part410 = p4;
            part525 = p5;
            part711 = p7;
        }
        public void Display()   //Simple Display for location and number of each part
        {
            Console.WriteLine(location);
            Console.WriteLine(part102 + " " + part215 + " " + part410 + " " + part525 + " " + part711);
        }
        public int getPart(int partNum)//Used to compare number of a specific part
        {                              //a warehouse has in stock to determine buyers and sellers
            int num = 0;
            switch (partNum)
            {
                case 102:
                    num = part102;
                    break;
                case 215:
                    num = part215;
                    break;
                case 410:
                    num = part410;
                    break;
                case 525:
                    num = part525;
                    break;
                case 711:
                    num = part711;
                    break;
                default:
                    break;
            }
            return num;
        }
        public void Transaction(String a, int part, int numParts)
        {
            if (a.Equals('S'))  //Determines if the parts will be added or subtracted from the warehouse(P/S)
            {
                numParts = -numParts;
            }
            switch (part)       //Chooses part specified by the transaction
            {
                case 102:
                    part102 += numParts;
                    break;
                case 215:
                    part215 += numParts;
                    break;
                case 410:
                    part410 += numParts;
                    break;
                case 525:
                    part525 += numParts;
                    break;
                case 711:
                    part711 += numParts;
                    break;
                default:
                    break;
            }
        }


    }
    
}
