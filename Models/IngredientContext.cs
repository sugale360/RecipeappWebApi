using Microsoft.EntityFrameworkCore;

namespace Webapi.Models{
    public class IngredientContext : DbContext {
public IngredientContext(DbContextOptions<IngredientContext> options ) : base(options)
{
    
}
public DbSet<Ingredient>? Ingredients {get; set;}
    }
}