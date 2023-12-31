using CookAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CookAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RecipeController : ControllerBase
{

    private readonly ILogger<RecipeController> _logger;
    private readonly CookAPIContext _context;

    public RecipeController(ILogger<RecipeController> logger, CookAPIContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<RecipeDto>>> Get()
    {
        return await _context.Recipes.Select(r => new RecipeDto() { Id = r.Id, Name = r.Name }).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<RecipeDto>> Get(long id)
    {
        var todoItem = await _context.Recipes.Select(r => new RecipeDto() { Id = r.Id, Name = r.Name }).SingleOrDefaultAsync(r => r.Id == id);

        if (todoItem == null)
        {
            return NotFound();
        }

        return todoItem;
    }
}
