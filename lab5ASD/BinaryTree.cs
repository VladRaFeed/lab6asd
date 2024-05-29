using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5asd
{
    public class BinaryTree
    {
        public TreeNode root;

        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

        public void Delete(TreeNode node)
        {
            if (root != null)
            {
                root.Delete(root, node);
            }
        }

        public void InorderTreeWalk()
        {
            if (root != null)
            {
                root.TreeWalk(root);
            }
        }

        public void ReverseInorderTreeWalk()
        {
            if(root != null)
            {
                root.ReverseTreeWalk(root);
            }
        }

        public void NonRecursiveTreeWalk()
        {
            if (root != null)
            {
                root.NonRecursiveTreeWalk(root);
            }
        }

        public void TreeMin()
        {
            if(root != null)
            {
                root.FindTreeMin(root);
            }
        }

        public void TreeMax()
        {
            if(root != null)
            {
                root.FindTreeMax(root);
            }
        }

        public void TreePredecessor()
        {
            if(root != null)
            {
                root.TreePredecessor(root);
            }
        }

        public void BinaryTreeLeftRotate(TreeNode node)
        {
            TreeNode TempNode = node.right;
            node.right = TempNode.left;

            if (TempNode.left != null)
            {
                TempNode.left.parent = node;
            }

            TempNode.parent = node.parent;

            if (node.parent == null)
            {
                root = TempNode;
            }
            else if (node == node.parent.left)
            {
                node.parent.left = TempNode;
            }
            else
            {
                node.parent.right = TempNode;
            }

            TempNode.left = node;
            node.parent = TempNode;
        }

        public void BinaryTreeRightRotate(TreeNode node)
        {
            TreeNode TempNode = node.left;
            node.left = TempNode.right;

            if(TempNode.right != null)
            {
                TempNode.right.parent = node;
            }

            TempNode.parent = node.parent;

            if (node.parent == null)
            {
                root = TempNode;
            }
            else if(node == node.parent.right)
            {
                node.parent.right = TempNode;
            } 
            else
            {
                node.parent.left = TempNode;
            }

            TempNode.right = node;
            node.parent = TempNode;
        }
    }
}
