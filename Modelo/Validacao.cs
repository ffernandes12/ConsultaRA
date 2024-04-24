using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaRA.Modelo
{
    internal class Validacao
    {
        private string RA = "n3425f0";
        private string mensagem;
        private string OutroRA;

        public Validacao(string outroRA)
        {
            OutroRA = outroRA;
            Verificar();
        }

        private void Verificar()
        {
            if (RA != OutroRA)
            {
                mensagem = "RA de outro aluno";

            }

            else
            {
                mensagem = "RA: Fernando Fernandes";
            }
        }

        public string Mensagem { get => mensagem; }

    }
}
