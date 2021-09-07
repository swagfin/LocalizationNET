namespace LocalizationNET.Localizations
{
    public interface ILocalizationService
    {
        public string Localize(string message);
        public string GetLanguageCulture();
    }
}
