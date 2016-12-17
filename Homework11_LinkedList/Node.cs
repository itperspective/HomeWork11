using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11_LinkedList
{
    class Node <T>
    {
        public T Value { get; set; }
        public Node<T> nextNode { get; set; }
    }
}
