using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//100 doors in a row are all initially closed. You make
//100 passes by the doors. The first time through, you
//visit every door and toggle the door (if the door is
//closed, you open it; if it is open, you close it).
//The second time you only visit every 2nd door (door
//#2, #4, #6, ...). The third time, every 3rd door
//(door #3, #6, #9, ...), etc, until you only visit
//the 100th door.

//Question: What state are the doors in after the last
//pass? Which are open, which are closed?

namespace KataHundredDoors
{
    class Program
    {
        static void Main(string[] args)
        {
            Ally ally = new Ally(1032);

            for (int i = 1; i < ally.GetDoors().Count + 1; i++)
            {
                //Console.WriteLine("PASS : " + i + "\n");
                ally.ToogleDoorsEveryOther(i);
                Console.WriteLine(ally.GetDoorsMap());
            }

            Console.WriteLine("Last door is " + ally.LastDoorState().ToString());

            Console.ReadLine();
        }
    }
}
