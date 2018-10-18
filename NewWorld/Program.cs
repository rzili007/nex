using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace NewWorld
{
   
    class Program
    {


        static string s;
        static DateTime d;


        static int square(int i) => i * i;


        
        static int longestPalSubstr(string str)
        {
 
         
            int maxPalin =0;

            for (int i = 0; i <str.Length; i++)
            {
                maxPalin = Math.Max(maxPalin, lenPalin(str, i));

            }

            return maxPalin;
            
        }

        private static int lenPalin(string str, int pos)
        {
            char[] charPalins = str.ToCharArray();

            int lenEven = 0, lenOdd = 0;
         
            // Odd Length 

            for (int i = 0; i <= Math.Min(pos,str.Length-2-pos); i++)
            {
                 if (charPalins[pos -i] == charPalins[pos+1 + i])
                    {
                    lenEven += 2;
                    }
                else
                {
                    break;
                }
            }

           // Even Length

            for (int i = 0; i <= Math.Min(pos-1, str.Length - 2 - pos); i++)
            {
                if (charPalins[pos -1 - i] == charPalins[pos + 1 + i])
                {
                    lenOdd += 2;
                }
                else
                {
                    break;
                }

            }
            lenOdd = lenOdd > 0 ? lenOdd + 1 : lenOdd;

            return Math.Max(lenOdd,lenEven);


        }
     static   public IEnumerable<string> GetEnumerator()
        {
            try
            {
                yield return "Hello";
                yield return "World";
                yield return "!";
            }
            finally
            {
                Console.WriteLine("In finally block!");
            }
        }

        

        static void Main(string[] args)
        {

            string userResponse;
             
            var oo = GetEnumerator();

            foreach (var item in GetEnumerator())
            {
                string userResponse;
                Console.WriteLine(item);
            }

            int assa = longestPalSubstr("aa");
            int ak = longestPalSubstr("a");
            int ikk = longestPalSubstr("ab");
            int ii = longestPalSubstr("todayannabuygrapes");
            int iii = longestPalSubstr("321wesawracecarontheradar");
            

            Database1Entities d = new Database1Entities();

            Etudiant etd = new Etudiant { Id = 1, name = "ee" };
            d.Etudiants.Add(etd);
            d.Etudiants.Remove(etd);
            try
            {
                d.SaveChanges();
            }

            catch (Exception e)
            { }








            string s;

            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);

            List<int> b = new List<int>();
            b.Add(1);
            b.Add(2);
            b.Add(3);


            var aa = b.All(z => z < 2);
            var ab = b.Any(z => z > 3);

            var numbers = new[] { 2, 4, 6, 8, 9 };
            var all = numbers.All(n => n % 2 == 0); // returns false - not all numbers are even
            var any = numbers.Any(); // returns true - there sequence contains at least one element




            Console.WriteLine(a==b);

            IEnumerable <char> query = "Text result";
            string illegals = "abcet";

            for (int i = 0; i < illegals.Length-1; i++)
            {
                query = query.Where(c => c != illegals[i]);
            }


            IEnumerable<char> newquery = query;


            foreach (var item in query)
            {
                Console.Write(item  );
            }

          
      

           
 
             
        }
    }
}
