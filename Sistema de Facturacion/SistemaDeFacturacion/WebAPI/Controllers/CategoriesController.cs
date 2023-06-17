using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models.Clases;
using WebAPI.Models.Dto.Base;

using WebAPI.Models.Dto.Create;

using WebAPI.Models.Dto.Update;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly FacturationSystemContext _db;
        private readonly IMapper _mapper;

        public CategoriesController(FacturationSystemContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CategoriesDto>>> GetCategories()
        {
            var CategoriesList = await _db.Categories.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<CategoriesDto>>(CategoriesList));
        }

        [HttpGet("{id:int}", Name = "GetCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriesCreateDto>> GetCategories(int id)
        {
            if (id == 0)
                return BadRequest();

            var Categories = await _db.Categories.FirstOrDefaultAsync(s => s.CategoriesId == id);

            if (Categories == null)
                return NotFound();

            return Ok(_mapper.Map<CategoriesCreateDto>(Categories));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CategoriesDto>> AddCategories([FromBody] CategoriesCreateDto CategoriesCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (CategoriesCreateDto == null)
            {
                return BadRequest(CategoriesCreateDto);
            }

            Categories modelo = _mapper.Map<Categories>(CategoriesCreateDto);

            await _db.Categories.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetCategories", new { id = modelo.CategoriesId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCategories(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var Categories = await _db.Categories.FirstOrDefaultAsync(s => s.CategoriesId == id);

            if (Categories == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(Categories);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCategories(int id, [FromBody] CategoriesUpdateDto CategoriesUpdateDto)
        {
            if (CategoriesUpdateDto == null || id != CategoriesUpdateDto.CategoriesId)
            {
                return BadRequest();
            }

            Categories modelo = _mapper.Map<Categories>(CategoriesUpdateDto);

            _db.Categories.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialCategories(int id, JsonPatchDocument<CategoriesUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Categories = await _db.Categories.AsNoTracking().FirstOrDefaultAsync(s => s.CategoriesId == id);

            CategoriesUpdateDto CategoriesUpdateDto = _mapper.Map<CategoriesUpdateDto>(Categories);

            if (Categories == null) return BadRequest();

            patchDto.ApplyTo(CategoriesUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Categories modelo = _mapper.Map<Categories>(CategoriesUpdateDto);

            _db.Categories.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
