namespace LongestCommonPrefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = ["flower", "flow", "flight"];

            Console.WriteLine(LongestCommonPrefix(strs));

            Console.ReadLine();
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string output = string.Empty;
            int maxIndex = int.MaxValue;

            if (strs.Length == 1)
            {
                return strs[0];
            }

            for (int i = 0; i < strs.Length; i++)
            {
                if (maxIndex > strs[i].Length)
                {
                    maxIndex = strs[i].Length;
                }
            }

            for (int j = 0; j < maxIndex; j++)
            {
                bool same = true;
                char temp = ' ';

                for (int k = 0; k < strs.Length - 1; k++)
                {
                    temp = strs[k][j];

                    if (temp != strs[k + 1][j])
                    {
                        same = false;
                        break;
                    }
                }

                if (same)
                {
                    output += temp;
                }
                else
                    break;
            }

            return output;
        }
    }
}
