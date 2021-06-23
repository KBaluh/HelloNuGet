namespace HelloNuGet
{
    public class DefaultHelloNuGet : IHelloNuGet
    {
        public string GetHello()
        {
            return "Hello NuGet packages!";
        }
    }
}
