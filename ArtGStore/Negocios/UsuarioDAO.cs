using ArtGStore.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace ArGStore.Negocios
{
    public class UsuarioDAO : Conexao
    {
        public Usuario Login(string email, string senha)
        {
            try
            {
                var usuario = banco.Query<Usuario>(
                      @"SELECT  
                        ID, Nome, Email, AcessaCategorias, AcessaProdutos, 
                        AcessaUsuarios, Ativo, AcessaAssinaturas
                      FROM 
                        Usuarios 
                      WHERE 
                        Email = @pEmail and Senha = @pSenha",
                      new
                      {
                          pEmail = email,
                          pSenha = senha
                      }).SingleOrDefault();

                return usuario;
            }
            catch
            {
                return null;
            }
        }

        public bool InserirUsuario(string nome, string email, string senha, bool AcessaCategorias, bool AcessaProdutos, bool AcessaUsuarios, bool Ativo, bool AcessaAssinaturas)
        {
            SqlCommand cmd = new SqlCommand(
                @"INSERT INTO Usuarios 
                  (Nome, Email, Senha, AcessaCategorias, AcessaProdutos, AcessaUsuarios, Ativo, AcessaAssinaturas) 
                  VALUES
                 (@pNome, @pEmail, @pSenha, @pAcessaCategorias, @pAcessaProdutos, @pAcessaUsuarios, @pAtivo, @pAcessaAssinaturas)", banco);
            cmd.Parameters.Add(new SqlParameter("pNome", nome.Trim()));;
            cmd.Parameters.Add(new SqlParameter("pEmail", email.Trim()));;
            cmd.Parameters.Add(new SqlParameter("pSenha", senha.Trim()));
            cmd.Parameters.Add(new SqlParameter("pAcessaCategorias", AcessaCategorias));
            cmd.Parameters.Add(new SqlParameter("pAcessaProdutos", AcessaProdutos));
            cmd.Parameters.Add(new SqlParameter("pAcessaUsuarios", AcessaUsuarios));
            cmd.Parameters.Add(new SqlParameter("pAtivo", Ativo));
            cmd.Parameters.Add(new SqlParameter("pAcessaAssinaturas", AcessaAssinaturas));

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }

        public bool AlterarUsuario(int id, string nome, string email, string senha, bool AcessaCategorias, bool AcessaProdutos, bool AcessaUsuarios, bool Ativo, bool AcessaAssinaturas)
        {
            SqlCommand cmd = new SqlCommand(
                @"UPDATE Usuarios SET 
                    Nome = @pNome, Email = @pEmail, Senha = @pSenha, AcessaCategorias = @pAcessaCategorias,
                    AcessaProdutos = @pAcessaProdutos, AcessaUsuarios = @pAcessaUsuarios,
                    Ativo = @pAtivo, AcessaAssinaturas = @pAcessaAssinaturas
                  WHERE
                 ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", id));
            cmd.Parameters.Add(new SqlParameter("pNome", nome.Trim())); ;
            cmd.Parameters.Add(new SqlParameter("pEmail", email.Trim())); ;
            cmd.Parameters.Add(new SqlParameter("pSenha", senha.Trim()));
            cmd.Parameters.Add(new SqlParameter("pAcessaCategorias", AcessaCategorias));
            cmd.Parameters.Add(new SqlParameter("pAcessaProdutos", AcessaProdutos));
            cmd.Parameters.Add(new SqlParameter("pAcessaUsuarios", AcessaUsuarios));
            cmd.Parameters.Add(new SqlParameter("pAtivo", Ativo));
            cmd.Parameters.Add(new SqlParameter("pAcessaAssinaturas", AcessaAssinaturas));

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }


        public DataTable BuscarTodosUsuarios()
        {
            DataTable lista = new DataTable();

            SqlCommand cmd = new SqlCommand("Select * from vwListarUsuarios order by nome ", banco);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(lista);

            return lista;
        }

        public DataRow BuscarUsuario(int id)
        {
            DataTable lista = new DataTable();

            SqlCommand cmd = new SqlCommand(@"
                                            SELECT * 
                                            FROM Usuarios   
                                            WHERE ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", id));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(lista);

            return lista.Rows[0];
        }

        public bool CompararSenhas(int id, string senha)
        {
            try
            {
                var usuario = banco.Query<Usuario>(
                      @"SELECT  
                        ID, Nome, Email, Senha 
                      FROM 
                        Usuarios 
                      WHERE 
                        ID = @pID",
                      new
                      {
                          pID = id
                      }).SingleOrDefault();

                return usuario.Senha == senha;
            }
            catch
            {
                return false;
            }
        }

        public bool ApagarUsuario(int id)
        {
            SqlCommand cmd = new SqlCommand(
               @"DELETE FROM Usuarios WHERE ID = @pID", banco);
            cmd.Parameters.Add(new SqlParameter("pID", id));

            if (cmd.Connection.State == ConnectionState.Closed)
                cmd.Connection.Open();

            var resultado = cmd.ExecuteNonQuery() >= 1;

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            return resultado;
        }

        public bool AlterarPerfil(Usuario usuario)
        {
            return banco.Execute("update usuarios set " +
                "nome=@nome, " +
                "email=@email " +
                "where id=@id",
                usuario) == 1;
        }

        public bool AlterarSenha(Usuario usuario)
        {
            return banco.Execute("update usuarios set " +
                "senha=@senha " +
                "where id=@id",
                usuario) == 1;
        }
    }
}
