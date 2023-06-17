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
    public class ProductsController : ControllerBase
    {
        private readonly FacturationSystemContext _db;
        private readonly IMapper _mapper;

        public ProductsController(FacturationSystemContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductsDto>>> GetProducts()
        {
            var ProductsList = await _db.Products.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<ProductsDto>>(ProductsList));
        }

        [HttpGet("{id:int}", Name = "GetProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductsCreateDto>> GetProducts(int id)
        {
            if (id == 0)
                return BadRequest();

            var Products = await _db.Products.FirstOrDefaultAsync(s => s.ProductsId == id);

            if (Products == null)
                return NotFound();

            return Ok(_mapper.Map<ProductsCreateDto>(Products));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductsDto>> AddProducts([FromBody] ProductsCreateDto ProductsCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (ProductsCreateDto == null)
            {
                return BadRequest(ProductsCreateDto);
            }

            Products modelo = _mapper.Map<Products>(ProductsCreateDto);

            await _db.Products.AddAsync(modelo);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetProducts", new { id = modelo.ProductsId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProducts(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var Products = await _db.Products.FirstOrDefaultAsync(s => s.ProductsId == id);

            if (Products == null)
            {
                return NotFound();
            }

            _db.Products.Remove(Products);
            await _db.SaveChangesAsync(true);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProducts(int id, [FromBody] ProductsUpdateDto ProductsUpdateDto)
        {
            if (ProductsUpdateDto == null || id != ProductsUpdateDto.ProductsId)
            {
                return BadRequest();
            }

            Products modelo = _mapper.Map<Products>(ProductsUpdateDto);

            _db.Products.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialProducts(int id, JsonPatchDocument<ProductsUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Products = await _db.Products.AsNoTracking().FirstOrDefaultAsync(s => s.ProductsId == id);

            ProductsUpdateDto ProductsUpdateDto = _mapper.Map<ProductsUpdateDto>(Products);

            if (Products == null) return BadRequest();

            patchDto.ApplyTo(ProductsUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Products modelo = _mapper.Map<Products>(ProductsUpdateDto);

            _db.Products.Update(modelo);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}
