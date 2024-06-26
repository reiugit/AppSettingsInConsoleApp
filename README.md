# AppSettingsInConsoleApp

## Access settings from appsettings.json file in a console app

This example uses the ConfigurationBuilder to add the settings of the appsettings.json file.
* setting the path with builder.SetBasePath to CurrentDirectory
* using the method builder.AddJsonFile to add the json-file
* builder.Build() generates the configuration

Typesafe Reading via configuration.GetValue<T>(settingKey)
or not typesafe via configuration[settingKey].

(The typesafe method "GetValue" needs the Nuget-package "Microsoft.Extensions.Configuration.Binder".)





