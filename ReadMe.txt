Implement a function called merge that does the following:
* Takes three sequences of numbers from 1 to 15
* Merge the list with members that adhere to the following requirements
* Any multiple of 3
* Is a member of all three lists
Explanation:
First get a list of multiples of three from all three lists (no repeats)
Then combine the list of threes with the intersection of all three lists (no repeats)
public class Problem2
{
  public static IEnumerable<int> merge(IEnumerable<int> input1, IEnumerable<int> input2, IEnumerable<int> input3)
  {
  }
}
static void Main(string[] args)
{
  Random rnd = new Random();
  var list1 = Enumerable.Range(1,10).Select(i=>(rnd.Next()%15)+1);
  var list2 = Enumerable.Range(1,10).Select(i=>(rnd.Next()%15)+1);
  var list3 = Enumerable.Range(1,10).Select(i=>(rnd.Next()%15)+1);
  var answer = Problem2.merge(list1,list2,list3);
  foreach( int i in answer )
  {
    Console.WriteLine(i);
  }
}