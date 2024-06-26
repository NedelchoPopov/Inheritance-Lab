namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            Console.WriteLine(stack.IsEmpty());
            stack.AddRange(new List<string> { "ivan", "deni"});
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
