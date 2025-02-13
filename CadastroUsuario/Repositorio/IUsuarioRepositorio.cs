using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroUsuario.Models;

namespace CadastroUsuario.Repositorio
{
    public interface IUsuarioRepositorio
    {
        Usuario Adicionar(Usuario usuario);
    }
}
