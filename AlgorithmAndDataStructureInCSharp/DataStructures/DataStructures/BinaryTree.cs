using System;
namespace DataStructures
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {

        }

        public Node Insert(Node nodeToInsert)
        {
            return InsertHelper(root, nodeToInsert);
        }

        Node InsertHelper(Node node, Node nodeToInsert)
        {
            if (root == null)
            {
                root = nodeToInsert;
                return root;
            }
            else if (node == null)
            {
                node = nodeToInsert;
                return node;
            }
            else if (node.value == nodeToInsert.value)
            {
                return node;
            }
            else if (node.value < nodeToInsert.value)
            {
                if(node.right == null)
                {
                    node.right = nodeToInsert;
                    return node.right;
                }
                else
                {
                    return InsertHelper(node.right, nodeToInsert);
                }

            }
            else
            {
                if (node.left == null)
                {
                    node.left = nodeToInsert;
                    return node.left;
                }
                else
                {
                    return InsertHelper(node.left, nodeToInsert);
                }
            }
        }

        public Node Search(Node node, int v)
        {
            if(node == null)
            {
                return null;
            }
            else if (node.value == v)
            {
                return node;
            }
            else if (node.value < v)
            {
                return Search(node.right, v);
            }
            else
            {
                return Search(node.left, v);
            }
        }

        public void InOrderDisplayTree()
        {
            InOrderDisplayTreeHelper(root);
        }

        void InOrderDisplayTreeHelper(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.value + " ");
            InOrderDisplayTreeHelper(node.left);
            InOrderDisplayTreeHelper(node.right);
        }
    }

    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node()
        {

        }

        public Node(int v)
        {
            value = v;
        }
    }
}
