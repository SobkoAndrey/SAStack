using System;
namespace SAStack
{
	public class Stack<T>
	{
		T[] stack;
		int point;

		public Stack(int size)
		{
			stack = new T[size];
			point = 0;
		}

		public T GetContent()
		{
			if (point == 0)
			{
				return default(T);
			}

			point -= 1;
			return stack[point];
		}

		public void AddContent(T content)
		{
			if (point == stack.Length)
				return;

			stack[point] = content;
			point += 1;
		}

		public bool isEmpty()
		{
			return (point == 0);
		}

		public bool isFull()
		{
			return (point == stack.Length);
		}

		public int Сapacity()
		{
			return stack.Length;
		}

		public int ElementsCount()
		{
			return point;
		}
	}
}
