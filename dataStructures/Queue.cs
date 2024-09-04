using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataStructures
{
	public class Queue
	{
		private Node Head;
		private Node Tail;
		public Queue() 
		{
			this.Head = null;
			this.Tail = null;
		}
		
		public void Enqueue(int data)
		{
			Node newNode = new Node(data);
			if (Head == null)
			{
				Head = newNode;
				Tail = newNode;
			}
			Tail.Next = newNode;
			Tail = newNode;
		}

		public int Dequeue()
		{
			if (Head == null)
			{
				return -1;
			}
			Head = Head.Next;
			return Head.Data;
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

		public void Clear()
		{
			Node node = Head;
			if (node == null)
			{
				return;
			}
			Head = null;
			Tail = null;
		}
	}
}
			


		


