using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinkedLists
{
    class Program
    {
        public class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node(T i)
            {
                this.data = i;
                this.next = null;

            }

        }
        public class LinkedList<T>
        {
            Node<T> head, tail;
            int size;
            public LinkedList()
            {

                this.head = null;
                this.tail = null;
                size = 0;
            }

            public void AddFirst(T data)
            {
                Node<T> node = new Node<T>(data);
                if (head == null)
                {
                    node.next = head;
                    tail = node;
                    head = node;
                    size++;
                    return;

                }
                node.next = head;

                head = node;
                Console.WriteLine(tail.data);
                size++;

            }
            public void DeleteFirstElement()
            {
                if (head == null)
                {

                    return;
                }
                if (head == tail)

                {
                    head = tail = null;
                    size--;
                    return;
                }
                head = head.next;
                size--;

            }
            public void DeleteLastElement()
            {
                if (head == null)
                    return;
                if (head == tail)
                {
                    DeleteFirstElement();
                    return;
                }
                Node<T> current = head, previous = null;
                Console.WriteLine(current.data);
                while (current != tail)
                {
                    previous = current;
                    current = current.next;
                    Console.WriteLine(previous.data);
                    Console.WriteLine(current.data);

                }
                previous.next = null;
                tail = previous;
                size--;
            }
            public void Delete(T data)
            {
                Node<T> current = head, previous = null;
                while (current != null)
                {
                    if (current.data.Equals(data))
                    {
                        if (current == head)
                        {
                            DeleteFirstElement();
                            size--;
                            return;
                        }

                        if (current == tail)
                        {
                            DeleteLastElement();
                            size--;
                            return;
                        }

                        previous.next = current.next;
                    }
                    previous = current;
                    current = current.next;
                }

            }
            public void Print()
            {
                Node<T> n = head;
                
                while(n!=null)
                {
                    Console.Write(n.data.ToString() + "-->");

                    n = n.next;
                    
                }
            }
            public void AddLast(T data)
            {
                Node<T> node = new Node<T>(data);
                if(head==null)
                {
                    head = node;

                    tail = node;
                    size++;
                    return;
                }

                tail.next = node;
                tail = node;
                size++;
                Console.WriteLine(tail.data);
            }
        }
            public static void Main(string[] args)
            {
                Node<int> one = new Node<int>(100);
                LinkedList<int> _linked = new LinkedList<int>();
            _linked.DeleteLastElement();
            _linked.AddFirst(100);
            _linked.DeleteLastElement();
            _linked.AddFirst(102);
                 _linked.AddFirst(1033);
           _linked.AddLast(1000);
            _linked.AddLast(200);
            _linked.AddLast(2002);
           
            _linked.Print();
            Console.WriteLine();
            _linked.DeleteLastElement();


            _linked.Print();
            _linked.Delete(1000);
            Console.WriteLine();
            _linked.Print();
              Console.ReadLine();
            }
    }
    
}
