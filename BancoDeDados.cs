using DocumentFormat.OpenXml.Drawing.Charts;
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
        private MySqlDataReader dataReader;

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

        public Boolean atualizaParametrosDoSistemaNoBD(String endereco, String porta, String usuario, String senha, String nomeBD, List<String> listaDeParametros, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para inserção de registros no banco // **
            //String stringComando = "INSERT INTO parametros_sistema (codigoRajada, origemRajada, destinoRajada, copiarMover, intervaloLeitura, frequenciaLeitura, statusLeitura, statusMonitoramento, destinatariosMonitoramento) VALUES (@CODIGORAJADA, @ORIGEMRAJADA, @DESTINORAJADA, @COPIARMOVER, @INTERVALOLEITURA, @FREQUENCIALEITURA, @STATUSLEITURA, @STATUSMONITORAMENTO, @DESTINATARIOS)";

            String stringComando = "UPDATE parametros_sistema SET origemRajada = @ORIGEMRAJADA, destinoRajada = @DESTINORAJADA, " +
                                        "copiarMover = @COPIARMOVER, intervaloLeitura = @INTERVALOLEITURA, frequenciaLeitura = @FREQUENCIALEITURA, " +
                                        "statusLeitura = @STATUSLEITURA, statusMonitoramento = @STATUSMONITORAMENTO, destinatariosMonitoramento = @DESTINATARIOS WHERE codigoRajada = " + tipoRajada;
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

        public List<string> carregarParametrosDoSistema(String endereco, String porta, String usuario, String senha, String nomeBD, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para busar os registros no banco // **
            String stringComando = "SELECT * FROM parametros_sistema WHERE codigoRajada = " + tipoRajada;

            // ** Cria a lista de parâmetros ** //
            List<string> listaDeParametros = new List<string>();

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();
                
                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                // ** Executa o comando de pesquisa no banco e retorna para um objeto Data Reader ** //
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    listaDeParametros.Add(dataReader["codigoRajada"].ToString());
                    listaDeParametros.Add(dataReader["origemRajada"].ToString());
                    listaDeParametros.Add(dataReader["destinoRajada"].ToString());
                    listaDeParametros.Add(dataReader["copiarMover"].ToString());
                    listaDeParametros.Add(dataReader["intervaloLeitura"].ToString());
                    listaDeParametros.Add(dataReader["frequenciaLeitura"].ToString());
                    listaDeParametros.Add(dataReader["statusLeitura"].ToString());
                    listaDeParametros.Add(dataReader["statusMonitoramento"].ToString());
                    listaDeParametros.Add(dataReader["destinatariosMonitoramento"].ToString());
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                throw;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            return listaDeParametros;
        }

        public List<Monitoramento> listaMonitoramento(String endereco, String porta, String usuario, String senha, String nomeBD, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para busar os registros no banco que ainda não foram executados // **
            String stringComando = "SELECT * FROM monitoramento WHERE codigoRajada = " + tipoRajada + " AND (dataProcessamento = 'vazio' OR dataProcessamento != CURDATE()) ORDER BY horarioMonitoramento";

            // ** Cria a lista de parâmetros ** //
            List<Monitoramento> listaDeMonitoramento = new List<Monitoramento>();

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                // ** Executa o comando de pesquisa no banco e retorna para um objeto Data Reader ** //
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    Monitoramento monitoramento = new Monitoramento();

                    monitoramento.codigoRajada = dataReader["codigoRajada"].ToString();
                    monitoramento.horarioMonitoramento = dataReader["horarioMonitoramento"].ToString();
                    monitoramento.qtdArquivos = dataReader["qtdArquivos"].ToString();

                    listaDeMonitoramento.Add(monitoramento);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                throw;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            return listaDeMonitoramento;
        }

        public List<Monitoramento> listaTodosMonitoramentos(String endereco, String porta, String usuario, String senha, String nomeBD, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para busar os registros no banco que ainda não foram executados // **
            String stringComando = "SELECT * FROM monitoramento WHERE codigoRajada = " + tipoRajada + " ORDER BY horarioMonitoramento";

            // ** Cria a lista de parâmetros ** //
            List<Monitoramento> listaDeMonitoramento = new List<Monitoramento>();

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                // ** Executa o comando de pesquisa no banco e retorna para um objeto Data Reader ** //
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    Monitoramento monitoramento = new Monitoramento();

                    monitoramento.codigoRajada = dataReader["codigoRajada"].ToString();
                    monitoramento.horarioMonitoramento = dataReader["horarioMonitoramento"].ToString();
                    monitoramento.qtdArquivos = dataReader["qtdArquivos"].ToString();

                    listaDeMonitoramento.Add(monitoramento);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                throw;
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
            return listaDeMonitoramento;
        }


        public Boolean atualizaTabelaDeMonitoramento(String endereco, String porta, String usuario, String senha, String nomeBD, List<Monitoramento> listaMonitoramento, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para limpar os registros da tabela MONITORAMENTO ** //
            String stringComandoLimparTabela = "DELETE FROM monitoramento WHERE codigoRajada = " + tipoRajada;

            // ** String para inserção de registros no banco ** //
            String stringComando = "INSERT INTO monitoramento (codigoRajada, horarioMonitoramento, qtdArquivos, dataProcessamento) VALUES (@CODIGO, @HORARIO, @QTD, @DATAPROCESSAMENTO)";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando para limpeza** //
                comando = new MySqlCommand(stringComandoLimparTabela, conexao);
                comando.ExecuteNonQuery();
                comando = null;

                // ** Adiciona os parâmetros ao objeto de comando
                foreach (Monitoramento monitoramento in listaMonitoramento)
                {
                    // ** Cria o objeto de comando ** //
                    comando = new MySqlCommand(stringComando, conexao);

                    comando.Parameters.AddWithValue("@CODIGO", monitoramento.codigoRajada);
                    comando.Parameters.AddWithValue("@HORARIO", monitoramento.horarioMonitoramento);
                    comando.Parameters.AddWithValue("@QTD", monitoramento.qtdArquivos);
                    comando.Parameters.AddWithValue("@DATAPROCESSAMENTO", "vazio");

                    // ** Executa o comando de inserção no banco ** //
                    comando.ExecuteNonQuery();

                    // ** Limpa o objeto comando ** //
                    comando = null;
                }

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

        public Boolean atualizaDataMonitoramentoExecutado(String endereco, String porta, String usuario, String senha, String nomeBD, Monitoramento monitoramento, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para atualização da data do monitoramento executado // **
           String stringComando = "UPDATE monitoramento SET dataProcessamento = @DATA WHERE codigoRajada = " + tipoRajada + " AND horarioMonitoramento = '" + monitoramento.horarioMonitoramento + "'";
            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                // ** Pega a data atual e formata para para AAAA-MM-DD
                String dia = DateTime.Now.Day.ToString();
                if (Convert.ToInt32(dia) < 10)
                {
                    dia = "0" + dia;
                }
                String mes = DateTime.Now.Month.ToString();
                if (Convert.ToInt32(mes) < 10)
                {
                    mes = "0" + mes;
                }
                String ano = DateTime.Now.Year.ToString();
                String dataFormatada = ano + "-" + mes + "-" + dia;

                // ** Adiciona os parâmetros ao objeto de comando
                comando.Parameters.AddWithValue("@DATA", dataFormatada);

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
