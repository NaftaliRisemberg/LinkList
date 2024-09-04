using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
	public class Stack
	{

		private Node Head;
		public Stack()
		{
			this.Head = Head;

		}

		public void Push(int data)
		{

			Node newNode = new Node(data);
			if (newNode == null)
			{
				return;
			}
			newNode.Next = Head;
			Head = newNode;
			return;
		}
		public int Peek()
		{
			if (Head != null)
			{
				return Head.Data;
			}
			return -1;
		}

		public int Pop()
		{
			int peek = -1;
			if (Head != null)
			{
				peek = Head.Data;
				Head = Head.Next;
			}
			return peek;
		}

		public int Count()
		{
			int count = 0;
			Node current = Head;
			while (current != null)
			{
				count++;
				current = current.Next;
			}
			return count;
		}
	}
}








