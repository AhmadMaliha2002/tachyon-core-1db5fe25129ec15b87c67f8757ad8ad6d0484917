using System.ComponentModel.DataAnnotations;

namespace TACHYON.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
