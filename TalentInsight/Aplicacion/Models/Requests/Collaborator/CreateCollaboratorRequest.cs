using System.ComponentModel.DataAnnotations;
using TalentInsights.Shared.Constants;


namespace TalentInsights.Application.Models.Requests.Collaborator
{
    public class CreateCollaboratorRequest
    {
        [Required(ErrorMessage = ValidationConstants.REQUIRED)]
        [MaxLength(150, ErrorMessage = ValidationConstants.MAX_LENGTH)]
        [MinLength(10, ErrorMessage = ValidationConstants.MIN_LENGTH)]
        public required string FullName { get; set; }
        [MaxLength(255, ErrorMessage = ValidationConstants.MAX_LENGTH)]
        [MinLength(10, ErrorMessage = ValidationConstants.MIN_LENGTH)]
        public string? GitLabProfile { get; set; }

        [Required(ErrorMessage = ValidationConstants.REQUIRED)]
        [MaxLength(150, ErrorMessage = ValidationConstants.MAX_LENGTH)]
        [MinLength(10, ErrorMessage = ValidationConstants.MIN_LENGTH)]
        public required string Position { get; set; }
    }
}
