using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Resources;

namespace LocalizationNET.Localizations.Implementations
{
    public class LocalizationService : ILocalizationService
    {
        private readonly ResourceManager _resourceManager;
        private readonly ILogger<LocalizationService> _logger;
        private readonly IConfiguration _configuration;

        public LocalizationService(ResourceManager resourceManager, ILogger<LocalizationService> logger, IConfiguration configuration)
        {
            this._resourceManager = resourceManager;
            this._logger = logger;
            this._configuration = configuration;
        }


        public string Localize(string message)
        {
            try
            {
                return _resourceManager.GetString(message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return message; //Returning exact message (None Translated)
            }
        }


        public string GetLanguageCulture()
        {
            return _configuration.GetValue<string>("LocalizationLanguage");
        }
    }
}
