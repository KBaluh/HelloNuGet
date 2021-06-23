using System;

namespace HelloNuGet.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IHelloNuGet hello = new DefaultHelloNuGet();
            Console.WriteLine(hello.GetHello());
        }
    }
}
