using Microsoft.AspNetCore.Mvc;
using TalentInsights.Application.Models.Requests.Collaborator;

namespace TalentInsight.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaboratorsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCollaboratorRequest model)
        {
            return Ok("Usuario creado");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok("Todos los usuarios");
        }
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok($"{id}");
        }

        [HttpPut("{id: guid}")]
        public async Task<IActionResult> Update()
        {
            return Ok("Usuario actualizado");
        }

        [HttpPatch("change-password")]
        public async Task<IActionResult> ChangePassword()
        {
            return Ok("Contrasena cambiada");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok("Usuario actualizado");
        }
    }
}
