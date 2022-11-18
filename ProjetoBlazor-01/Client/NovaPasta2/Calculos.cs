namespace ProjetoBlazor_01.Client.NovaPasta2
{
       public class Calculos
       {
            public static double Soma(double n1, double n2)
            {
                return n1 + n2;
            }

        public static string Login(string nome, int senha)
        {
            string user = "lucas";
            int ss = 132;

            if (user == nome && ss==senha) {
                return "Usuario Logado";
            } else
            {
                return "Usuario ou senha Incorreto!";
            }

        }


       }
}
