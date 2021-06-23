namespace HelloNuGet
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    public class DefaultHelloNuGet : IHelloNuGet
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns></returns>
        public string GetHello()
        {
            return "Hello NuGet packages!";
        }
    }
}
