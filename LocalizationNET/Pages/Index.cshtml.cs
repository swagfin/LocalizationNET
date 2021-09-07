using LocalizationNET.Localizations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LocalizationNET.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ILocalizationService LocalizationService { get; }

        public IndexModel(ILogger<IndexModel> logger, ILocalizationService localizationService)
        {
            _logger = logger;
            LocalizationService = localizationService;
        }


        public void OnGet()
        {

        }
        public void OnPost()
        {
            //ILocalizationService
            string message = LocalizationService.Localize("Your account has been created successfully by the system admin");
            _logger.LogInformation(message);
        }
    }
}
