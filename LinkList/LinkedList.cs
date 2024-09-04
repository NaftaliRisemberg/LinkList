using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class LinkedList
    {
        private Node Head;

        public LinkedList()
        {
            Head = null;
        }

		public LinkedList(int data)
		{
            Head.SetValue(data);
		}


		public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
                Head = newNode; 
            else 
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
                    

        public string Display()
        {
            Node current = Head;
            string values = "";
            if (current != null)
            {
                values += current.Data;
                current = current.Next;
            }
            while (current != null)
            {
                values += " -> " + current.Data;
                current = current.Next;
            }
            return values;
        }

        
        public int Length()
        {
            int length = 0;
            Node current = Head;
            while (current != null)
            {
                current = current.Next;
                length++;
            }
            return length;
        }

		public void RemoveValue(int data)
        {
            Node current = Head;
            if (current == null)
            {
                return;
            }
            if (current.Data == data)
            {
                Head = Head.Next;
            }
            else
            {
                while (current.Next != null)
                {
					if (current.Next.Data == data)
					{
						Node tmp = current.Next.Next;
						current.SetNext(tmp);
                        return;
					}
					current = current.Next;
				}
			}
        }

		public void RemoveAllValues(int data)
		{
			while (Head != null && Head.Data == data)
			{
				Head = Head.Next;
			}
			
            Node current = Head;
            if (Head == null)
            {
                return;
            }
            
            else
            {
                while (current != null)
                {
					if (current.Next.Data == data)
					{
						Node tmp = current.Next.Next;
						current.SetNext(tmp);
					}
					current = current.Next;

				}
            }
		}

		public void RemoveIndex(int index)
        {
            Node current = Head;
            if (current == null)
            {
                return;
            }
            int count = 0;
            while (current != null && count != index)
            {
                if (index == count)
                {
                    Node tmp = current.Next.Next; 
                    current.SetNext(tmp);
                    return;
                }
                current = current.Next;
                count++;
            }
            return;
        }

	}
}
				

							
