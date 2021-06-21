using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AngSoz.BirthdayManager.Web.Models;

namespace AngSoz.BirthdayManager.Web.Models
{
    public class Presente : Entidade
    {
        //FK
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Nome Presente")]
        [StringLength(200, ErrorMessage = "O campo {0} tem que ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string NomePresente { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Valor do Presente")]
        public decimal ValorPresente { get; set; }

        // Relação EF (1 p/ ...1 presente) 
        public Pessoa Pessoas { get; set; }
    }
}
