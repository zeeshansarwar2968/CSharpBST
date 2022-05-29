using System;

namespace BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t Data Structure Problems in Binary Search Tree");
            Console.WriteLine("1. Tree Creation and Insertion.");
            Console.Write("Please choose the option to start execution : ");
            int num = Convert.ToInt32(Console.ReadLine());
            MyBinaryNode<int> binarySearchTree = new MyBinaryNode<int>(56);
            switch (num)
            {
                case 1:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
