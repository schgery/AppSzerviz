using System.ComponentModel.DataAnnotations;

namespace AppSzerviz.Models
{
    public class Bejelentes
    {
        [Required,Key]
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string BejelentoNeve { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string EszkozTipus { get; set; }
        [Required,MinLength(10)]
        public string HibaLeiras { get; set; }
        public bool Surgos { get; set; }
        public DateTime BejelentesDatuma { get; set; }


    }
}
