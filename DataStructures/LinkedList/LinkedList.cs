using System;
namespace DataStructures
{
	public class LinkedList<T> where T: IComparable
	{
		public Node<T> head { get; private set; }
		public Node<T> tail { get; private set; }

		public int Count { get; private set;}

		public void Add(Node<T> newNode)
		{
			if (head == null)
			{
				head = newNode;
				tail = head;
			}
			else
			{
				tail.next = newNode;
				tail = newNode;
			}
			Count++;
		}
		public bool Contains(T value)
		{
			bool contains = false;
			Node<T> currentNode = head;
			while(currentNode != null)
			{
				if (currentNode.data.Equals(value))
				{
					contains = true;
					break;
				}
			}
			return contains;
		}
		public bool Remove(T value)
		{
			if (head == null) return false;
			var current = head;
			if(current.data.Equals(value))
			{
				if (head == tail)
				{
					head = null;
					tail = null;
				}
				else
				{
					head = head.next;
				}
				return true;
			}
			else
			{
				var previous = current;
				while(current != null && !current.data.Equals(value))
				{
					previous = current;
					current = current.next;
				}
				if (current == null) return false;
				else
				{
					if (current.next == null)
					{
						previous.next = null;
						tail = previous;
					}
					else
					{
						previous.next = current.next;
						current = null;
					}
					return true;
				}
			}
		}
		public void Print()
		{
			Console.WriteLine($"Head: {head.data}");
			Console.WriteLine($"Tail: {tail.data}");

			var current = head;
			while (current != null)
			{
				Console.WriteLine(current.data);
				current = current.next;
			}
		}
	}
}
