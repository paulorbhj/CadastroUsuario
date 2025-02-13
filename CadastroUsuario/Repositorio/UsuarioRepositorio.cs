using CadastroUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuario.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly UsuarioContext _usuarioContext;
        public UsuarioRepositorio(UsuarioContext usuarioContext)
        {
            _usuarioContext = usuarioContext;
        }
        public Usuario Adicionar(Usuario usuario)
        {
            _usuarioContext.Usuario1.Add(usuario);
            _usuarioContext.SaveChanges();
            return usuario;
        }
    }
}
