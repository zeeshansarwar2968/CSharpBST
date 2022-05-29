using System;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t Data Structure Problems in Binary Search Tree");
            Console.WriteLine("1. Tree Creation and Insertion.\n2. Create a specific binary tree\n3. Search the Binary Tree");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Please choose the option to start execution : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------");

            MyBinaryNode<int> binarySearchTree = new MyBinaryNode<int>(56);
            switch (num)
            {
                case 1:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
                    break;
                case 2:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    binarySearchTree.GetSize();
                    break;
                case 3:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    bool result = binarySearchTree.Search(63, binarySearchTree);
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Please Enter from the options provided.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
