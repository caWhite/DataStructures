using System;
namespace DataStructures
{
	public class Node<T> where T: IComparable
	{
		public Node<T> next;
		public T data;

		public Node(T d)
		{
			data = d;
		}
	}
}
