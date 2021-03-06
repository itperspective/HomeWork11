﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_LinkedList
{
    class Stack <T>
    {
        LinkedList<T> linkedList = new LinkedList<T>();

        public void Push(T value)
        {
            linkedList.AddHeadNode(value);
        }

        public void Pop()
        {
            linkedList.GetNode(0);
            linkedList.RemoveHeadNode();
        }

        public void Peek()
        {
            linkedList.GetNode(0);
        }

        public void PrintStack()
        {
            linkedList.printNodes();
        }
    }
}
