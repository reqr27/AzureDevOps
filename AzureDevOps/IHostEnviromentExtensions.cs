namespace AzureDevOps
{
    public static class IHostEnviromentExtensions
    {
        public static bool IsDev(this IHostEnvironment hostEnvironment)
        {
            return hostEnvironment.EnvironmentName.Equals("Dev", StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsProd(this IHostEnvironment hostEnvironment)
        {
            return hostEnvironment.EnvironmentName.Equals("Prod", StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsTest(this IHostEnvironment hostEnvironment)
        {
            return hostEnvironment.EnvironmentName.Equals("Test", StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool isDevOrTest(this IHostEnvironment hostEnvironment)
        {
            return hostEnvironment.IsDev() || hostEnvironment.IsTest();
        }
    }
}
