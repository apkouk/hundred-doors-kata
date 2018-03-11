using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataHundredDoors
{

    public class Door
    {
        public bool isOpen = false;
        public int number;

        public Door(int number)
        {
            this.number = number;
        }

        public void Toogle()
        {
            isOpen = !isOpen;
        }

    }

}
