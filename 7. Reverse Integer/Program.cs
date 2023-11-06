using System;
using System.Text;

namespace _7._Reverse_Integer
{
    internal class Program
    {
        private int Reverse(int x)
        {
            string strX = x.ToString();
            int starterIdx = 0, lastIdx = strX.Length - 1;
            StringBuilder sb = new StringBuilder(strX);

            if (x < 0){
                sb[0] = '-';
                starterIdx++;
            }

            for (var i = starterIdx; i < strX.Length; i++){
                sb[i] = strX[lastIdx];
                lastIdx--;
            }

            if (int.TryParse(sb.ToString(), out int result)){
                if (result < Int32.MaxValue && result > Int32.MinValue){
                    return result;
                }
            }

            return 0;
        }

        public static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.Reverse(-250)); // -52
        }
    }
}