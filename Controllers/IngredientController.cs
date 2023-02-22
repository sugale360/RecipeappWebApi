using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Webapi.Models;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IngredientContext _db;

        public IngredientController(IngredientContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ingredient>>> getIngredients()
        {
            if (_db.Ingredients == null)
            {
                return NotFound();
            }
            return await _db.Ingredients.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> getIngredient(int id)
        {
            if (_db.Ingredients == null)
            {
                return NotFound();
            }
            var Ingredient = await _db.Ingredients.FindAsync(id);
            if (Ingredient == null)
            {
                return NotFound();
            }
            return Ingredient;
        }


        [HttpPost]
        public async Task<ActionResult<Ingredient>> PostIngredient(Ingredient ingredient)
        {
            _db.Ingredients.Add(ingredient);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(getIngredient), new { id = ingredient.Id }, ingredient);

        }
        [HttpPut]
        public async Task<IActionResult> PutIngredients(int id, Ingredient ingredient)
        {
            if (id != ingredient.Id)
            {
                return BadRequest();
            }
            _db.Entry(ingredient).State = EntityState.Modified;
            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IngredientAvailable(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }
        private bool IngredientAvailable(int id)
        {
            return (_db.Ingredients?.Any(x => x.Id == id)).GetValueOrDefault();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIngredient(int id)
        {
            if(_db.Ingredients == null)
            {
                return NotFound();
            }
            var ingredient = await _db.Ingredients.FindAsync(id);
            if(ingredient == null){
                return NotFound();
            }
            _db.Ingredients.Remove(ingredient);
            await _db.SaveChangesAsync();
            return Ok();
        }


    }
}