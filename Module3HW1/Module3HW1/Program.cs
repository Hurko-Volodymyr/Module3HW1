using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TaxiPark.Core;

namespace Module3HW1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testList = new CustomList<int> { 10, 11, 12, 13 };
            var numberList = new CustomList<int>();
            var stringList = new CustomList<string>();
            var carList = new CustomList<Car>();
            var engine = new Engine(power: 12);
            var peguot = new Pegout(engine, ConsoleColor.Magenta, 1000000, 220, mov: new MoveBySecondWheels());
            var subaru = new Subaru(engine, ConsoleColor.Cyan, 2000000, 360, mov: new MoveBySecondWheels());
            var volvo = new Volvo(engine, ConsoleColor.Green, 1500000, 250, mov: new MoveByFirstWheels());

            carList.Add(volvo);
            carList.Add(subaru);
            carList.Add(peguot);
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(6);
            numberList.Add(7);
            numberList.Add(8);

            stringList.Add("s1");
            stringList.Add("s2");
            stringList.Add("s3");
            stringList.Add("s4");
            stringList.Add("s5");
            stringList.Add("s6");

            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }

            numberList.AddRange(testList);
            Console.WriteLine(numberList.Remove(1));
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

            stringList.Remove("s1");
            foreach (var item in stringList)
            {
                Console.WriteLine(item);
            }

            numberList.RemoveAt(1);
            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

            numberList.Clear();

            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }

            foreach (var item in carList)
            {
                Console.WriteLine(item.Name);
            }

            var comparer = new CarComparer();
            carList.Sort(comparer);

            foreach (var item in carList)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}