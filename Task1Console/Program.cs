using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Insert(5);
            tree.Insert(10);
            tree.Insert(2);
            tree.Insert(14);
            tree.Insert(1);
            tree.Insert(4);           
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(6);
            foreach (var e in tree)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
