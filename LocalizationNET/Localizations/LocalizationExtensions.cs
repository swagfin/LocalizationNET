using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Resources;

namespace LocalizationNET.Localizations
{
    public static class LocalizationExtensions
    {
        public static void RegisterCustomLocalization(this IServiceCollection services, string languageKey = "English")
        {
            languageKey = (string.IsNullOrWhiteSpace(languageKey)) ? "English" : languageKey;
            var executingAssembly = Assembly.GetExecutingAssembly();
            string baseName = string.Format("{0}.Resources.{1}", executingAssembly.GetName().Name, languageKey);
            services.AddSingleton(new ResourceManager(baseName, executingAssembly));
        }
    }
}
