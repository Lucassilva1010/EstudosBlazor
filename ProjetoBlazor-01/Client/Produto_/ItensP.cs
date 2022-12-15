namespace ProjetoBlazor_01.Client.Produto_
{
    public class ItensP
        {
        public Guid ID { get; set; }
        public string Nome { get; set; } = "";
        public string Valor { get; set; } = ""; 
        public DateTime Data { get; set; }
        public bool Diponibilidade { get; set; }




        public static List<ItensP> ListProdutos { get { return GProdutos(); } }//Proprieade para acessar o metodo


        //Metodo que cria a minha lista de Itens para aparecer na minha loja, usando o Foreach e o for
        public static List<ItensP> GProdutos()
        {
            return new List<ItensP>(){

                new ItensP()
                {
                    Nome = "Telefone Celular",
                    Valor = "200,00",
                    Data = new DateTime(2022, 11, 17),// A representação das dats precisam ser sempre dessa forma para que possamos converter no formato correto
                 Diponibilidade = false
                },

                new ItensP()
                {
                    Nome =  "Tv de LED",
                    Valor = "200,00",
                    Data = new DateTime(2022, 11, 17),
                    Diponibilidade = false
                },

                new ItensP()
                {
                    Nome = "Computador",
                    Valor = "200,00",
                    Data = new DateTime(2022, 11, 17),
                    Diponibilidade = false
                },

                new ItensP()
                {
                    Nome = "Kit Multimedia",
                    Valor = "200,00",
                    Data = new DateTime(2022, 11, 17),
                    Diponibilidade = false
                },


                new ItensP()
                {
                    Nome = "Fones de Ouvido",
                    Valor = "200,00",
                    Data = new DateTime(2022, 11, 20),// A representação das dats precisam ser sempre dessa forma para que possamos converter no formato correto
                    Diponibilidade = false
                },

                new ItensP()
                {
                    Nome =  "Telcados",
                    Valor = "200,00",
                    Data = new DateTime(2022, 11, 20),
                    Diponibilidade = false
                },

                new ItensP()
                {
                    Nome = "Roteadores",
                    Valor = "200,00",
                    Data = new DateTime(2022, 11, 20),
                        Diponibilidade = false
                },

                new ItensP()
                {
                    Nome = "Mouses",
                    Valor = "200,00",
                    Data = new DateTime(2022, 11, 20),
                    Diponibilidade = false
                }

            };
        }
    }
}

