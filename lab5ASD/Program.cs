using System;

namespace lab5asd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);

            Console.WriteLine("Tree Walk");
            binaryTree.InorderTreeWalk();
            Console.WriteLine("");
            Console.WriteLine("Insert Tree Walk");
            binaryTree.ReverseInorderTreeWalk();
            Console.WriteLine();
            Console.WriteLine("NonRecursiveTreeWalk");
            binaryTree.NonRecursiveTreeWalk();
            Console.WriteLine();
            Console.WriteLine("Find Min element in tree");
            binaryTree.TreeMin();
            Console.WriteLine("Find Max element in tree");
            binaryTree.TreeMax();
            Console.WriteLine("Tree predecessor");
            binaryTree.TreePredecessor();
        }
    }
}