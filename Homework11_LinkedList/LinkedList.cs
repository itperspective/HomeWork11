using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_LinkedList
{
    class LinkedList<T>
    {
        private int size;
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        } 

        Node<T> head = null;
        public void AddTailNode(T value)
        {
            Node<T> addNode = new Node<T>();
            addNode.nextNode = head;
            addNode.Value = value;
            head = addNode;

            size = size + 1;

        }

        public void AddHeadNode(T value)
        {
            Node<T> addNode = new Node<T>();
            addNode.Value = value;
            if (head == null)
            {
                addNode.nextNode = null;
                head = addNode;
                size = size + 1;
            }

            else
            {
                addNode.nextNode = null;
                Node<T> temp = head;
                while (temp != null & temp != addNode)
                {
                    if (temp.nextNode == null)
                    {
                        temp.nextNode = addNode;
                    }
                    temp = temp.nextNode;
                    size = size + 1;
                }
            }
        }

        protected bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //public void RemoveTailNode()
        //{
        //    if (IsEmpty())
        //    {
        //        Console.WriteLine("No Nodes to delete");
        //    }
        //    else
        //    {
        //        Node<T> temp = head;
        //        if (temp.nextNode == null)
        //        {
        //            head = null;
        //        }
        //        else
        //        {

        //            while (temp.nextNode != null)
        //            {
        //                if (temp.nextNode.nextNode == null)
        //                {
        //                    temp.nextNode = null;
        //                    break;
        //                }

        //                else { temp = temp.nextNode; } 
        //            }
        //        }
        //    }
        //}

        //public void RemoveHeadNode()
        //{
        //    if (IsEmpty())
        //    {
        //        Console.WriteLine("No nodes to delete");
        //    }
        //    else
        //    {
        //        head = head.nextNode;
        //    }
        //}

        public void RemoveNode (int index)
        {
            if (IsEmpty())
            {
                Console.WriteLine("No nodex to delete");
            }

            else
            {
                if (size < index)
                {
                    Console.WriteLine("Index is out of range");
                }

                
                else if (index == 0)
                {
                    Node<T> temp = head;
                    //for (int i=0; i< index-1; i++)
                    //{
                    //    temp = temp.nextNode;
                    //}

                    head = temp.nextNode;
                    temp = null;
                    
                    
                }

                else
                {
                    Node<T> temp = head;
                    for (int i = 0; i < index - 2; i++)
                    {
                        temp = temp.nextNode;
                    }

                    temp.nextNode = null;
                    size = size - 1;
                }
            }
        }

        public void GetNode(int index)
        {
            if (IsEmpty())
            {
                Console.WriteLine("No nodes available");
            }

            else
            {
                if (size < index)
                {
                    Console.WriteLine("Index is out of range");
                }
                else
                {
                    Node<T> temp = head;
                    for (int i = 0; i < index - 1; i++)
                    {
                        temp = temp.nextNode;
                    }

                    Console.WriteLine("Returned:" + temp.Value);
                }
            }
        }


        public void printNodes()
        {
            Node<T> temp = head;
            while(temp !=null)
            {
                Console.Write(" " + temp.Value + " ");
                temp = temp.nextNode;
            }
        }

    }
}
