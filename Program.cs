using System;

namespace stack_Day14
{
    class Program
    {
        static void Main(string[] args)
        {
            StackLinkedList stacks = new StackLinkedList();
            stacks.Push(70);
            stacks.Push(30);
            stacks.Push(56);
            stacks.Display();
            stacks.IsEmpty();
            stacks.Display();                   //this shows that the stack is empty

        }
    }
}
