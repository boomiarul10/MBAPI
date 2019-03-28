using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            String Str1 = Console.ReadLine();
            String Str2 = Console.ReadLine();

            long value;
            long.TryParse("12-febd-d023023e", out value);
            Console.WriteLine(value);
                
            //MakeAnagram(Str1, Str2));

        }

        static int MakeAnagram(String S1, String S2)
        {

            //List<char> IteratedChars = new List<char>();
            //for (int i = 0; i < S1.Length; i++)
            //{

            //    for (int j = 0; j < S2.Length; j++)
            //    {                    
            //        if(S1[i]==S2[j])
            //        {
            //            IteratedChars.Add(S1[i]);
            //            break;

            //        }
            //        else
            //        {
            //            if(j == S2.Length-1)
            //            {
            //                removedChars++;
            //            }
            //        }                    
            //    }
            //}

            //for (int i = 0; i < S2.Length; i++)
            //{
            //    for (int j = 0; j < S1.Length; j++)
            //    {
            //        if (S2[i] == S1[j])
            //        {
            //            IteratedChars.Add(S2[i]);
            //            break;
            //        }
            //        else
            //        {
            //            if (j == S1.Length - 1)
            //            {
            //                removedChars++;
            //            }
            //        }
            //    }
            //}

            int removedChars = 0;

            Dictionary<char, int> Dic = new Dictionary<char, int>() { { 'a',0}, { 'b', 0}, { 'c', 0 }, { 'd', 0 }, { 'e', 0 }, { 'f', 0 }, { 'g', 0 }, { 'h', 0 }, { 'i', 0 }, { 'j', 0 }, { 'k', 0 }, { 'l', 0 }, { 'm', 0 }, { 'n', 0 }, { 'o', 0 }, { 'p', 0 }, { 'q', 0 }, { 'r', 0 }, { 's', 0 }, { 't', 0 }, { 'u', 0 }, { 'v', 0 }, { 'w', 0 }, { 'x', 0 }, { 'y', 0 }, { 'z', 0 } };

            for (int i = 0; i < S1.Length; i++)
            {
                char c = S1[i];
                Dic[c]++;
            }

            for (int i = 0; i < S2.Length; i++)
            {
                char c = S2[i];
                Dic[c]--;
            }

            foreach (var item in Dic)
            {
                removedChars += Math.Abs(item.Value);
            }

            return removedChars;

        }
    }
}
