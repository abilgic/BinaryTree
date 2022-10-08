using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        public class Node
        {
            public int Data;
            public Node Left;
            public Node Right;

            public Node(int data )
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }
        public Node root;
        public void PrintInOrder(Node head)
        {
            var current = head;
            if (current == null)
            {
                return;

            }
            Console.WriteLine(current.Data);
            PrintInOrder(current.Left);
            PrintInOrder(current.Right);
        }

        public  Node Insert(int Data, Node head)
        {
            var newnode = new Node(Data);
            if (head == null)
            {               
                head = newnode; 
                return newnode;
            }
            else
            {
                
                if (head.Data > Data)
                {
                    head.Left= Insert(Data, head.Left);
                    
                }
                else
                {
                    head.Right = Insert(Data, head.Right);


                }
                return head;

            }
        }
    }
}
