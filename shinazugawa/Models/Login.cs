using System.ComponentModel.DataAnnotations;

namespace projetoJunho.Models
{
    public class Login
    {
        [Display(Name = "Usuário")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email Inválido")]
        public string? Usuario { get; set; }

        public string? Senha { get; set; }
    }
}
