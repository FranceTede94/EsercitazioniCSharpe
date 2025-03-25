using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMOESERCIZIO
{
    internal class ESERCIZIO
    {
        private String nome;
        private String cognome;
        private int età;

        public ESERCIZIO(string nome, string cognome, int età)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.età = età;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public int Età { get => età; set => età = value; }
    }
}
