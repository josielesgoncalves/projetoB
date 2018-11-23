using ProjetoB.Model;
using ProjetoB.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoB
{
    public partial class CalorieControl : Form
    {
        private List<Food> categoriaSelecionada;
        public CalorieControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            listViewAlimentos.View = System.Windows.Forms.View.Details;
            listViewAlimentos.Columns.Add("Nome", 200);
            listViewAlimentos.Columns.Add("Quantidade", 100);
            listViewAlimentos.Columns.Add("Medida", 100);
            listViewAlimentos.Columns.Add("Caloria", 100);

            comboCategoria.Text = "Selecione uma categoria";
            carregarListaComidas();

            lvIngeridos.View = System.Windows.Forms.View.Details;
            lvIngeridos.Columns.Add("Nome", 120);
            lvIngeridos.Columns.Add("Qtd", 30);            
        }

        public void CarregarListViewAlimentos(List<Food> foods)
        {
            foreach (Food f in foods)
            {
                ListViewItem item = new ListViewItem(f.Nome);
                item.SubItems.Add(f.Quantidade.ToString());
                item.SubItems.Add(f.Medida);
                item.SubItems.Add(f.Caloria.ToString());
                listViewAlimentos.Items.Add(item);
            }
        }
        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Food> categoria = new List<Food>();
            listViewAlimentos.Items.Clear();

            foreach (Alimento a in alimentos)
            {
                for (int i = 0; i < comboCategoria.Items.Count; i++)
                {
                    if (i == comboCategoria.SelectedIndex)
                    {
                        categoria = carregaListView(categoria, a, i);
                    }
                }
            }
            CarregarListViewAlimentos(categoria);
            this.categoriaSelecionada = categoria;
        }

        private List<Food> carregaListView(List<Food> categoria, Alimento a, int index)
        {
            if (a.TipoAlimento == TipoAlimento.CAFES && index == 0)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.ALCOOLICAS && index == 1)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.REFRIGERANTES && index == 2)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.CARNES && index == 3)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.EMBUTIDOS && index == 4)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.PEIXES && index == 5)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.BOLACHA && index == 6)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.BALAS && index == 7)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.BOLOS && index == 8)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.CHOCOLATES && index == 9)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.DOCES && index == 10)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.GELATINAS && index == 11)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.SORVETES && index == 12)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.ADOCANTESCONDIMENTOS && index == 13)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.CREMESMOLHOS && index == 14)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.GORDURASOLEOS && index == 15)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.FRUTAS && index == 16)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.IOGURTES && index == 17)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.LEITES && index == 18)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.QUEIJOS && index == 19)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.OVOS && index == 20)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.LEGUMESVERDURAS && index == 21)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.PAES && index == 22)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.MASSAS && index == 23)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.CEREAISFARINHAS && index == 24)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.PRATOSCASEIRO && index == 25)
                categoria = a.Alimentos;
            if (a.TipoAlimento == TipoAlimento.SANDUICHES && index == 26)
                categoria = a.Alimentos;

            return categoria;
        }

        private double somaCalorias = 0;
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.somaCalorias = 0;
            lbCalorias.Text = String.Empty;
            lvIngeridos.Items.Clear();
        }       

        private void listViewAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Food f in categoriaSelecionada) {
            
                foreach (ListViewItem i in listViewAlimentos.SelectedItems)
                {
                    if (i.Index == f.Index)
                    {
                        somaCalorias += f.Caloria;

                        ListViewItem item = new ListViewItem(f.Nome);
                        item.SubItems.Add(f.Quantidade.ToString());
                        lvIngeridos.Items.Add(item);
                    }
                }
            }

            lbCalorias.Text = somaCalorias.ToString();
        }

        private List<Alimento> alimentos;
        private void carregarListaComidas()
        {
            List<Food> cafes = new List<Food>() {
                new Food(0, "Àgua de coco verde", 62, 1, "1  copo de 240 ml"),
                new Food(1, "Café com açúcar", 33, 1, "1  xícara de 50 ml"),
                new Food(2, "Café sem açúcar", 3, 1, "1  xícara de 40 ml"),
                new Food(4, "Caldo de cana", 202, 1, "1  copo de 240 ml"),
                new Food(5, "Suco de abacaxi natural", 100, 1, "1  copo de 240 ml"),
                new Food(6, "Suco de acerola natural", 36, 1, "1  copo de 240 ml"),
                new Food(7, "Suco de maça natural", 154, 1, "1  copo de 240 ml"),
                new Food(8, "Suco de manga natural", 109, 1, "1  copo de 240 ml"),
                new Food(9, "Suco de melão natural", 60, 1, "1  copo de 240 ml"),
                new Food(10, "Suco de milho verde natural", 271, 1, "1  copo de 240 ml"),
                new Food(11, "Suco de morango natural", 39, 1, "1  copo de 240 ml"),
                new Food(12, "Suco de pêssego natural", 77, 1, "1  copo de 240 ml"),
                new Food(13, "Suco de tomate fresco", 27, 1, "1  copo de 240 ml")
            };

            List<Food> alcoolicas = new List<Food>()
            {
                new Food(0, "Aguardente", 277, 0.5, "½  copo - 120 ml"),
                new Food(1, "Cerveja", 147, 1, "1  lata de 350 ml"),
                new Food(2, "Cerveja light", 148, 1, "1  lata de 360 ml"),
                new Food(3, "Champanhe", 85, 1, "1  taça de 125 ml"),
                new Food(4, "Chope", 180, 1, "1  tulipa de 300 ml"),
                new Food(5, "Uísque", 240, 1, "1  dose de 100 ml"),
                new Food(6, "Vinho branco doce", 178, 1, "1  taça de 125 ml"),
                new Food(7, "Vinho branco seco", 107, 1, "1  taça de 125 ml"),
                new Food(8, "Vinho Rosé", 93, 1, "1  taça de 125 ml"),
                new Food(9, "Vinho tinto seco", 107, 1, "1  taça de 125 ml"),
                new Food(10, "Vodka", 48, 1, "1  cálice de 20 ml")
            };

            List<Food> refrigerantes = new List<Food>() {
                new Food(0, "Coca-Cola", 137, 1, "1  lata de 350 ml"),
                new Food(1, "Coca-Cola light", 1.5, 1, "1  lata de 350 ml"),
                new Food(2, "Fanta", 189, 1, "1  lata de 350 ml"),
                new Food(3, "Fanta Diet", 15, 1, "1  lata de 350 ml"),
                new Food(4, "Gatorade - Todos os sabores", 109, 1, "1  frasco de 473 ml"),
                new Food(5, "Guaraná", 75, 1, "1  copo de 240 ml"),
                new Food(6, "Guaraná diet", 4, 1, "1  lata de 350 ml"),
                new Food(7, "Sport Drink limão", 51, 2, "2  colheres de sopa (20g)"),
                new Food(8, "Sprite", 115, 1, "1  lata de 350 ml"),
                new Food(9, "Sprite diet limão", 5, 1, "1  lata de 350 ml")
            };

            List<Food> carnes = new List<Food>() {
                new Food(0, "Acatra assada", 301, 2, "2  fatias (150g)"),
                new Food(1, "Alcatra frita", 235, 2, "2  fatias (100g)"),
                new Food(2,"Almôndega caseira de carne", 61, 1, "1  unidade (30g)"),
                new Food(3, "Almôndega de frango", 54, 1, "1  unidade (25g)"),
                new Food(4, "Almôndega de Peru", 46, 1, "1  unidade (25g)"),
                new Food(5, "Antecoxa de frango assada", 109, 2, "2  unidades (100g)"),
                new Food(6, "Baby beef", 120, 1, "1  unidade (100g)"),
                new Food(7, "Bacon Fatiado", 54, 1, "1  fatia (10g)"),
                new Food(8, "Bacon frito", 198, 2, "2  cubos (30g)"),
                new Food(9, "Bistecade porco", 337, 1, "1  unidade (100g)"),
                new Food(10, "Costela de porco", 483, 2, "2  unidades (100g)"),
                new Food(11, "Coxa de frango", 144, 1, "1  unidade (100g)"),
                new Food(12, "Coxa de frango assada c/pele", 110, 1, "1  unidade (100g)"),
                new Food(13, "Coxa de frango assada s/pele", 98, 1, "1  unidade (100g)"),
                new Food(14, "Coxa de frango cozida", 120, 1, "1  unidade (100g)"),
                new Food(15, "Cupim", 375, 2, "2  fatias (150g)"),
                new Food(16, "Fígado de boi frito", 210, 1, "1  fatia (100g)"),
                new Food(17, "Fígado de galinha", 35, 1, "1  colher de sopa (25g)"),
                new Food(18, "Filé de frango", 101, 2, "2 filés (100g)"),
                new Food(19, "Filé mignon", 140, 1, "1  fatia (100g)"),
                new Food(20, "Hamburger bovina", 116, 1, "1  unidade (56g)"),
                new Food(21, "Hamburger calabresa", 149, 1, "1  unidade (56g)"),
                new Food(22, "Hamburger de chester", 105, 1, "1  unidade (56g)"),
                new Food(23, "Hamburger de frango", 179, 1, "1  unidade (96g)"),
                new Food(24, "Lagarto de boi assado", 170, 3, "3  fatias (100g)"),
                new Food(25, "Leitão", 308, 2, "2  pedaços (170g)"),
                new Food(26, "Língua de boi cozida", 287, 2, "2  pedaços (100g)"),
                new Food(27, "Lombo assado", 272, 1, "1  fatia (100g)"),
                new Food(28, "Maminha", 141, 1, "1  fatia (100g)"),
                new Food(29, "Miolo de coxão mole", 120, 1, "1  filé (100g)"),
                new Food(30, "Moela de galinha", 78, 1, "1  pires (100g)"),
                new Food(31, "Músculo cozido", 180, 3, "3  pedaços (100g)"),
                new Food(32, "Patinho de boi assado", 200, 3, "3  fatias (100g)"),
                new Food(33, "Peito de frango s/pele", 100, 1, "1  filé (100g)"),
                new Food(34, "Pernil de porco assado", 196, 1, "1  fatias (100g)"),
                new Food(35, "Perú", 155, 2, "2  filés (100g)"),
                new Food(36, "Picanha", 287, 1, "1  fatia (100g)"),
                new Food(37, "Rã", 128, 1, "1  unidade (200g)"),
                new Food(38, "Rabo de porco salgado", 429, 3, "3  unidades (100g)"),
                new Food(39, "Rosbife", 83, 1, "1  fatia (50g)"),
                new Food(40, "Tender", 210, 4, "4  fatias (100g)")
            };

            List<Food> embutidos = new List<Food>()
            {
                new Food(0, "Apresuntado", 22, 1, "1  fatia (15g)"),
                new Food(1, "Blanquet de peru", 13, 1, "1  fatia (10g)"),
                new Food(2, "Copa fatiada maturada", 22, 1, "1  fatia (6g)"),
                new Food(3, "Linguiça calabresa", 300, 1, "1  porção (100g)"),
                new Food(4, "Linguiça de frango", 166, 1, "1  porção (100g)"),
                new Food(5, "Linguiça de peru defumada", 148, 1, "1  porção (100g)"),
                new Food(6, "Linguiça toscana", 255, 1, "1  porção (100g)"),
                new Food(7, "Lombo canadense", 21, 1, "1  fatia (15g)"),
                new Food(8, "Lombo defumado", 29, 1, "1  fatia (15g)"),
                new Food(9, "Morcela", 258, 1, "1  porção (100g)"),
                new Food(10, "Mortadela", 41, 1, "1  fatia fina (15g)"),
                new Food(11, "Mortadela de frango", 20, 1, "1  fatia fina (15g)"),
                new Food(12, "Paio", 20, 1, "1  unidade (100g)"),
                new Food(13, "Peito de peru defumado", 14, 1, "1  fatia (15g)"),
                new Food(14, "Presunto cozido", 18, 1, "1  fatia (15g)"),
                new Food(15, "Presunto cru", 54, 1, "1  fatia (15g)"),
                new Food(16, "Salame italiano", 10, 1, "1  fatia pequena (2,5g)"),
                new Food(17, "Salaminho", 10, 1, "1  fatia pequena (2,5g)"),
                new Food(18, "Salsinha", 120, 1, "1  unidade (40g)"),
                new Food(19, "Salsicha light de chester", 64, 1, "1  unidade (40g)"),
                new Food(20, "Salsicha Hot Dog", 115, 1, "1  unidade (50g)"),
                new Food(21, "Salsichão", 30, 1, "1  fatia (10g)")
            };

            List<Food> peixes = new List<Food>()
            {
                new Food(0, "Anchova cozida", 118, 1, "1  filé (100g)"),
                new Food(1, "Anchova à milanesa", 210, 1, "1  filé (100g)"),
                new Food(2, "Atum cru", 146, 1, "1  posta (100g)"),
                new Food(3, "Bacalhau cozido", 100, 1, "1  porção (100g)"),
                new Food(4, "Cação cozido", 129, 1, "1  posta (100g)"),
                new Food(5, "Camarão cozido", 82, 1, "1  porção (100g)"),
                new Food(6, "Camarão frito", 310, 1, "1  porção (100g)"),
                new Food(7, "Casquinha de Caranguejo", 250, 1, "1  unidade"),
                new Food(8, "Casquinha de Siri", 413, 1, "1  unidade (200g)"),
                new Food(9, "Caviar", 24, 1, "1  colher de chá (10g)"),
                new Food(10, "Dourado", 88, 1, "1  posta (100g)"),
                new Food(11, "Haddock cozido", 100, 1, "1  filé (100g)"),
                new Food(12, "Kani-Kama", 13, 1, "1  stick (16g)"),
                new Food(13, "Lagosta cozida s/ molho", 196, 1, "1  unidade (200g)"),
                new Food (14, "Linguado assado ou grelhado", 90, 1, "1  filé (100g)"),
                new Food(15, "Lula cozida", 93, 1, "1  pires de chá (100g)"),
                new Food(16, "Lula frita empanada", 373, 1, "1  pires de chá (100g)"), new Food(17, "Mariscos cozidos", 96, 1, "1  xícara de chá (100g)"), new Food(18, "Mexilhão cozido", 79, 0.5, "½  xícara de chá (100g)"), new Food(19, "Namorado cozido", 122, 1, "1  filé (100g)"), new Food(20, "Ostras", 81, 3, "3  unidades (100g)"),
                new Food(21, "Ovas de peixe cruas", 125, 1, "1  porção (100g)"), new Food(22, "Pescada cozida", 97, 1, "1  filé (100g)"), new Food(23, "Pintado grelhado", 208, 1, "1  posta (200g)"), new Food(24, "Polvo cru", 64, 1, "1  xícara de chá (100g)"), new Food(25, "Robalo", 72, 1, "1  posta (100g)"),
                new Food(26, "Salmão assado ou grelhado", 292, 1, "1  posta (100g)"), new Food(27, "Salmão cru", 211, 1, "1  filé (100g)"), new Food(28, "Sardinha grelhada", 97, 1, "1  unidade (33g)"), new Food(29, "Sardinha em óleo comestível", 174, 4, "4 unidades (100g)"), new Food(30, "Sardinha em conserva com azeite", 298, 3, "3  unidades (100g)"),
                new Food(31, "Tainha Cozida", 204, 1, "1  posta (100g)"), new Food(32, "Truta assada ou grelhada", 378, 1, "1  unidade (200g)")
            };

            List<Food> bolacha = new List<Food>()
            {
                new Food(0, "Água e sal", 32, 1, "1  unidade"),
                new Food(1, "Biscoito de manteiga", 500, 1, "1  porção (100g)"),
                new Food(2, "Biscoito integral de trigo", 28, 1, "1  unidade (15g)"),
                new Food(3, "Champanhe", 40, 1, "1  unidade"),
                new Food(4, "Cream Cracker", 31, 1, "1  unidade"),
                new Food(5, "Leite", 24, 1, "1  unidade"),
                new Food(6, "Maisena", 20, 1, "1  unidade"),
                new Food(7, "Maria", 25, 1, "1  unidade"),
                new Food(8, "Palitinhos salgados", 383, 1, "300g"),
                new Food(9, "Passatempo alpino", 76, 1, "1  unidade"),
                new Food(10, "Recheado chocolate", 72, 1, "1  unidade"),
                new Food(11, "Recheado morango", 73, 1, "1  unidade"),
                new Food(12, "Salclic aperitivo", 11, 1, "1  unidade"),
                new Food(13, "Waffer chocolate", 41, 1, "1 unidade")
            };

            List<Food> balas = new List<Food>()
            {
                new Food(0, "Caramelo ao leite",21, 1, "1  unidade"),
                new Food(1, "Goma média",18, 1, "1  unidade"),
                new Food(2, "Halls",19, 1, "1  unidade"),
                new Food(3, "Halls diet",8, 1, "1  unidade"),
                new Food(4, "Jujuba",5, 1, "1  unidade")
            };

            List<Food> bolos = new List<Food>()
            {
                new Food(0, "Ana Maria Pullman",130, 1, "1  unidade (50g)"),
                new Food(1, "Bolo de cenoura caseiro", 135, 1, "1  fatia (50g)"),
                new Food(2, "Bolo de cenoura com cobertura de chocolate",371, 1, "1  fatia (50g)"),
                new Food(3,"Bolo de chocolate",171, 1, "1  fatia (50g)"),
                new Food(4, "Bolo de fubá caseiro",310, 1, "1  fatia (50g)"),
                new Food(5, "Bolo de Laranja",173, 1, "1  fatia (50g)"),
                new Food(6, "Bolo pão-de-ló",268, 1, "1  fatia (50g)"),
                new Food(7, "Bolo de coco",186, 1, "1  fatia (50g)")
            };

            List<Food> chocolates = new List<Food>()
            {
                new Food(0, "Aerado ao leite",167, 1, "1  unidade (30g)"),
                new Food(1, "Alfajor chocolate",190, 1, "1  unidade (50g)"),
                new Food(2, "Alpino Bombom chocolate ao leite",71, 1, "1  unidade (13g)"),
                new Food(3, "Chocolate meio-amargo",1074, 1, "1  unidade (200g)"),
                new Food(4, "Ao leite",1044, 1, "1  unidade (200g)"),
                new Food(5, "Baton",66, 1, "1  unidade (16g)"),
                new Food(6, "Bis",39, 1, "1  unidade (7,5g)"),
                new Food(7, "Chocolate em pó solúvel",22, 1, "1  colher de sopa (6g)"),
                new Food(8, "Diamante Negro",156, 1, "1  unidade (30g)"),
                new Food(9, "Diplomata",60, 1, "1  unidade (11g)"),
                new Food(10, "Chocolate Branco",170, 1, "1  unidade (30g)"),
                new Food(11, "Ouro Branco",114, 1, "1  unidade (21,5g)"),
                new Food(12, "Sulflair",271, 1, "1  unidade (50g)"),
                new Food(13, "Trufas",89, 1, "1  unidade (20g)"),
            };

            List<Food> doces = new List<Food>()
            {
                new Food(0, "Amendoim c/ chocolate",140, 1, "1  colher de sopa (40g)"),
                new Food(1, "Apfelstrudell",296, 1, "1 fatia (100g)"),
                new Food(2, "Arroz-doce",164, 1, "1  porção (100g)"),
                new Food(3, "Baba-de-moça",615, 1, "1  taça (150g)"),
                new Food(4, "Banana Caramelada",140, 1, "1 unidade"),
                new Food(5, "Bananada",254, 2, "2  unidades (100g)"),
                new Food(6,"Banana passa",28, 1, "1 unidade (15g)"),
                new Food(7, "Bomba de chocolate",187, 1, "1  unidade (80g)"),
                new Food(8, "Bomba de chocolate c/ cobertura de chocolate",296, 1, "1  grande"),
                new Food(9, "Bombocado",91, 1, "1  unidade (30g)"),
                new Food(10, "Brigadeiro",96, 1, "1  unidade (30g)"),
                new Food(11, "Cajuzinho",102, 1, "1  unidade (12g)"),
                new Food(12, "Calda de caramelo",55, 1, "1  colher de sopa (20g)"),
                new Food(13, "Calda de chocolate com leite",109, 1, "1  colher de sopa (20g)"),
                new Food(14, "Canjica",226, 1, "1  xícara de chá (200g)"),
                new Food(15, "Chantibon",67, 1, "1  colher de sopa (15g)"),
                new Food(16, "Claybon Amendocrem",123, 1, "1  colher de sopa (20g)"),
                new Food(17, "Cobertura de caramelo",156, 1, "1  colher de sopa (15g)"),
                new Food(18, "Cobertura de cereja",147, 1, "1  colher de sopa (15g)"),
                new Food(19, "Cobertura de chocolate",128, 1, "1  colher de sopa (15g)"),
                new Food(20, "Cobertura de marshmellow",50, 1, "1  colher de sopa (15g)"),
                new Food(21, "Cocada Branca",55, 1, "1  unidade"),
                new Food(22, "Creme de amendoim",88, 1, "1  colher de sobremesa (15g)"),
                new Food(23, "Creme de marshmellow",158, 1, "1  colher de sopa (15g)"),
                new Food(24, "Doce de Banana mole",46, 1, "1  colher de sopa (20g)"),
                new Food(25, "Doce de leite",158, 1, "1  fatia (50g)"),
                new Food(26, "Folheado com creme",704, 1, "1  fatia (50g)"),
                new Food(27, "Framboesa em calda",29, 1, "1  colher de sopa (25g)"),
                new Food(28, "Geléia de goiaba",30, 1, "1  colher de sobremesa (15g)"),
                new Food(29, "Geléia de morango",39, 1, "1  colher de sobremesa (15g)"),
                new Food(30, "Geléia de mocotó",36, 1, "1  colher de sopa (20g)"),
                new Food(31, "Marmelada",264, 1, "1  fatia (100g)"),
                new Food(32, "Marrom glacê",270, 1, "1  fatia (100g)"),
                new Food(33, "Mel com própolis",65, 1, "1  colher de sopa (20g)"),
                new Food(34, "Mel de abelhas",62, 1, "1  colher de sopa (20g)"),
                new Food(35, "Mousse de chocolate",333, 1, "1  taça (150g)"),
                new Food(36, "Paçoca",333, 1, "1  unidade (30g)"),
                new Food(37, "Pamonha",135, 1, "1  unidade"),
                new Food(38, "Papo-de-anjo",150, 1, "1  unidade"),
                new Food(39, "Pastel de Santa Clara",143, 1, "1  unidade (80g)"),
                new Food(40, "Pavê",200, 1, "1  fatia (100g)"),
                new Food(41, "Pé-de-moleque",46, 1, "1  unidade (20g)"),
                new Food(42, "Pêssego em calda",81, 1, "1  unidade (100g)"),
                new Food(43, "Pudim de arroz caseiro",230, 1, "1  porção (100g)"),
                new Food(44, "Quindim caseiro",314, 1, "1  unidade (80g)"),
                new Food(45, "Rabanada",445, 3, "3  fatias (100g)"),
                new Food(46, "Rapadura",84, 1, "1  pedaço (50g)"),
                new Food(47, "Sonho",573, 1, "1  unidade (85g)"),
                new Food(48, "Suspiro pequeno",37, 1, "1  unidade (10g)")
            };

            List<Food> gelatinas = new List<Food>()
            {
                new Food(0, "Abacaxi",68, 1, "1  porção (100g)"),
                new Food(1, "Cereja",68, 1, "1  porção (100g)"),
                new Food(2, "Framboesa",68, 1, "1  porção (145g)"),
                new Food(3, "Limão",68, 1, "1  porção (100g)"),
                new Food(4, "Morango",68, 1, "1  porção (100g)"),
                new Food(5, "Uva",68, 1, "1  porção (100g)")
            };

            List<Food> sorvetes = new List<Food>()
             {
                new Food(0, "Ao leite coco",94, 1, "1  unidade"),
                new Food(1, "Ao leite morango",123, 1, "1  unidade"),
                new Food(2, "Banana Split",843, 1, "1  taça"),
                new Food(3, "Colegial",482, 1, "1  taça"),
                new Food(4, "Milk-Shake Baunilha",336, 1, "1  copo (290ml)"),
                new Food(5, "Milk-Shake Chocolate",380, 1, "1  copo (300ml)"),
                new Food(6, "Sorvete de massa chocolate creme morango e coco",75, 1, "1  bola (40g)"),
                new Food(7, "Sorvete de massa de limão",62, 1, "1  bola (40g)"),
                new Food(8,"Sundae",616, 1, "1  taça")
            };

            List<Food> adocantesCondimentos = new List<Food>()
            {
                new Food(0, "Açúcar branco refinado", 40, 1, "1  colher de chá(10g)"),
                new Food(1, "Açúcar Mascavo",36, 1, "1  colher de chá(10g)"),
                new Food(2, "Alcaparra sem azeitona",2, 1, "1  colher de chá(6g)"),
                new Food(3, "Alho",7, 1, "1  dente"),
                new Food(4, "Caldo de carne",33, 1, "1  tablete(12g)"),
                new Food(5, "Caldo de galinha",35, 1, "1  tablete(12g)"),
                new Food(6, "Cebola crua",6, 1, "1  colher de sopa(20g)"),
                new Food(7, "Cheiro verde",4, 1, "1  maço"),
                new Food(8, "Curry", 23, 1, "1  colher de café(6g)"),
                new Food(9, "Erva - doce",1, 1, "1  colher de chá(6g)"),
                new Food(10, "Extrato de tomate",14, 1, "1  colher de sopa(20g)"),
                new Food(11, "Ketchup",20, 1, "1  colher de sopa(15g)"),
                new Food(12, "Leite de coco",132, 0.5, "½  copo(120ml)"),
                new Food(13, "Molho de pimenta vermelha",2, 1, "1  colher de chá(6g)"),
                new Food(14, "Molho Inglês",5, 1, "1  colher de sopa(15g)"),
                new Food(15, "Mostarda",8, 1, "1  colher de chá(10g)"),
                new Food(16, "Páprica",20, 1, "1  colher de chá(6g)"),
                new Food(17, "Pimenta -do -reino", 1, 1, " 1 colher de chá(6g)"),
                new Food(18, "Sal branco refinado",0, 1, "1  colher de chá(6g)"),
                new Food(19, "Shoyu",6, 1, "1 colher de sopa(15g)"),
                new Food(20, "Vinagre",3, 1, "1  colher de sopa(15g)")
            };

            List<Food> cremesMolhos = new List<Food>()
             {
                new Food(0, "Branco",28, 1, "1  colher de sopa (20g)"),
                new Food(1, "Chutney de manga",82, 1, "1  colher de sopa (20g)"),
                new Food(2, "Maionese",141, 1, "1  colher de sopa (20g)"),
                new Food(3, "Molho agridoce",31, 1, "1  colher de sopa (20g)"),
                new Food(4,"Molho de iogurte",21, 1, "1  colher de sopa (15g)"),
                new Food(5, "Molho roquefort",78, 1, "1  colher de sopa (15g)"),
                new Food(6, "Molho rose",135, 1, "1  colher de sopa (15g)"),
                new Food(7, "Molho de tomate caseiro",10, 1, "1  colher de sopa (15g)"),
                new Food(8, "Molho tártaro",64, 1, "1  colher de sopa (15g)")
             };

            List<Food> gordurasOleos = new List<Food>()
            {
               new Food(0, "Azeite-de-dendê",89, 1, "1  colher de sopa (10g"),
               new Food(1, "Azeite de oliva",90, 1, "1  colher de sopa (10g)"), new Food(2, "Banha de galinha",126, 1, "1 colher de sopa (20g)"), new Food(3, "Banha de porco industrializada",180, 1, "1  colher de sopa (20g)"),
               new Food(4, "Gordura vegetal hidrogenada",180, 1, "1  colher de sopa (20g)"), new Food(5," Manteiga com sal",77, 1, "1  colher de sopa (10g)"), new Food(6, "Margarina",74, 1, "1  colher de chá (10g)"), new Food(7, "Óleo de algodão",90, 1, "1  colher de sopa (10g)"),
               new Food(8, "Óleo de amendoim",90, 1, "1  colher de sopa (10g)"), new Food(9, "Óleo de canola",90, 1, "1  colher de sopa (10g)"), new Food(10, "Óleo de fígado de bacalhau",130, 1, "1  colher de sopa (13g)"), new Food(11, "Óleo de gergelim",90, 1, "1  colher de sopa (10g)"),
               new Food(12, "Óleo de girassol",90, 1, "1 colher de sopa (10g)"), new Food(13, "Óleo de milho",90, 1, "1  colher de sopa (10g)"),new Food(14,"Óleo de peixe",90, 1, "1 colher de sopa (10g)"), new Food(15, "Óleo de soja",90, 1, "1  colher de sopa (10g)")
            };

            List<Food> frutas = new List<Food>()
            {
                new Food(0, "Abacate",177, 1, "1 porção (100g)"), new Food(1, "Abacaxi",50, 1, "1  fatia (80g)"), new Food(2,"Acerola",4, 1, "1  unidade (12g)"), new Food(3, "Banana-da-terra",117, 1, "1 unidade (100g)"),
                new Food(4, "Banana-maçã",72, 1, "1  unidade (65g)"), new Food(5, "Banana-nanica",87, 1, "1  unidade (90g)"), new Food(6, "Banana-prata crua",55, 1, "1  unidade (65g)"), new Food(7, "Caju",37, 1, "1  unidade (100g)"),
                new Food(8, "Cana-de-açúcar",64, 1, "1  gomo (100g)"), new Food(9, "Caqui chocolate",74, 1, "1  unidade (100g)"), new Food(10, "Castanha de caju picada",835, 1, "1  xícara de chá (150g)"), new Food(11, "Cereja",97, 1, "1  porção (100g)"),
                new Food(12, "Coco ralado fresco",50, 1, "1  colher de sopa (20g)"), new Food(13, "Figo maduro",68, 1, "1  unidade (50g)"), new Food(14, "Framboesa",12, 1, "1  colher de sopa (20g)"), new Food(15, "Goiaba vermelha",43, 1, "1  unidade (100g)"),
                new Food(16, "Graviola",60, 1, "1  unidade (100g)"), new Food(17, "Guaraná",69, 1, "1 00g"), new Food(18, "Kiwi",46, 1, "1  unidade"), new Food (19, "Laranja",46, 1, "1  unidade"),
                new Food(20, "Limão",12, 1, "1 unidade"),new Food(21, "Maçã verde", 79, 1, "1  unidade (130g)"), new Food(22, "Maçã vermelha",85, 1, "1  unidade (130g)"), new Food(23, "Mamão maduro",36, 1, "1  fatia (100g)"),
                new Food(24, "Manga",230, 1, "1  unidade (350g)"), new Food(25, "Maracujá comum (polpa)",28, 1, "1 unidade (50g)"), new Food(26, "Melancia",24, 1, "1 fatia (100g)"), new Food(27, "Melão",19, 1, "1  fatia (70g)"),
                new Food(28, "Morango", 43, 9, "9 unidades (100g)"), new Food(29, "Nozes",71, 1, "1 unidade (10g)"), new Food(30, "Pêra crua",68, 1, "1  unidade (110g)"), new Food(31, "Pêra seca",144, 1, "1 xícara de chá (150g)"),
                new Food(32, "Pêssego",63, 1, "1  unidade (150g)"), new Food(33, "Tangerina",50, 1, "1  unidade (100g)"), new Food(34, "Uva branca nacional",130, 1, "1  cacho pequeno"),new Food(35, "Uva passa",54, 1, "1  colher de sopa (18g)")
            };

            List<Food> leites = new List<Food>()
            {
                new Food(0, "Achocolatado Leco",194, 1, "1  copo (200ml)"), new Food(1, "Chocolate pronto Glória",204, 1, "1  unidade"), new Food(2, "Creme de leite",37, 1, "1  colher de sopa (15g)"), new Food(3, "Leite com chocolate",222, 1, "1  xícara (200ml)"),
                new Food(4, "Leite condensado",65, 1, "1  colher de sopa (20g)"), new Food(5, "Leite de búfala",253, 1, "1  copo (240ml)"), new Food(6, "Leite de cabra",220, 1, "1  copo (240ml)"), new Food(7, "Leite de soja",120, 1, "1  copo (240ml)"),
                new Food(8, "Leite em pó desnatado",73, 2, "2  colheres de sopa (40g)"), new Food(9, "Leite em pó integral",99, 1, "1  colher de sopa (20g)"), new Food(10, "Leite integral",150, 1, "1  copo (240ml)"), new Food(11, "Leite longa vida c/ ferro",146, 1, "1  copo (240ml)"),
                new Food(12, "Leite semidesnatado",115, 1, "1  copo (240ml)")
            };

            List<Food> queijos = new List<Food>()
            {
                new Food(0, "Brie",110, 1, "1  fatia (30g)"), new Food(1, "Camembert",136, 1, "1  unidade (50g)"), new Food(2, "Catupiry",49, 1, "1  colher de sopa (20g)"), new Food(3, "Cheddar americano",107, 1, "1  fatia (30g)"),
                new Food(4, "Cottage Lacreme",55, 2, "2  colheres de sopa (30g)"),new Food(5, "Cream cheese light Danúbio",38, 1, "1  colher de sopa (20g)"), new Food(6, "Cream cheese tradicional Alouette",70, 1, "1  colher de sopa (20g)"), new Food(7, "Edam",92, 1, "1  fatia (30g)"),
                new Food(8, "Ementhal",85, 1, "1  fatia (30g)"),new Food(9, "Estepe",52, 1, "1  fatia (30g)"), new Food(10, "Gorgonzola",119, 1, "1  porção (30g)"), new Food(11, "Gouda Luna",107, 1, "1  fatia (30g)"),
                new Food(12, "Gruyère francês",93, 1, "1  porção (25g)"), new Food(13, "Mussarela",47, 1, "1  fatia (15g)"), new Food(14, "Palmira",114, 1, "1  fatia (30g)"), new Food(15, "Parmesão",121, 1, "1  fatia (30g)"),
                new Food(16, "Pecorino",128, 1, "1  fatia (35g)"), new Food(17, "Petit-Suisse",45, 1, "1  unidade (25g)"), new Food(18, "Polenguinho",57, 1, "1  unidade"), new Food(19, "Prato",53, 1, "1  fatia (15g)"),
                new Food(20, "Provolone",51, 1, "1  fatia (15g)"), new Food(21, "Queijo-de-minas",112, 1, "1  fatia (30g)"), new Food(22, "Queijo-de-minas semicurado",90, 1, "1  fatia (30g)"), new Food(23, "Queijo-do -reino",155, 1, "1  fatia(30g)"),
                new Food(24, "Ricota de leite integral",54, 1, "1  fatia(30g)"), new Food(25, "Requeijão cremoso Nestlé",54, 1, "1  colher de sopa(20g)"), new Food(26, "Requeijão cremoso light Nestlé",36, 1, "1  colher de sopa(20g)"), new Food(27, "Roquefort",100, 1, "1  porção(25g)"),
                new Food(28, "Suíço",121, 1, "1  fatia(30g)"), new Food(29, "Tofú(queijo de soja)",68, 1, "1 porção(50g)")
            };

            List<Food> ovos = new List<Food>()
            {
                new Food(0, " Omelete",170, 1, "1  porção (100g)"), new Food(1, "Ovo de codorna",33, 1, "1  unidade"), new Food(2, "Ovo de galinha cozido",78, 1, "1  unidade"), new Food(3, "Ovo de galinha frito",108, 1, "1  unidade"),
                new Food(4, "Ovo mexido",195, 1, "1 porção (100g)")
            };

            List<Food> legumesVerduras = new List<Food>()
            {
                new Food(0, "Abóbora",40, 1, "1 porção (100g)"), new Food(1, "Agrião",28, 1, "1  porção (100g)"), new Food(2, "Aipim frito",353, 1, "1  pires de chá (100g)"), new Food(3,"Alface",4, 2, "2  folhas (20g)"),
                new Food(4, "Amendoim",549, 1, "1  porção (100g)"), new Food(5, "Arroz branco cozido",41, 1, "1  colher de sopa (25g)"), new Food(6, "Arroz integral cozido",22, 1, "1 colher de sopa (20g)"), new Food(7, "Aspargo cozido",4, 2, "2  talos (20g)"),
                new Food(8, "Azeitona preta",4, 1, "1  unidade (3g)"), new Food(9, "Azeitona verde",5, 1, "1  unidade (4g)"), new Food(10, "Batata-doce assada",143, 1, "1  unidade (100g)"), new Food(11, "Batata-doce frita",383, 1, "1  unidade (100g)"),
                new Food(12, "Batata palha frita",220, 1, "1  porção (70g)"), new Food(13, "Berinjela",489, 1, "1  unidade (250g)"), new Food(14, "Beterraba",55, 1, "1  pequena (125g)"), new Food(15, "Brócolis",23, 1, "1  pires de chá (80g)"),
                new Food(16, "Cebola",32, 1, "1  unidade (70g)"), new Food(17,"Cebola cozida",54, 1, "1  unidade (100g)"), new Food(18, "Cenoura",45, 1, "1  unidade (100g)"), new Food(19, "Cenoura cozida",54, 1, "1  unidade (100g)"),
                new Food(20, "Couve-flor cozida",41, 1, "1 porção (100g)"), new Food(21, "Ervilha em conserva",19, 1, "1  colher de sopa (20g)"), new Food(22, "Escarola",7, 2, "2  folhas (20g)"), new Food(23,"Espinafre",38, 1, "1  pires de chá (100g)"),
                new Food(24, "Feijão-branco cozido",24, 1, "1  colher de sopa (20g)"), new Food(25, "Feijão cozido e desidratado",78, 1, "1  colher de sopa (20g)"), new Food(26, "Feijão-preto cozido",14, 1, "1  colher de sopa (20g)"), new Food(27, "Mandioca frita",352, 1, "1 pires de chá (100g)"),
                new Food(28, "Palmito cru",26, 1, "1  pires de chá (100g)"), new Food(29, "Palmito em conserva",22, 1, "1  unidade (100g)"), new Food(30, "Pepino cru com casca",21, 1, "1  unidade (150g)"), new Food(31, "Pepino cru sem casca",5, 1, "1  unidade (150g)"),
                new Food(32, "Repolho",33, 1, "1 porção (100g)"), new Food(33, "Repolho cozido",13, 1, "1  porção (100g)"), new Food(34, "Tomate cozido",18, 1, "1  unidade (100g)"), new Food(35, "Tomate maduro", 20, 1, "1  unidade (100g)"),
                new Food(36, "Vagem cozida",52, 1, "1 porção (100g)")
            };

            List<Food> paes = new List<Food>()
            {
                new Food(0,"Baguete",70, 1, "1  fatia grossa"), new Food(1, "Baguete com gergelim",82, 1, "1  fatia grossa"), new Food(2, "Bisnaguinha",45, 1, "1  unidade"), new Food(3, "Brioche",210, 1, "1  unidade"),
                new Food(4, "Broa de milho",150, 1, "1  unidade"), new Food(5, "Croissant",247, 1, "1  unidade (60g)"), new Food(6, "Panetone",283, 1, "1  fatia (100g)"), new Food(7, "Pão de batata-inglesa",90, 1, "1  unidade (30g)"),
                new Food(8, "Pão de cará",140, 1, "1  unidade (50g)"), new Food(9, "Pão de centeio integral",58, 1, "1 fatia"), new Food(10, "Pão francês",135, 1, "1  unidade (50g)"), new Food(11, "Pão de fôrma tradicional",74, 1, "1  fatia"),
                new Food(12, "Pão de hambúrguer",278, 1, "1  unidade (100g)"), new Food(13, "Pão de hot-dog",286, 1, "1  unidade (100g)"), new Food(14, "Pão de mel c/ cobertura de chocolate",91, 1, "1  unidade (20g)"), new Food(15, "Pão de queijo",68, 1, "1  unidade (20g)"),
                new Food(16, "Pão integral de trigo",261, 1, "1  fatia(100g)"), new Food(17, "Pão sírio integral",147, 1, "1  unidade (50g)")
            };

            List<Food> massas = new List<Food>()
            {
                new Food(0, "Canelone de presunto e queijo à bolonhesa",552, 2, "2  unidades (150g)"), new Food(1, "Capelete de carne",278, 1, "1  xícara de chá (100g)"), new Food(2, "Capelete de frango",279, 1, "1  xícara de chá (100g)"), new Food(3, "Espaguete comum cozido",233, 1, "1  prato (160g)"),
                new Food(4,"Espaguete ao sugo",163, 1, "1  prato (160g)"), new Food(5, "Lasanha",139, 1, "1  porção (100g)"), new Food(6, "Macarrão à carbonara",362, 1, "1  prato (100g)"), new Food(7, "Macarrão integral cozido",195, 1, "1  prato (160g)"),
                new Food(8,"Macarrão com molho de tomate e queijo",104, 1, "1  xícara de chá (100g)"), new Food(9,"Macarrão cozido",154, 1, "1  xícara de chá (100g)"), new Food(10, "Macarronada",289, 1, "1  prato"), new Food(11, "Nhoque s/ molho",227, 1, "1  prato (160g)"),
                new Food(12, "Pizza alho e óleo",276, 1, "1  fatia (140g)"), new Food(13,"Pizza de calabresa",412, 1, "1  fatia (140g)"), new Food(14,"Pizza de catupiry com tomate",324, 1, "1  fatia (140g)"), new Food(15, "Pizza de champignon c/ mussarela",249, 1, "1 fatia (140g)"),
                new Food(16, "Pizza de escarola c/ mussarela",246, 1, "1  fatia (140g)"), new Food( 17, "Pizza de frango com catupiry",305, 1, "1  fatia (140g)"), new Food(18, "Pizza de mussarela",304, 1, "1  fatia (140g)"), new Food(19, "Pizza margherita",275, 1, "1  fatia (140g)"),
                new Food(20, "Pizza portuguesa",396, 1, "1  fatia (140g)"), new Food(21, "Pizza quatro queijos",432, 1, "1  fatia (140g)")
            };

            List<Food> cereaisFarinhas = new List<Food>()
            {
                new Food(0, "Aveia em flocos",50, 1, "1  colher de sopa (15g)"), new Food(1, "Corn Flakes",217, 1, "1  prato (110g)"), new Food(2, "Farinha de amendoim",56, 1, "1  colher de sopa (15g)"), new Food(3, "Farinha de arroz",53, 1, "1  colher de sopa (15g)"),
                new Food(4, "Farinha de aveia-crua",57, 1, "1  colher de sopa (15g)"), new Food(5, "Farinha de batata-doce",52, 1, "1  colher de sopa (15g)"), new Food(6, "Farinha de batata-inglesa",53, 1, "1 colher de sopa (15g)"), new Food(7, "Farinha de fubá de milho",69, 1, "1  colher de sopa (20g)"),
                new Food(8, "Farinha de mandioca",54, 1, "1  colher de sopa (15g)"), new Food(9, "Farinha de milho integral",30, 1, "1  colher de sopa (15g)"), new Food(10, "Farinha de rosca",54, 1, "1  colher de sopa (15g)"), new Food(11, "Farinha de trigo",54, 1, "1  colher de sopa (15g)"),
                new Food(12, "Granola com castanhas",300, 1, "1  xícara de chá (60g)"), new Food(13, "Grão de aveia cru",48, 1, "1  colher de sopa (15g)"), new Food(14, "Germe de trigo",55, 1, "1  colher de sopa (15g)"), new Food(15, "Maisena",52, 1, "1  colher de sopa (15g)"),
                new Food(16, "Malte em pó",56, 1, "1  colher de sopa (15g)")
            };

            List<Food> pratosCaseiro = new List<Food>()
            {
                new Food(0, "Arroz com feijão",75, 2, "2  colheres de sopa (40g)"), new Food(1, "Arroz-de-carreteiro",56, 1, "1  colher de sopa (20g)"), new Food(2, "Bife á parmegiana",485, 1, "1 bife"), new Food(3, "Carne de panela",230, 1, "1 bife (100g)"),
                new Food(4, "Creme de milho c/ leite e maisena",72, 1, "1  colher de sopa (20g)"), new Food(5, "Empadão de frango",359, 1, "1  fatia (100g)"), new Food(6, "Estrogonofe", 332, 1, "1  concha"), new Food(7, "Farofa",169, 1, "1  colher de sopa (20g)"),
                new Food(8, "Feijoada",273, 1, "1  concha"), new Food(9, "Frango xadrez",180, 1, "1  porção"), new Food(10, "Leitão a pururuca",966, 1, "1 porção"), new Food(11, "Moqueca de peixe",325, 1, "1  concha"),
                new Food(12, "Panqueca",60, 1, "1  unidade(30g)"),new Food(13, "Pimentão assado com carne",298, 1, "1  unidade (200g)"), new Food(14, "Rabada",389, 1, "1  porção"), new Food(15, "Ratatoille",38, 1, "1  colher de sopa (20g)"),
                new Food(16, "Risoto caseiro",52, 1, "1  colher de sopa (20g)"), new Food(17, "Salada de batata",147, 1, "1  xícara de chá (100g)"), new Food(18, "Sashimi c/ atum namorado, linguado e nabo",363, 1, "1  porção"), new Food(19, "Tabule",52, 1, "1  colher de sopa (20g)"),
                new Food(20, "Torta de camarão",310, 1, "1  fatia (100g)"), new Food(21, "Vatapá",227, 1, "1  concha")
            };

            List<Food> sanduiches = new List<Food>()
            {
                new Food(0, "Beirute",510, 1, "1  unidade"), new Food(1, "Cachorro-quente com maionese e molho vinagrete",624, 1, "1  unidade"), new Food(2, "Cachorro-quente com ketchup",314, 1, "1  unidade"), new Food(3, "Cachorro-quente com mostarda",330, 1, "1  unidade"),
                new Food(4, "Cachorro-quente com ketchup e mostarda",342, 1, "1  unidade"), new Food(5, "Cheeseburguer",305, 1, "1  unidade"), new Food(6, "cheese salada com maionese",738, 1, "1  unidade"), new Food(7, "Hambúrguer",296, 1, "1  unidade"),
                new Food(8, "Misto quente",283, 1, "1  unidade"), new Food(9, "Sanduíche de linguiça",370, 1, "1  unidade"), new Food(10, "Sanduíche de peito de peru",220, 1, "1  unidade"), new Food(11, "Sanduíche de queijo quente",340, 1, "1  unidade"),
                new Food(12, "Sanduíche de salada de atum",417, 1, "1  unidade")
            };

            alimentos = new List<Alimento>()
            {
                new Alimento(TipoAlimento.CAFES, cafes),
                new Alimento(TipoAlimento.ALCOOLICAS, alcoolicas),
                new Alimento(TipoAlimento.REFRIGERANTES, refrigerantes),
                new Alimento(TipoAlimento.CARNES, carnes),
                new Alimento(TipoAlimento.EMBUTIDOS, embutidos),
                new Alimento(TipoAlimento.PEIXES, peixes),
                new Alimento(TipoAlimento.BOLACHA, bolacha),
                new Alimento(TipoAlimento.BALAS, balas),
                new Alimento(TipoAlimento.BOLOS, bolos),
                new Alimento(TipoAlimento.CHOCOLATES, chocolates),
                new Alimento(TipoAlimento.DOCES, doces),
                new Alimento(TipoAlimento.GELATINAS, gelatinas),
                new Alimento(TipoAlimento.SORVETES, sorvetes),
                new Alimento(TipoAlimento.ADOCANTESCONDIMENTOS, adocantesCondimentos),
                new Alimento(TipoAlimento.CREMESMOLHOS, cremesMolhos),
                new Alimento(TipoAlimento.GORDURASOLEOS, gordurasOleos),
                new Alimento(TipoAlimento.FRUTAS, frutas),
                new Alimento(TipoAlimento.LEITES, leites),
                new Alimento(TipoAlimento.QUEIJOS, queijos),
                new Alimento(TipoAlimento.OVOS, ovos),
                new Alimento(TipoAlimento.LEGUMESVERDURAS, legumesVerduras),
                new Alimento(TipoAlimento.PAES, paes),
                new Alimento(TipoAlimento.MASSAS, massas),
                new Alimento(TipoAlimento.CEREAISFARINHAS, cereaisFarinhas),
                new Alimento(TipoAlimento.PRATOSCASEIRO, pratosCaseiro),
                new Alimento(TipoAlimento.SANDUICHES, sanduiches),
            };

        }
    }
}
