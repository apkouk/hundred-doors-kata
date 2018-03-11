using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataHundredDoors;


namespace HundredDoorsTest
{
    [TestClass]
    public class AllyTests
    {
        [TestMethod]
        public void all_doors_should_be_closed()
        {
            Ally ally = new Ally(99);
            foreach (Door door in ally.GetDoors())
            {
                Assert.IsFalse(door.isOpen);
            }
        }

        [TestMethod]
        public void last_door_should_be_closed()
        {
            Ally ally = new Ally(99);
            Assert.IsFalse(ally.LastDoorState());
        }

        [TestMethod]
        public void seconds_doors_should_be_open()
        {
            Ally ally = new Ally(10);
            ally.ToogleDoorsEveryOther(2);

            string allyMap = ally.GetDoorsMap();
            string expected = "X|O|X|O|X|O|X|O|X|O|\n";

            Assert.AreEqual(expected, allyMap);
        }

        [TestMethod]
        public void thirds_doors_should_be_open()
        {
            Ally ally = new Ally(10);
            ally.ToogleDoorsEveryOther(3);

            string allyMap = ally.GetDoorsMap();
            string expected = "X|X|O|X|X|O|X|X|O|X|\n";

            Assert.AreEqual(expected, allyMap);
        }
    }
}
