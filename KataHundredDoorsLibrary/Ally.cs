using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataHundredDoors
{
    public class Ally
    {
        private ArrayList Doors = new ArrayList();

        public Ally(int numberOfDoors)
        {
            for (int i = 1; i < numberOfDoors + 1; i++)
            {
                Door door = new Door(i);
                Doors.Add(door);
            }
        }

        public ArrayList GetDoors()
        {
            return Doors;
        }      

        public void ToogleDoorsEveryOther(int numberOfDoors)
        {
            foreach (Door door in Doors)
            {
                if (door.number % numberOfDoors == 0)
                    door.Toogle();
            }
        }

        public bool LastDoorState()
        {
            Door lastDoor = (Door)Doors[Doors.Count - 1];
            return lastDoor.isOpen;
        }

        public string GetDoorsMap()
        {
            const string CLOSED = "X|";
            const string OPEN = "O|";

            string result = string.Empty;
            foreach (Door door in Doors)
            {
                result += (door.isOpen) ? OPEN : CLOSED;
            }
            return result += "\n";
        }
    }
}
