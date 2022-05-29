using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    //With the where keyword we are putting in constraints on the generic class, where it is only instanciated if ond only if the condition is met
    //The IComparable interface defines a generalized type-specific comparison method that a value type or class implements to order or sort its instances
    // The IComparable is implemented by types whose values can be ordered or sorted
    public class MyBinaryNode<T> where T : IComparable<T>
    {

        public T nodeData { get; set; }

        //declared leftTree instance for left traversal
        public MyBinaryNode<T> leftTree { get; set; }


        //declared rightTree instance for right traversal
        public MyBinaryNode<T> rightTree { get; set; }


        //Constructor to store current value of the instance
        public MyBinaryNode(T data)
        {
            this.nodeData = data;
            this.leftTree = null;
            this.rightTree = null;
        }


        //static variables to maintian state with multiple instanciation
        static int leftCount = 0, rightCount = 0;
        bool result;

        //Method/function to insert values into the tree
        public void Insert(T item)
        {
            T CurrNodeVal = this.nodeData;
            if ((CurrNodeVal.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryNode<T>(item);
                }
                else
                {
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new MyBinaryNode<T>(item);
                }
                else
                {
                    this.rightTree.Insert(item);
                }
            }
        }

        public bool Search(T element, MyBinaryNode<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.nodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST " + " " + node.nodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST ", node.nodeData);
            }
            if (element.CompareTo(node.nodeData) < 0)
            {
                Search(element, node.leftTree);
            }
            if (element.CompareTo(node.nodeData) > 0)
            {
                Search(element, node.rightTree);
            }

            return result;
        }


        //Method to generate size of the tree
        public void GetSize()
        {
            Console.WriteLine("Size of the tree is : " + " " + (1 + leftCount + rightCount));
        }
        //Method to display the tree using recursion
        public void Display()
        {
            if (this.leftTree != null)
            {
                leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                rightCount++;
                this.rightTree.Display();
            }
        }

    }
}
