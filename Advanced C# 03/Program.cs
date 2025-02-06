using System.Xml.Linq;

namespace Advanced_C__03
{

    internal class Program
    {
        //public static void ReverseQueue(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }
        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }
        //}
        //public static string IsBalancedParentheses(string s)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    Dictionary<char, char> matchingParentheses = new Dictionary<char, char>
        //{
        //    { ')', '(' },
        //    { ']', '[' },
        //    { '}', '{' }
        //};

        //    foreach (char c in s)
        //    {
        //        if (matchingParentheses.ContainsValue(c))
        //        {
        //            stack.Push(c);
        //        }
        //        else if (matchingParentheses.ContainsKey(c))
        //        {
        //            if (stack.Count == 0 || stack.Pop() != matchingParentheses[c])
        //            {
        //                return "Not Balanced";
        //            }
        //        }
        //    }

        //    return stack.Count == 0 ? "Balanced" : "Not Balanced";
        //}
        static void Main(string[] args)
        {
            #region Q1 
            //Given a Queue, implement a function to reverse the elements of a queue using a stack.
            //Queue<int> q = new Queue<int>();
            //for (int i = 1; i <= 5; i++)
            //{
            //    q.Enqueue(i);
            //}
            //ReverseQueue(q);
            //while (q.Count > 0)
            //{
            //    Console.Write(q.Dequeue() + ",");
            //}
            #endregion
            #region Q2
            //string inputString = "[()]{[]}";
            //Console.WriteLine(IsBalancedParentheses(inputString));
            #endregion
        }
    }
}
