namespace Module3HW1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var testList = new CustomList<int> { 10, 11, 12, 13 };
            var numberList = new CustomList<int>();
            var stringList = new CustomList<string>();

            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(5);
            numberList.Add(6);
            numberList.Add(3);
            numberList.Add(4);
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

            var comparer = new IntComparer();
            numberList.Sort(comparer);

            foreach (var item in numberList)
            {
                Console.WriteLine($"Sorted: {item}");
            }

            numberList.Clear();

            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }
        }
    }
}