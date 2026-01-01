using BlazingPizza.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza;

[Route("specials")]
[ApiController]
public class SpecialsController : Controller
{
    private readonly PizzaStoreContext _db;

    public SpecialsController(PizzaStoreContext db)
    {
        _db = db;
    }

    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.PizzaSpecials.ToListAsync()).OrderByDescending(p => p.BasePrice).ToList();
    }
}