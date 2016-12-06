using System;

namespace DataStructures
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var list = new LinkedList<int>();

			list.Add(new Node<int>(1));
			list.Add(new Node<int>(2));
			list.Add(new Node<int>(3));
			list.Add(new Node<int>(4));
			list.Add(new Node<int>(5));
			list.Add(new Node<int>(6));

			list.Remove(6);
			list.Print();

			Console.ReadKey();
		}
	}
}
