using Ejercicio.Shared.Constants;
using System.ComponentModel.DataAnnotations;

namespace ejercicio.Application.Models.Requests.User
{
    public class CreateUserRequest
    {
        [Required(ErrorMessage = ValidationConstants.REQUIRED)]
        [MaxLength(90, ErrorMessage = ValidationConstants.MAX_LENGTH)]
        [MinLength(10, ErrorMessage = ValidationConstants.MIN_LENGTH)]
        public required string UserName { get; set; }

        [Required(ErrorMessage = ValidationConstants.REQUIRED)]
        [MaxLength(90, ErrorMessage = ValidationConstants.MAX_LENGTH)]
        [MinLength(10, ErrorMessage = ValidationConstants.MIN_LENGTH)]
        public required string Password { get; set; }
    }
}
