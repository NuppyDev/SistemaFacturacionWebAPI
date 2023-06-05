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
    public class TablesController : ControllerBase
    {
        private readonly FacturationSystemContext _db;
        private readonly IMapper _mapper;

        public TablesController(FacturationSystemContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<TablesDto>>> GetTables()
        {
            var TablesList = await _db.Tables.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<TablesDto>>(TablesList));
        }

        [HttpGet("{id:int}", Name = "GetTables")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Models.Dto.Base.WaitersCreateDto>> GetTables(int id)
        {
            if (id == 0)
                return BadRequest();

            var tables = await _db.Tables.FirstOrDefaultAsync(s => s.TableId == id);

            if (tables == null)
                return NotFound();

            return Ok(_mapper.Map<TablesDto>(tables));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TablesDto>> AddTables([FromBody] TablesCreateDto tablesCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (tablesCreateDto == null)
            {
                return BadRequest(tablesCreateDto);
            }

            Tables modelo = _mapper.Map<Tables>(tablesCreateDto);

            await _db.Tables.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetTables", new { id = modelo.TableId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteTables(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var table = await _db.Tables.FirstOrDefaultAsync(s => s.TableId == id);

            if (table == null)
            {
                return NotFound();
            }

            _db.Tables.Remove(table);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateTables(int id, [FromBody] TablesUpdateDto tablesUpdateDto)
        {
            if (tablesUpdateDto == null || id != tablesUpdateDto.TableId)
            {
                return BadRequest();
            }

            Tables modelo = _mapper.Map<Tables>(tablesUpdateDto);

            _db.Tables.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialTables(int id, JsonPatchDocument<TablesUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var table = await _db.Tables.AsNoTracking().FirstOrDefaultAsync(s => s.TableId == id);

            TablesUpdateDto tablesUpdateDto = _mapper.Map<TablesUpdateDto>(table);

            if (table == null) return BadRequest();

            patchDto.ApplyTo(tablesUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Tables modelo = _mapper.Map<Tables>(tablesUpdateDto);

            _db.Tables.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
