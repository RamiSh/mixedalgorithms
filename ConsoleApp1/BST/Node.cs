using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BST
{
    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public Node(int value, int level)
        {
            Value = value;
            Level = level;
        }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public int Level { get; set; }
    }
}
