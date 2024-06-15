namespace MyStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack1<int> stack = new Stack1<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.PrintStack();
            Console.WriteLine();

            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Peek());

            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack khong rong");
            }
            else Console.WriteLine("Stack rong ");
        }
    }
}
