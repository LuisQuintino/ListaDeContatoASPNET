using System.ComponentModel.DataAnnotations;

namespace ListaDeContatoASPNET.Models
{
    public class ContatoModel
    {
        public int id { get; set; }
        [Required(ErrorMessage = "É necessarío digitar o nome do contato")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "É necessarío digitar o sobrenome do contato")]
        public string sobrenome { get; set; }
        [Required(ErrorMessage = "É necessarío digitar o e-mail do contato")]
        [EmailAddress(ErrorMessage = "O e-mail não é valido.")]
        public string email { get; set; }
        [Required(ErrorMessage = "É necessarío digitar ao menos um telefone")]
        [Phone(ErrorMessage = "O telefone não é valido.")]
        public string telefone { get; set; }
        public string observacao { get; set; }

    }
}
