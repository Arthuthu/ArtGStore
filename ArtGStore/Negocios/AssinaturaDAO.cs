using ArtGStore.Mapeamento;
using System.Data;
using System.Data.SqlClient;

namespace ArtGStore.Negocios
{
    public class AssinaturaDAO : Conexao
    {

        public DataTable BuscarTodasAssinaturas()
        {
            DataTable lista = new DataTable();

            SqlCommand cmd = new SqlCommand("Select * from vwListarAssinaturas order by nome ", banco);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(lista);

            return lista;
        }

        public DataRow BuscarAssinatura(int id)
        {
            DataTable lista = new DataTable();

            SqlCommand cmd = new SqlCommand(@"
                                            SELECT * 
                                            FROM Assinaturas   
                                            WHERE ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", id));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(lista);

            return lista.Rows[0];
        }

        public bool Apagar(int id)
        {
            SqlCommand cmd = new SqlCommand(
               @"DELETE FROM Assinaturas WHERE ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", id));

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }

        public bool Inserir(string nome, int quantidade, decimal valorUnitario)
        {
            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Assinaturas 
                  (Nome, Quantidade, ValorUnitario) 
                  VALUES
                 (@pNome, @pQuantidade, @pValorUnitario)", banco);
            cmd.Parameters.Add(new SqlParameter("pNome", nome.Trim())); ;
            cmd.Parameters.Add(new SqlParameter("pQuantidade", quantidade));
            cmd.Parameters.Add(new SqlParameter("pValorUnitario", valorUnitario));

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }

        public bool Alterar(int id, string nome, int quantidade, decimal valorUnitario)
        {
            SqlCommand cmd = new SqlCommand(
                @"UPDATE Assinaturas SET 
                    Nome = @pNome, 
                    Quantidade = @pQuantidade, ValorUnitario = @pValorUnitario
                  WHERE
                 ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", id));
            cmd.Parameters.Add(new SqlParameter("pNome", nome.Trim()));
            cmd.Parameters.Add(new SqlParameter("pQuantidade", quantidade));
            cmd.Parameters.Add(new SqlParameter("pValorUnitario", valorUnitario));

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }

    }
}
