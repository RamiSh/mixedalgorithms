using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.LinkedList
{
    public class DoublyLinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public DoublyLinkedList(T value)
        {
            Head = new Node<T>() { Data = value };

            Tail = Head;
        }

        public void Insert(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>() { Data = value };

                if (Tail == null)
                {
                    Tail = Head;
                }

                return;
            }

            if (Head.Next == null)
            {
                Head.Next = new Node<T>() { Data = value };
                Tail = Head.Next;
                Tail.Previous = Head;
                return;
            }

            Tail.Next = new Node<T>() { Data = value };
            Tail.Next.Previous = Tail;
            Tail = Tail.Next;
        }

        public void Remove()
        {
            if(Head == null)
            {
                return;
            };

            if(Head.Next == null)
            {
                Head = Tail = null;
                return;
            }

            Tail.Previous.Next = null;
        }
    }
}
