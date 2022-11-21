namespace ProjetoBlazor_01.Client.Produto_
{
  public class ListaProdutos
  {

        public static List<ItensP> ListProdutos { get { return GProdutos(); } }//Proprieade para acessar o metodo


        //Metodo que cria a minha lista de Itens para aparecer na minha loja, usando o Foreach e o for
        public static List<ItensP> GProdutos()
        {
            return new List<ItensP>(){

                new ItensP()
                {
                    Nome = "Telefone Celular",
                    Data = new DateTime(2022, 11, 17)// A representação das dats precisam ser sempre dessa forma para que possamos converter no formato correto
                },

                new ItensP()
                {
                    Nome =  "Tv de LED",
                    Data = new DateTime(2022, 11, 17)
                },

                new ItensP()
                {
                    Nome = "Computador",
                    Data = new DateTime(2022, 11, 17)
                },

                new ItensP()
                {
                    Nome = "Kit Multimedia",
                    Data = new DateTime(2022, 11, 17)
                },
                       

                new ItensP()
                {
                    Nome = "Fones de Ouvido",
                    Data = new DateTime(2022, 11, 20)// A representação das dats precisam ser sempre dessa forma para que possamos converter no formato correto
                },

                new ItensP()
                {
                    Nome =  "Telcados",
                    Data = new DateTime(2022, 11, 20)
                },

                new ItensP()
                {
                    Nome = "Roteadores",
                    Data = new DateTime(2022, 11, 20)
                },

                new ItensP()
                {
                    Nome = "Mouses",
                    Data = new DateTime(2022, 11, 20)
                }

            };
        }
  }
}

