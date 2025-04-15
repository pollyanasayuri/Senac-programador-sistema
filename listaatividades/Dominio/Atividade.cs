using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaatividades.Dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
       public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

    }
}
