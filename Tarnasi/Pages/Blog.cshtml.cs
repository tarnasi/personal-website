using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tarnasi.Models;

namespace Tarnasi.Pages
{
    public class BlogModel : PageModel
    {
        private readonly ApplicationContext _context;
        private readonly ILogger<BlogModel> _logger;

        public BlogModel(ApplicationContext context, ILogger<BlogModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<Article> articles { get; set; } = default!;


        public async Task OnGetAsync()
        {
            if (_context.articles != null)
            {
                articles = await _context.articles.ToListAsync();
            }
        }
    }
}
