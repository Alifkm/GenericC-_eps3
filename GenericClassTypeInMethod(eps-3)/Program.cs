namespace GenericClassTypeInMethod_eps_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> boxStr = new Box<string>("Test");
            boxStr.UpdateContent("updatenya nih");
            Console.WriteLine(boxStr.GetContent());

            Box<int> boxInt = new Box<int>(123);
            boxInt.UpdateContent(30);
            Console.WriteLine(boxInt.GetContent());
        }
    }
}
