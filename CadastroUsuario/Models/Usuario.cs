using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CadastroUsuario.Models
{
    public class Usuario
    {
        [HiddenInput(DisplayValue = false)]
        public int NomeID { get; set; }

        public string Nome { get; set; }
        public string NomeMae { get; set; }
        public long CPF { get; set; }
        public string Email { get; set; }
        //public int UserId { get; internal set; }
    }
}
