using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;

namespace MyRazorApp.Pages;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _dbContext; // database context
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    // db entity as IList
    public IList<ApiKeys> Items { get; set; } = default!;

    public async Task OnGetAsync()
    {
        // fetch all records dbcontext -> Entity -> To what?
        Items = await _dbContext.ApiKeys.ToListAsync();
    }
}
