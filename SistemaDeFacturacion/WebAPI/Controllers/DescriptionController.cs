using AutoMapper;
using Microsoft.AspNetCore.Http;
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
    public class DescriptionController : ControllerBase
    {
        private readonly FacturationSystemContext _db;
        private readonly IMapper _mapper;

        public DescriptionController(FacturationSystemContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DescriptionDto>>> GetDescription()
        {
            var DescriptionList = await _db.Description.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<DescriptionDto>>(DescriptionList));
        }

        [HttpGet("{id:int}", Name = "GetDescription")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DescriptionCreateDto>> GetDescription(int id)
        {
            if (id == 0)
                return BadRequest();

            var Description = await _db.Description.FirstOrDefaultAsync(s => s.DescriptionId == id);

            if (Description == null)
                return NotFound();

            return Ok(_mapper.Map<DescriptionCreateDto>(Description));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DescriptionDto>> AddDescription([FromBody] DescriptionCreateDto DescriptionCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (DescriptionCreateDto == null)
            {
                return BadRequest(DescriptionCreateDto);
            }

            Description modelo = _mapper.Map<Description>(DescriptionCreateDto);

            await _db.Description.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetTables", new { id = modelo.DescriptionId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteDescription(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var Description = await _db.Description.FirstOrDefaultAsync(s => s.DescriptionId == id);

            if (Description == null)
            {
                return NotFound();
            }

            _db.Description.Remove(Description);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateDescription(int id, [FromBody] DescriptionUpdateDto DescriptionUpdateDto)
        {
            if (DescriptionUpdateDto == null || id != DescriptionUpdateDto.DescriptionId)
            {
                return BadRequest();
            }

            Description modelo = _mapper.Map<Description>(DescriptionUpdateDto);

            _db.Description.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialDescription(int id, JsonPatchDocument<DescriptionUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Description = await _db.Description.AsNoTracking().FirstOrDefaultAsync(s => s.DescriptionId == id);

            DescriptionUpdateDto DescriptionUpdateDto = _mapper.Map<DescriptionUpdateDto>(Description);

            if (Description == null) return BadRequest();

            patchDto.ApplyTo(DescriptionUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Description modelo = _mapper.Map<Description>(DescriptionUpdateDto);

            _db.Description.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
