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
        private const string CLOSED = "X|";
        private const string OPEN = "O|";
        
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

        public string GetDoorsMap()
        {
            string result = string.Empty;
            foreach (Door door in Doors)
            {
                result += (door.isOpen) ? OPEN : CLOSED;
            }
            return result += "\n";
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
            foreach (Door door in Doors)
            {
                if (door.number == Doors.Count)
                    return door.isOpen;
            }
            return false;
        }
    }
}
