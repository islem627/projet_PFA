using System.ComponentModel.DataAnnotations;

namespace app_back_.Dtos
{
    public class CreateEtatCommandeDto
    {
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
