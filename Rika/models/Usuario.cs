using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rika.models
{
    public class Usuario : Entidade
    {
        [Required(ErrorMessage = "O campo Nome não pode ser vazio!")]
        [StringLength(100, ErrorMessage = "O Nome pode conter no máximo 100 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Sobrenome não pode ser vazio!")]
        [StringLength(250, ErrorMessage = "O Sobrenome pode conter no máximo 250 caracteres!")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "O campo Nome de Usuário não pode ser vazio!")]
        [StringLength(50, ErrorMessage = "O Nome de Usuário pode conter no máximo 50 caracteres!")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O campo Senha não pode ser vazio!")]
        [StringLength(20, ErrorMessage = "A Senha pode conter no máximo 20 caracteres!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo Confirmar Senha não pode ser vazio!")]
        [StringLength(20, ErrorMessage = "A Confirmação da Senha pode conter no máximo 20 caracteres!")]
        public string ConfirmarSenha { get; set; }
        public int Tipo { get; set; } /* 0 - Normal, 1 - Administrador */
    }
}
