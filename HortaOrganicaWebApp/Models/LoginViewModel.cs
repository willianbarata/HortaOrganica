﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HortaOrganicaWebApp.Models
{
    public class LoginViewModel
    {
        //Propriedades
        [Display(Name = "E-mail")] //Exibição do campo
        [Required(ErrorMessage = "Peenchimento obrigatório!")] //Preenchimento do campo obrigatória
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido!")] //Define o tipo de campo com o formato de dado específico
        public string Email { get; set; }

        [Required(ErrorMessage = "Peenchimento obrigatório!")] //Preenchimento do campo obrigatória
        [DataType(DataType.Password, ErrorMessage = "Senha inválida!")] //Define o tipo de campo com o formato de dado específico
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Informe uma senha com no mínimo 8 digitos")] //Define o tamanho do campo
        public string Senha { get; set; }
    }
}
