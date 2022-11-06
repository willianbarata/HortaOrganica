using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HortaOrganicaWebApp.Models
{
    public class UsuarioViewModel
    {
        [Display(Name = "Código")]
        public int CodigoUsuario { get; set; }

        [Display(Name = "Nome")] //Exibição do campo
        [Required(ErrorMessage = "Peenchimento obrigatório!")] //Preenchimento do campo obrigatória
        public string Nome { get; set; }

        [Display(Name = "E-mail")] //Exibição do campo
        [Required(ErrorMessage = "Peenchimento obrigatório!")] //Preenchimento do campo obrigatória
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido!")] //Define o tipo de campo com o formato de dado específico
        public string Email { get; set; }

        [Required(ErrorMessage = "Peenchimento obrigatório!")] //Preenchimento do campo obrigatória
        [DataType(DataType.Password, ErrorMessage = "Senha inválida!")] //Define o tipo de campo com o formato de dado específico
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Informe uma senha com no mínimo 8 digitos")] //Define o tamanho do campo
        public string Senha { get; set; }

        //[Required(ErrorMessage = "Peenchimento obrigatório!")] //Preenchimento do campo obrigatória
        public string Perfil { get; set; }

        public UsuarioViewModel()
        {
            CodigoUsuario = 0;
        }
    }

    public enum Perfis
    {
        Cliente = 0,
        Tecnico,
        Administrador
    }
}

