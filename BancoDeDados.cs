using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rajadas
{
    class BancoDeDados
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;

        public Boolean insereRajadaNoBD(String endereco, String porta, String usuario, String senha, String nomeBD, Rajada rajada, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;
            
            // ** String para inserção de registros no banco // **
            String stringComando = "INSERT INTO rajada (codigoRajada, nomeTitular, cpfTitular, contaTitular, dacTitular, dataLibDoc, horaLibDoc) VALUES (@CODIGO, @NOME, @CPF, @CONTA, @DAC, @DATA, @HORA)";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                // ** Adiciona os parâmetros ao objeto de comando
                comando.Parameters.AddWithValue("@CODIGO", tipoRajada);
                comando.Parameters.AddWithValue("@NOME", rajada.nomeTitular);
                comando.Parameters.AddWithValue("@CPF", rajada.cpfTitular);
                comando.Parameters.AddWithValue("@CONTA", rajada.conta);
                comando.Parameters.AddWithValue("@DAC", rajada.dac);
                comando.Parameters.AddWithValue("@DATA", rajada.dataLiberacaoDocumento);
                comando.Parameters.AddWithValue("@HORA", rajada.horaLiberacaoDocumento);

                // ** Executa o comando de inserção no banco ** //
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        public Boolean insereParametrosDoSistemaNoBD(String endereco, String porta, String usuario, String senha, String nomeBD, List<String> listaDeParametros, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para inserção de registros no banco // **
            String stringComando = "INSERT INTO parametros_sistema (codigoRajada, origemRajada, destinoRajada, copiarMover, intervaloLeitura, frequenciaLeitura, statusLeitura, statusMonitoramento, destinatariosMonitoramento) VALUES (@CODIGORAJADA, @ORIGEMRAJADA, @DESTINORAJADA, @COPIARMOVER, @INTERVALOLEITURA, @FREQUENCIALEITURA, @STATUSLEITURA, @STATUSMONITORAMENTO, @DESTINATARIOS)";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                // ** Adiciona os parâmetros ao objeto de comando
                comando.Parameters.AddWithValue("@CODIGORAJADA", tipoRajada);
                comando.Parameters.AddWithValue("@ORIGEMRAJADA", listaDeParametros[0]);
                comando.Parameters.AddWithValue("@DESTINORAJADA", listaDeParametros[1]);
                comando.Parameters.AddWithValue("@COPIARMOVER", listaDeParametros[2]);
                comando.Parameters.AddWithValue("@INTERVALOLEITURA", listaDeParametros[3]);
                comando.Parameters.AddWithValue("@FREQUENCIALEITURA", listaDeParametros[4]);
                comando.Parameters.AddWithValue("@STATUSLEITURA", listaDeParametros[5]);
                comando.Parameters.AddWithValue("@STATUSMONITORAMENTO", listaDeParametros[6]);
                comando.Parameters.AddWithValue("@DESTINATARIOS", listaDeParametros[7]);

                // ** Executa o comando de inserção no banco ** //
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                return false;
                throw;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
