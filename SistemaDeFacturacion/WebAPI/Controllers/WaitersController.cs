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
    public class WaitersController : ControllerBase
    {
        private readonly FacturationSystemContext _db;
        private readonly IMapper _mapper;

        public WaitersController(FacturationSystemContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<WaitersDto>>> GetWaiters()
        {   
            var WaitersList = await _db.Waiters.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<WaitersDto>>(WaitersList));
        }

        [HttpGet("{id:int}", Name = "GetWaiters")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<WaitersCreateDto>> GetWaiters(int id)
        {
            if (id == 0)
                return BadRequest();

            var waiter = await _db.Waiters.FirstOrDefaultAsync(s => s.WaitersId == id);

            if (waiter == null)
                return NotFound();

            return Ok(_mapper.Map<WaitersCreateDto>(waiter));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DescriptionDto>> AddWaiters([FromBody] WaitersCreateDto waitersCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (waitersCreateDto == null)
            {
                return BadRequest(waitersCreateDto);
            }

            Waiters modelo = _mapper.Map<Waiters>(waitersCreateDto);

            await _db.Waiters.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetWaiters", new { id = modelo.WaitersId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteWaiters(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var waiters = await _db.Waiters.FirstOrDefaultAsync(s => s.WaitersId == id);

            if (waiters == null)
            {
                return NotFound();
            }

            _db.Waiters.Remove(waiters);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateWaiters(int id, [FromBody] WaitersUpdateDto waitersUpdateDto)
        {
            if (waitersUpdateDto == null || id != waitersUpdateDto.WaitersId)
            {
                return BadRequest();
            }

            Waiters modelo = _mapper.Map<Waiters>(waitersUpdateDto);

            _db.Waiters.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialWaiters(int id, JsonPatchDocument<WaitersUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var waiters = await _db.Waiters.AsNoTracking().FirstOrDefaultAsync(s => s.WaitersId == id);

            WaitersUpdateDto waitersUpdateDto = _mapper.Map<WaitersUpdateDto>(waiters);

            if (waiters == null) return BadRequest();

            patchDto.ApplyTo(waitersUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Waiters modelo = _mapper.Map<Waiters>(waitersUpdateDto);

            _db.Waiters.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
