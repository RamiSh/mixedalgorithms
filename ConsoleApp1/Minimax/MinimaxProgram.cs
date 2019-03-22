using Datastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Minimax
{
    public class MinimaxProgram
    {
        public MinimaxProgram()
        {

        }

        public static int CalculateNodesValues(MinimaxTreeNode<int> node)
        {

            if (!node.HasNodes)
            {
                return node.Value;
            }

            var childrenValues = new List<int>();

            foreach (var child in node.Nodes)
            {
                childrenValues.Add(CalculateNodesValues((MinimaxTreeNode<int>)child));
            }

            node.Value = node.IsMaxNode
                                 ? childrenValues.Max()
                                : childrenValues.Min();
            return node.Value;
        }

        static void Main(string[] args)
        {
            var gameTree = new Tree<MinimaxTreeNode<int>>
            {
                Root = new MinimaxTreeNode<int>("A", true)
            };

            var minNode1 = new MinimaxTreeNode<int>("B", false)
                .AddChildNode(3)
                .AddChildNode(12)
                .AddChildNode(8);
            gameTree.Root.Nodes.Add(minNode1);

            var minNode2 = new MinimaxTreeNode<int>("C", false)
                .AddChildNode(2)
                .AddChildNode(4)
                .AddChildNode(6);
            gameTree.Root.Nodes.Add(minNode2);

            var minNode3 = new MinimaxTreeNode<int>("D", false)
                .AddChildNode(14)
                .AddChildNode(5)
                .AddChildNode(2);
            gameTree.Root.Nodes.Add(minNode3);

            CalculateNodesValues(gameTree.Root);
            Console.ReadKey();
        }
    }
}
