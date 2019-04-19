using System;
using System.Diagnostics;
namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node Left;
        public Node Right;
    }

    class Tree
    {
        public Node insert(Node root, int valueTown)
        {
            if(root==null)
            {
                root = new Node();
                root.value = valueTown;

            }
            else if(valueTown<root.value)
            {
                root.Left = insert(root.Left, valueTown);
            }
            else
            {
                root.Right = insert(root.Right, valueTown);
            }
            return root;
        }

        public void traverse(Node root)
        {
            if (root == null)
            {
                return;
            }
            traverse(root.Left);
            traverse(root.Right);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }
}
