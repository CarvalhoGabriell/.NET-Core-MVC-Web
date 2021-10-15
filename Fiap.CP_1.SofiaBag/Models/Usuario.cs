using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.CP_1.SofiaBag.Models
{
    public class Usuario
    {

        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public DateTime DtNascimento { get; set; }

        public Genero sexo { get; set; }


        public enum Genero
        {
            Masculino, Feminino, Neutro, Outros
        }
    }
}
