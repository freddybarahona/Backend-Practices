using ejercicio.Application.Models.Requests.User;

using Microsoft.AspNetCore.Mvc;

namespace ejercicio.WebApi.Controllers
{
    [Route("api/[controller]")] //CON ESTO EL BUSCARA TODO ELEMENTO CON NOMBRE CONTROLLER
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserRequest Model)
        {
            return Ok("Usuario creado");
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok("{Id}");
        }

        [HttpPatch("change-password/{id:Guid}")]
        public async Task<IActionResult> ChangePassword(Guid id, [FromBody] ChangePasswordUserRequest Model)
        {
            return Ok($"Contrasena de usuario cambiada: {Model.CurrentPassword} {Model.NewPassword}");
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok($"Usuario eliminado: {id}");
        }
    }
}
