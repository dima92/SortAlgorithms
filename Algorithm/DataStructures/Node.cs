using System;

namespace Algorithm.DataStructures
{
    class Node<T>
        where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public int Index { get; set; }

        public Node(T data, int index)
        {
            Data = data;
            Index = index;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}