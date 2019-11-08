using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControleFrotas
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //Classe que faz a conexão com o SQL Server e instanciando a mesma

        public Conexao()
        //Método construtor com o mesmo nome da classe para fazer a conexão com o servidor
        {
            con.ConnectionString = @"Data Source=OMAEL-PC\SQLEXPRESS;Initial Catalog=SistLogin;Integrated Security=True";
        }

        public SqlConnection conectar()
        //Método para conectar ao banco de dados caso não esteja conectado
        {
            if (con.State == System.Data.ConnectionState.Closed)
                //Se o estado do BD estiver fechado, ele será aberto e retornará ao final o estado aberto
            {
                con.Open();
            }

            return con;
        }

        public void desconectar()
        //Método para desconectar ao banco de dados caso esteja conectado
        {
            if (con.State == System.Data.ConnectionState.Open)
                //Se o estado do BD estiver aberto, o mesmo será fechado
            {
                con.Close();
            }
        }
    }
}
