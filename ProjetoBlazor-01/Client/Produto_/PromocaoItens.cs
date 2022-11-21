namespace ProjetoBlazor_01.Client.Produto_
{
    public class PromocaoItens
    {

        public static List<ItensP> ProdutosPromo { get { return ItensPromo(); } }


        public static List<ItensP> ItensPromo()
        {
            return new List<ItensP>()
            {
                new ItensP()
                {
                    Nome = "Celular",
                    Data =  new DateTime(2022,11,20),
                    Valor = "2.000,00"
                    
                },
                new ItensP()
                {
                    Nome =  "Tv de LED",
                    Data = new DateTime(2022, 11, 17),
                    Valor = "5.000,00"
                },

                new ItensP()
                {
                    Nome = "Computador",
                    Data = new DateTime(2022, 11, 17),
                    Valor = "4.000,00"
                },

                new ItensP()
                {
                    Nome = "Kit Multimedia",
                    Data = new DateTime(2022, 11, 17),
                     Valor = "100,00"
                },
                 new ItensP()
                {
                    Nome = "Fones de Ouvido",
                    Data = new DateTime(2022, 11, 20),// A representação das dats precisam ser sempre dessa forma para que possamos converter no formato correto
                     Valor = "150,00"
                 },

                new ItensP()
                {
                    Nome =  "Telcados",
                    Data = new DateTime(2022, 11, 20),
                     Valor = "30,00"
                },

                new ItensP()
                {
                    Nome = "Roteadores",
                    Data = new DateTime(2022, 11, 20),
                     Valor = "500,00"
                },

                new ItensP()
                {
                    Nome = "Mouses",
                    Data = new DateTime(2022, 11, 20),
                     Valor = "150,00"
                }

            };
        }
    }
}
