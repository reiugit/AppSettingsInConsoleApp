using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

var configuration = builder.Build();

Console.WriteLine();

Console.WriteLine($"NumericSetting: {configuration.GetValue<int>("NumericSetting")}\n");

Console.WriteLine($"TextSettingA: {configuration["SettingsGroup:SettingA"]}");
Console.WriteLine($"TextSettingB: {configuration["SettingsGroup:SettingB"]}");


