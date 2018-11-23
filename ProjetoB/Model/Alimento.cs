using System.Collections.Generic;

namespace ProjetoB.Model
{
    public class Alimento
    {
        private TipoAlimento tipoAlimento;
        private List<Food> comidas;

        public Alimento(TipoAlimento tipoAlimento, List<Food> comidas)
        {
            this.tipoAlimento = tipoAlimento;
            this.comidas = comidas;
        }

        public TipoAlimento TipoAlimento { get => tipoAlimento; set => tipoAlimento = value; }
        public List<Food> Alimentos { get => comidas; set => comidas = value; }
    }

    public enum TipoAlimento
    {
        CAFES,
        ALCOOLICAS,
        REFRIGERANTES,
        CARNES,
        EMBUTIDOS,
        PEIXES,
        BOLACHA,
        BALAS,
        BOLOS,
        CHOCOLATES,
        DOCES,
        GELATINAS,
        SORVETES,
        ADOCANTESCONDIMENTOS,
        CREMESMOLHOS,
        GORDURASOLEOS,
        FRUTAS,
        IOGURTES,
        LEITES,
        QUEIJOS,
        OVOS,
        LEGUMESVERDURAS,
        PAES,
        MASSAS,
        CEREAISFARINHAS,
        PRATOSCASEIRO,
        SANDUICHES,
    }
}
