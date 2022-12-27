using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using UniversityApiBackend.DataAccess;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorysController : ControllerBase
    {
        private readonly DbContextUniversity _context;
        public CategorysController(DbContextUniversity context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Category>>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            var category = await _context.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<Category>> AddCategory(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetById", new { id = category.Id }, category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
