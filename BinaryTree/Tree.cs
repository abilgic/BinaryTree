using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        private class Node
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
        private Node root;

        public  void Insert(int Data)
        {
            var newnode = new Node(Data);
            if (root == null)
            {
               
                root = newnode;
                
            }
            else
            {
                var current = root;
                if (current.Left != null)
                {
                    current=current.Left;
                }
                else
                {
                    current.Left = newnode;
                }
                if (current.Right != null)
                {
                    current = current.Right;
                }
                else
                {
                    current.Right = newnode;
                }
            }
        }
    }
}
