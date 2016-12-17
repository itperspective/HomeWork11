using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_LinkedList
{
    class Queue <T>
    {
        LinkedList<T> linkedList = new LinkedList<T>();

        public void Enqueue(T enqueue)
        {
            linkedList.AddTailNode(enqueue);
        }

        public void Dequeue()
        {
            linkedList.GetNode(linkedList.Size);
            linkedList.RemoveNode(linkedList.Size);
        }

        public void PrintQueue()
        {
            linkedList.printNodes();
        }


    }
}
