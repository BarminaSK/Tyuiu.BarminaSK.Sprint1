using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BarminaSK.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            if (int.TryParse(value, out int number))
            {
                return number > 0;
            }
            return false;
        }
    }
}
