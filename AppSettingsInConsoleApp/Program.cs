using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
    .AddUserSecrets<Program>();

var configuration = builder.Build();

Console.WriteLine("\nSettings from appsettings.json and secrets.json:\n");

Console.WriteLine($" * NumericSetting:  {configuration.GetValue<int>("NumericSetting")}\n");

Console.WriteLine($" * TextSettingA:  {configuration["SettingsGroup:SettingA"]}");
Console.WriteLine($" * TextSettingB:  {configuration["SettingsGroup:SettingB"]}");

Console.WriteLine($"\n * SecretSetting:  {configuration["SecretSetting"]}");


Console.WriteLine("\n\nPress any key to exit.");
Console.ReadKey(true);
