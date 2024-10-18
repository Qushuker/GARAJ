using System.ComponentModel.DataAnnotations;

namespace GARAJ.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}