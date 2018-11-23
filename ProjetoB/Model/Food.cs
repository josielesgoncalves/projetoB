using System;
using System.Collections.Generic;

namespace ProjetoB.Model
{
    public class Food
    {
        private int index;
        private string nome;
        private double quantidade;
        private double caloria;
        private string medida;
 
        public Food(int index, string nome, double caloria, double quantidade, string medida)
        {
            this.Index = index;
            this.nome = nome;
            this.caloria = caloria;
            this.Quantidade = quantidade;
            this.Medida = medida;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Caloria { get => caloria; set => caloria = value; }
        public int Index { get => index; set => index = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public string Medida { get => medida; set => medida = value; }
    }
}
