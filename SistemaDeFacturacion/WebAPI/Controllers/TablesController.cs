using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models.Clases;
using WebAPI.Models.Dto;

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
        public async Task<ActionResult<WaitersDto>> GetTables(int id)
        {
            if (id == 0)
                return BadRequest();

            var tables = await _db.Tables.FirstOrDefaultAsync(s => s.TableId == id);

            if (tables == null)
                return NotFound();

            return Ok(_mapper.Map<TablesDto>(tables));
        }
    }
}
