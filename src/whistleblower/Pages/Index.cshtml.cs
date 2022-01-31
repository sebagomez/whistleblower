using Microsoft.AspNetCore.Mvc.RazorPages;

namespace whistleblower.Pages;

public class IndexModel : PageModel
{
    public List<EnvVar> Variables { get; set; } = new List<EnvVar>();
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
