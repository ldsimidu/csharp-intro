using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiap_csharp
{
    public class AlunoPagamento : Aluno
    {
        public int idPagamento { get; set; }

        public int idAluno { get; }

        private bool flMensalidadeDia { get; }

        public AlunoPagamento(bool FlMensalidadeDia)
        {
            flMensalidadeDia = FlMensalidadeDia;
        }
    }
}
