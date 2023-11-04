using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Systekna.Application;
using Systekna.Application.Business;
using Systekna.Core;
using Systekna.Core.DTOs;

namespace WbCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesaController : ControllerBase
    {
        private readonly IBbApplication _db;

        public DespesaController(BbApplication db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<EntityDespesa>> Get()
        {
            return await _db.GetAllDespesa();
        }

        [HttpPost]
        public async Task<ActionResult> Post(EntityDespesaDTO despesa)
        {
            await _db.InsertDespesa(despesa);
            return Ok();
        }
    }
}
