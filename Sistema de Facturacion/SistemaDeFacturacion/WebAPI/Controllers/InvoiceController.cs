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
    public class InvoiceController : ControllerBase
    {
        private readonly FacturationSystemContext _db;
        private readonly IMapper _mapper;

        public InvoiceController(FacturationSystemContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<InvoiceDto>>> GetInvoice()
        {
            var InvoiceList = await _db.Invoice.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<InvoiceDto>>(InvoiceList));
        }

        [HttpGet("{id:int}", Name = "GetInvoice")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InvoiceCreateDto>> GetInvoice(int id)
        {
            if (id == 0)
                return BadRequest();

            var Invoice = await _db.Invoice.FirstOrDefaultAsync(s => s.InvoiceId == id);

            if (Invoice == null)
                return NotFound();

            return Ok(_mapper.Map<InvoiceCreateDto>(Invoice));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<InvoiceDto>> AddInvoice([FromBody] InvoiceCreateDto InvoiceCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (InvoiceCreateDto == null)
            {
                return BadRequest(InvoiceCreateDto);
            }

            Invoice modelo = _mapper.Map<Invoice>(InvoiceCreateDto);

            await _db.Invoice.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetInvoice", new { id = modelo.InvoiceId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var Invoice = await _db.Invoice.FirstOrDefaultAsync(s => s.InvoiceId == id);

            if (Invoice == null)
            {
                return NotFound();
            }

            _db.Invoice.Remove(Invoice);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateInvoice(int id, [FromBody] InvoiceUpdateDto InvoiceUpdateDto)
        {
            if (InvoiceUpdateDto == null || id != InvoiceUpdateDto.InvoiceId)
            {
                return BadRequest();
            }

            Invoice modelo = _mapper.Map<Invoice>(InvoiceUpdateDto);

            _db.Invoice.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialInvoice(int id, JsonPatchDocument<InvoiceUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Invoice = await _db.Invoice.AsNoTracking().FirstOrDefaultAsync(s => s.InvoiceId == id);

            InvoiceUpdateDto InvoiceUpdateDto = _mapper.Map<InvoiceUpdateDto>(Invoice);

            if (Invoice == null) return BadRequest();

            patchDto.ApplyTo(InvoiceUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Invoice modelo = _mapper.Map<Invoice>(InvoiceUpdateDto);

            _db.Invoice.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
