using System;
using Microsoft.Extensions.Configuration;

namespace AppConfigChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // replace with connection string 
            const string connectionString = "";
            // replace with an appconfig
            const string mySetting = "Api/ChatApp:ClientId";
            
            IConfiguration config = new ConfigurationBuilder()
                .AddAzureAppConfiguration(options =>
                {
                    options.Connect(connectionString)
                        .UseFeatureFlags();
                })
                .Build();

            var settingValue = config[mySetting];
            Console.WriteLine($"Setting {mySetting}: {settingValue}");
        }
    }
}