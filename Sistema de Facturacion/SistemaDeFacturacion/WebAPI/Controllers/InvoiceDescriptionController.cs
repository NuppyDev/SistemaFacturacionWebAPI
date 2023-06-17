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
    public class InvoiceDescriptionController : ControllerBase
    {
        private readonly FacturationSystemContext _db;
        private readonly IMapper _mapper;

        public InvoiceDescriptionController(FacturationSystemContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<InvoiceDescriptionDto>>> GetInvoice()
        {
            var InvoiceDescriptionList = await _db.InvoiceDescription.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<InvoiceDescriptionDto>>(InvoiceDescriptionList));
        }

        [HttpGet("{id:int}", Name = "GetInvoiceDescription")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InvoiceDescriptionCreateDto>> GetInvoiceDescription(int id)
        {
            if (id == 0)
                return BadRequest();

            var InvoiceDescription = await _db.InvoiceDescription.FirstOrDefaultAsync(s => s.InDeId == id);

            if (InvoiceDescription == null)
                return NotFound();

            return Ok(_mapper.Map<InvoiceDescriptionCreateDto>(InvoiceDescription));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<InvoiceDescriptionDto>> AddInvoiceDescription([FromBody] InvoiceDescriptionCreateDto InvoiceDescriptionCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (InvoiceDescriptionCreateDto == null)
            {
                return BadRequest(InvoiceDescriptionCreateDto);
            }

            InvoiceDescription modelo = _mapper.Map<InvoiceDescription>(InvoiceDescriptionCreateDto);

            await _db.InvoiceDescription.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetInvoiceDescription", new { id = modelo.InDeId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteInvoiceDescription(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var InvoiceDescription = await _db.InvoiceDescription.FirstOrDefaultAsync(s => s.InDeId == id);

            if (InvoiceDescription == null)
            {
                return NotFound();
            }

            _db.InvoiceDescription.Remove(InvoiceDescription);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateInvoiceDescription(int id, [FromBody] InvoiceDescriptionUpdateDto InvoiceDescriptionUpdateDto)
        {
            if (InvoiceDescriptionUpdateDto == null || id != InvoiceDescriptionUpdateDto.InvoiceId)
            {
                return BadRequest();
            }

            InvoiceDescription modelo = _mapper.Map<InvoiceDescription>(InvoiceDescriptionUpdateDto);

            _db.InvoiceDescription.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialInvoiceDescription(int id, JsonPatchDocument<InvoiceDescriptionUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var InvoiceDescription = await _db.InvoiceDescription.AsNoTracking().FirstOrDefaultAsync(s => s.InDeId == id);

            InvoiceDescriptionUpdateDto InvoiceDescriptionUpdateDto = _mapper.Map<InvoiceDescriptionUpdateDto>(InvoiceDescription);

            if (InvoiceDescription == null) return BadRequest();

            patchDto.ApplyTo(InvoiceDescriptionUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            InvoiceDescription modelo = _mapper.Map<InvoiceDescription>(InvoiceDescriptionUpdateDto);

            _db.InvoiceDescription.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
