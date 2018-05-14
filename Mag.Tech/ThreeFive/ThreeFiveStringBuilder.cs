using System.Text;

namespace Mag.Tech.ThreeFive
{
    public class ThreeFiveStringBuilder
    {
        public string Build(int n)
        {
            if (n < 1)
            {
                return "Invalid";
            }

            var result = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {                
                result.Append(NumberToString(i));
                result.Append('\n');
            }

            return result.ToString(0, result.Length - 1);
        }

        private string NumberToString(int i)
        {
            if (i % 15 == 0)
            {
                return "ThreeFive";
            }

            if (i % 3 == 0)
            {
                return "Three";
            }

            if (i % 5 == 0)
            {
                return "Five";
            }

            return i.ToString();
        }
    }
}
