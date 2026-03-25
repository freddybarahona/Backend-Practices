using Ejercicio.Shared.Constants;
using System.ComponentModel.DataAnnotations;

namespace ejercicio.Application.Models.Requests.User
{
    public class ChangePasswordUserRequest
    {
        [Required(ErrorMessage = ValidationConstants.REQUIRED)]
        [MaxLength(50, ErrorMessage = ValidationConstants.MAX_LENGTH)]
        [MinLength(10, ErrorMessage = ValidationConstants.MIN_LENGTH)]
        public required string CurrentPassword { get; set; }

        [Required(ErrorMessage = ValidationConstants.REQUIRED)]
        [MaxLength(50, ErrorMessage = ValidationConstants.MAX_LENGTH)]
        [MinLength(10, ErrorMessage = ValidationConstants.MIN_LENGTH)]
        public required string NewPassword { get; set; }
    }
}
