using ArtGStore.Mapeamento;
using System.Data;
using System.Data.SqlClient;

namespace ArtGStore.Negocios
{
    public class CategoriaDAO : Conexao
    {  
        public DataTable Listar()
        {
            DataTable lista = new DataTable();

            SqlCommand cmd = new SqlCommand("Select ID, Nome from Categorias order by nome ", banco);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(lista);

            return lista;
        }

        public bool InserirCategoria(string nome)
        {
            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Categorias 
                  (Nome) 
                  VALUES
                 (@pNome)", banco);
            cmd.Parameters.Add(new SqlParameter("pNome", nome.Trim())); ;

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }

        public bool AlterarCategoria(int id, string nome)
        {
            SqlCommand cmd = new SqlCommand(
                @"UPDATE Categorias SET 
                  Nome = @pNome 
                  WHERE
                 ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", id));
            cmd.Parameters.Add(new SqlParameter("pNome", nome.Trim()));

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }

        public bool ApagarCategoria(int id)
        {
            SqlCommand cmd = new SqlCommand(
               @"DELETE FROM Categorias WHERE ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", id));

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }

        internal DataRow Buscar(int idCategoria)
        {
            DataTable lista = new DataTable();

            SqlCommand cmd = new SqlCommand(@"
                                            SELECT * 
                                            FROM Categorias   
                                            WHERE ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", idCategoria));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(lista);

            return lista.Rows[0];
        }

        public DataTable BuscarTodasCategorias()
        {
            DataTable lista = new DataTable();

            SqlCommand cmd = new SqlCommand("Select * from vwListarCategorias order by nome ", banco);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(lista);

            return lista;
        }
    }
}
