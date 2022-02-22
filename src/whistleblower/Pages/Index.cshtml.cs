using Microsoft.AspNetCore.Mvc.RazorPages;

namespace whistleblower.Pages;

public class IndexModel : PageModel
{
    public List<EnvVar> Variables { get; set; } = new List<EnvVar>();

    public string Version { get; set; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Version? assVersion = typeof(IndexModel).Assembly.GetName().Version;
        Version = assVersion is not null ? $"{assVersion.Major}.{assVersion.Minor}.{assVersion.Build}" : "";
    }
}
