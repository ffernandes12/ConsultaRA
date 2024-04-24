using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaRA.Modelo
{
    internal class Controle
    {
        private string OutroRA;
        private string mensagem;


        public Controle(string txbRA)
        {
            OutroRA = txbRA;
            Validacao validacao = new Validacao(OutroRA);
            mensagem = validacao.Mensagem;
        }

        public string Mensagem { get => mensagem; }
    }
}
