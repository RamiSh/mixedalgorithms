using System;
using System.Collections.Generic;

namespace Datastructures
{
    public class Tree<TNode>
    {
        public TNode Root { get; set; }
    }

    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Nodes { get; set; }

        public TreeNode()
        {
            Nodes = new List<TreeNode<T>>();
        }

        public bool HasNodes => Nodes.Count > 0 ? true : false;

    }

    public class MinimaxTreeNode<T> : TreeNode<T>
    {
        public string Name { get; set; }
        public bool IsMaxNode { get; set; }

        public MinimaxTreeNode()
        {

        }
        public MinimaxTreeNode(string name, bool isMax = false)
        {
            this.IsMaxNode = isMax;
            this.Name = name;
        }

        public MinimaxTreeNode<T> AddChildNode(T nodeValue)
        {
            Nodes.Add(new MinimaxTreeNode<T>
            {
                Value = nodeValue,
                IsMaxNode = !IsMaxNode
            });

            return this;
        }
    }
}
