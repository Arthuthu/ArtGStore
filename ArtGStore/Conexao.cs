using System.Data.SqlClient;

namespace ArtGStore.Mapeamento
{
    public class Conexao
    {
        public SqlConnection banco;
        public Conexao()
        {
            if (banco == null)
               //banco = new SqlConnection(@"Server=.\SQLExpress;Database=BancoArtGStore;Trusted_Connection=Yes;");
            banco = new SqlConnection(Sessao.StringConn);
        }
    }
}
