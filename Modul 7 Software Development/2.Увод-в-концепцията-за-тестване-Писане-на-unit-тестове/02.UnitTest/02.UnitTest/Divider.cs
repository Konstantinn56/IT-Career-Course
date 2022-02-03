
namespace _02.UnitTest
{
    public class Divider
    {

        /// <summary>
        /// Деление на две числа
        /// </summary>
        /// <param name="x">1 Число</param>
        /// <param name="y">2 Число</param>
        /// <returns></returns>
        public int Divide(int x, int y)
        {
            if(y != 0)
            {
                return x / y;
            }
            return 0;
        }
    }
}
