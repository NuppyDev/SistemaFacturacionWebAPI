using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models.Dto;

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
        public async Task<ActionResult<WaitersDto>> GetWaiters(int id)
        {
            if (id == 0)
                return BadRequest();

            var waiter = await _db.Waiters.FirstOrDefaultAsync(s => s.WaitersId == id);

            if (waiter == null)
                return NotFound();

            return Ok(_mapper.Map<WaitersDto>(waiter));
        }
    }
}
