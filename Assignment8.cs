using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        public class Problem2
        {
            public static IEnumerable<int> Merge(IEnumerable<int> input1, IEnumerable<int> input2, IEnumerable<int> input3)
            {

                List<int> distinct1 = input1.Distinct().ToList();
                List<int> distinct2 = input2.Distinct().ToList();
                List<int> distinct3 = input3.Distinct().ToList();

                var input1Tri = from x in distinct1
                    where x % 3 == 0
                     select x;
                var input2Tri = from x in distinct2
                    where x % 3 == 0
                    select x;
                var input3Tri = from x in distinct3
                    where x % 3 == 0
                    select x;

                var intersect1and2 = input1Tri.Intersect(input2Tri);
                var intersect12and3 = intersect1and2.Intersect(input3Tri);

                return intersect12and3;
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var list1 = Enumerable.Range(1,10).Select(i=>(rnd.Next()%15)+1);
            var list2 = Enumerable.Range(1,10).Select(i=>(rnd.Next()%15)+1);
            var list3 = Enumerable.Range(1,10).Select(i=>(rnd.Next()%15)+1);
            var answer = Problem2.Merge(list1,list2,list3);


            foreach ( int i in answer )
            {
                Console.WriteLine(i);
            }
        }
    }
}
