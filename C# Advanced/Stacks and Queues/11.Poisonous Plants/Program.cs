using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _11.Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var que = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var initLenght = que.Count;
            var c = -1;
            do
            {
                initLenght = que.Count;
                var temp = -1;
                for (int i = 0; i < initLenght; i++)
                {
                    if (i == 0)
                    {
                        temp = que.Dequeue();
                        que.Enqueue(temp);
                    }
                    else if (que.Peek() <= temp)
                    {
                        temp = que.Dequeue();
                        que.Enqueue(temp);
                    }
                    else temp = que.Dequeue();
                }
                c++;
            } while (que.Count != initLenght);

            Console.WriteLine(c);
        }
    }
}
