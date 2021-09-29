using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionInterfaceDemo
{

    //  This program demo. how to sort collection using IComparer Interface.
    class IComparerDemo
    {
        static void Main()
        {
            List<Display> displays = new List<Display>
            {
                new Display{ PPI=100,Resolution="1024*768",Size="15-inches"},
                new Display{PPI=90,Resolution="1120*750",Size="16-inches" },
                new Display{PPI=85,Resolution="1200*700",Size="19-inches" }
            };
            SortDisplay sortDisplay = new SortDisplay();
            displays.Sort(sortDisplay);

            foreach (var display in displays)
            {
                Console.WriteLine($"PPI={display.PPI}\t Resolution={display.Resolution}\t Size={display.Size}");
            }
            Console.ReadLine();
        }
    }
}
