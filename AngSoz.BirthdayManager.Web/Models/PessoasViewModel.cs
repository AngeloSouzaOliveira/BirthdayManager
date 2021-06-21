using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AngSoz.BirthdayManager.Web.Models;

namespace AngSoz.BirthdayManager.Web.Models
{
    public class PessoasViewModel
    {

        public List<Pessoa> Pessoas { get; set; }

        public List<Presente> presentes { get; set; }

        public List<Pessoa> AniversarioDia
        { get; set; } = new List<Pessoa>();

        public List<Pessoa> AniversarioOrdem
        { get; set; } = new List<Pessoa>();


        public List<Presente> OrdemDatePresente { get; set; } = new List<Presente>();

    }

    
}
