using System.ComponentModel.DataAnnotations;

namespace GARAJ.Abp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}