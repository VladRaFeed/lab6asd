using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5asd
{
    public class TreeNode
    {
        public int key;
        public TreeNode parent;
        public TreeNode left;
        public TreeNode right;

        public TreeNode()
        {
            key = 0;
            left = null;
            right = null;
        }

        public TreeNode(int key)
        {
            this.key = key;
            left = null;
            right = null;
        }

        public void Insert(int value)
        {
            if (value >= key)
            {
                if (right == null)
                {
                    right = new TreeNode(value);
                }
                else
                {
                    right.Insert(value);
                }
            }
            else
            {
                if (left == null)
                {
                    left = new TreeNode(value);
                }
                else
                {
                    left.Insert(value);
                }
            }
        }

        public void Delete(TreeNode root, TreeNode node)
        {
            if(node.left == null)
            {
                Transplant(root, node, node.right);
            } 
            else if(node.right == null)
            {
                Transplant(root, node, node.left);
            } 
            else
            {
                TreeNode y = FindTreeMin(node.right);
                if(y.parent != node)
                {
                    Transplant(root, y, y.right);
                    y.right = node.right;
                    y.right.parent = y;
                }
                Transplant(root, node, y);
                y.left = node.left;
                y.left.parent = y;
            }
        }

        public void Transplant(TreeNode root, TreeNode FirstNode, TreeNode SecondNode)
        {
            if(FirstNode.parent == null)
            {
                root = SecondNode;
            } 
            else if (FirstNode == FirstNode.parent.left)
            {
                FirstNode.parent.left = SecondNode;
            } 
            else
            {
                FirstNode.parent.right = SecondNode;
            }

            SecondNode.parent = FirstNode.parent;
        }

        public void TreeWalk(TreeNode node)
        {
            if (node.left != null)
            {
                node.left.TreeWalk(node.left);
            }

            Console.Write(node.key + " ");

            if (node.right != null)
            {
                node.right.TreeWalk(node.right);
            }
        }

        public void ReverseTreeWalk(TreeNode node)
        {
            if(node.right != null)
            {
                node.right.ReverseTreeWalk(node.right);
            }

            Console.Write(node.key + " ");

            if(node.left != null)
            {
                node.left.ReverseTreeWalk(node.left);
            }
        }

        public void NonRecursiveTreeWalk(TreeNode node)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode current = node;

            while(current != null || stack.Count > 0)
            {
                while(current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                current = stack.Pop();
                Console.Write(current.key + " ");
                current = current.right;
            }
        }

        public TreeNode FindTreeMin(TreeNode node)
        {
            if(node.left != null)
            {
                FindTreeMin(node.left);
            } else
            {
                Console.WriteLine("Min element: " + node.key);
            }
            return node;
        }

        public void FindTreeMax(TreeNode node)
        {
            if (node.right != null)
            {
                FindTreeMax(node.right);
            }
            else
            {
                Console.WriteLine("Max element: " + node.key);
            }
        }

        public void TreePredecessor(TreeNode node)
        {
            if(node.left != null)
            {
                node = node.left;
                Console.WriteLine("Predecessor of this tree: ");
                FindTreeMax(node);
            } else
            {
                Console.WriteLine("Error! This tree haven`t predecessor, because left tree does not exist");
            }
        }
    }
}
