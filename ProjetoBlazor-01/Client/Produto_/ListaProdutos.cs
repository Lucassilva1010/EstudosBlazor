namespace ProjetoBlazor_01.Client.Produto_
{
  public class ListaProdutos
  {

        public List<ItensP> LProdutos { get { return GProdutos(); } }//Proprieade para acessar o metodo


        //Metodo que cria a minha lista de Itens para aparecer na minha loja, usando o Foreach e o for
        public  List<ItensP> GProdutos()
        {
            return new List<ItensP>(){

                new ItensP()
                {
                    Nome = "Telefone Celular",
                    Data = new DateTime(18,11,2022)
                },

                new ItensP()
                {
                    Nome =  "Tv de LED",
                    Data = new DateTime(17,11,2022)
                },

                new ItensP()
                {
                    Nome = "Computador",
                    Data = new DateTime(16/11/2022)
                },

                new ItensP()
                {
                    Nome = "Kit Multimedia",
                    Data = new DateTime(20/10/2021)
                }

            };
        }
  }
}

