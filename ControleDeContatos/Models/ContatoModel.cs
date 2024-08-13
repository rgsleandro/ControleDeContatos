using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }        
        [Required(ErrorMessage ="Digite o nome do contato")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o telefone do contato")]
        [Phone(ErrorMessage = "O telefone informado não é valido!")]
        public string Telefone { get; set; }
    }

}
