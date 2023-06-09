using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models.Clases;
using WebAPI.Models.Dto;
using WebAPI.Models.Dto.Base;
using WebAPI.Models.Dto.Create;
using WebAPI.Models.Dto.Update;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricalController : ControllerBase
    {
        private readonly FacturationSystemContext _db;
        private readonly IMapper _mapper;

        public HistoricalController(FacturationSystemContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<HistoricalDto>>> GetHistoricals()
        {
            var HistoricalList = await _db.Historical.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<HistoricalDto>>(HistoricalList));
        }

        [HttpGet("{id:int}", Name = "GetHistoricals")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<HistoricalCreateDto>> GetHistorical(int id)
        {
            if (id == 0)
                return BadRequest();

            var Historical = await _db.Historical.FirstOrDefaultAsync(s => s.HistoricalId == id);

            if (Historical == null)
                return NotFound();

            return Ok(_mapper.Map<HistoricalDto>(Historical));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<HistoricalDto>> AddHistoricals([FromBody] HistoricalCreateDto HistoricalCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (HistoricalCreateDto == null)
            {
                return BadRequest(HistoricalCreateDto);
            }

            Historical modelo = _mapper.Map<Historical>(HistoricalCreateDto);

            await _db.Historical.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetHistorical", new { id = modelo.HistoricalId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteHistoricals(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var Historical = await _db.Historical.FirstOrDefaultAsync(s => s.HistoricalId == id);

            if (Historical == null)
            {
                return NotFound();
            }

            _db.Historical.Remove(Historical);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateHistorical(int id, [FromBody] HistoricalUpdateDto HistoricalUpdateDto)
        {
            if (HistoricalUpdateDto == null || id != HistoricalUpdateDto.HistoricalId)
            {
                return BadRequest();
            }

            Historical modelo = _mapper.Map<Historical>(HistoricalUpdateDto);

            _db.Historical.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialTables(int id, JsonPatchDocument<HistoricalUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var table = await _db.Tables.AsNoTracking().FirstOrDefaultAsync(s => s.TableId == id);

            HistoricalUpdateDto HistoricalUpdateDto = _mapper.Map<HistoricalUpdateDto>(table);

            if (table == null) return BadRequest();

            patchDto.ApplyTo(HistoricalUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Historical modelo = _mapper.Map<Historical>(HistoricalUpdateDto);

            _db.Historical.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
