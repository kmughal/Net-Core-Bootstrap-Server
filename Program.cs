namespace SimpleServer
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore;
    using Microsoft.Extensions.Hosting;

    class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();

    }
}