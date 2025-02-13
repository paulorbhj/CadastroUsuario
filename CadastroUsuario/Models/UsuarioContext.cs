using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CadastroUsuario.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuario.Models
{
    public class UsuarioContext : Microsoft.EntityFrameworkCore.DbContext
    {
        //O debset abaixo cria conexão com o banco 
        //public UsuarioContext() : base("Server = localhost\\SQLEXPRESS01; Database=CadastroUsuario;Trusted_Connection=True;") { }
        // public System.Data.Entity.DbSet<CadastroUsuario.Models.Usuario> Usuarios { get; set; }

        //metodo abaixo para eliminar o problema de pluralização das tabelas no banco
        /*protected override void OnModelCreating(DbModelBuilder dbmodelBuilder)
        {
            dbmodelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }*/

        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }
        public Microsoft.EntityFrameworkCore.DbSet<Usuario> Usuario1 { get; set; }
    }
}
