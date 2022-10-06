using TaxiPark.Core;

namespace Module3HW1
{
    internal class CarComparer : IComparer<Car>
    {
        public int Compare(Car? first, Car? second)
        {
            if (first.Price > second.Price)
            {
                return 1;
            }
            else if (first.Price < second.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}