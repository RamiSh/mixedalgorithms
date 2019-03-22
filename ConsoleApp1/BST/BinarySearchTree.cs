using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BST
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node(value, 0);
            }
            else
            {
                InsertNode(Root, value, 1);
            }
        }

        private void InsertNode(Node root, int value, int level)
        {
            if (value >= root.Value)
            {
                if (root.Right == null)
                {
                    root.Right = new Node(value, level);
                }
                else
                {
                    InsertNode(root.Right, value, ++level);
                }
            }
            else
            {
                if (root.Left == null)
                {
                    root.Left = new Node(value, level);
                }
                else
                {
                    InsertNode(root.Left, value, ++level);
                }
            }
        }

        public List<Node> InorderTraversal(Node root)
        {
            if(root == null)
            {
                return new List<Node>();
            }

            var res = new List<Node>();
            res.AddRange(InorderTraversal(root.Left));
            res.Add(root);
            res.AddRange(InorderTraversal(root.Right));

            return res;
        }

        public List<Node> BreadthFirstTraversal(int level)
        {
            var visitedNodes = new List<Node>();
            var toBeVisitedNodes = new Queue<Node>();

            var scanner = Root;

            while (scanner != null && (scanner.Level <= level || level == -1))
            {
                
                visitedNodes.Add(scanner);

                if (scanner.Right != null)
                {
                    toBeVisitedNodes.Enqueue(scanner.Right);
                }

                if (scanner.Left != null)
                {
                    toBeVisitedNodes.Enqueue(scanner.Left);
                }

                if (toBeVisitedNodes.Any())
                {
                    scanner = toBeVisitedNodes.Dequeue();
                }
                else
                {
                    scanner = null;
                }
            }

            return visitedNodes;
        }
        public List<Node> BreadthFirstTraversal()
        {
            return BreadthFirstTraversal(-1);
        }
    }
}
