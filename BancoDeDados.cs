using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rajadas
{
    class BancoDeDados
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;
        private MySqlCommand comandoMonitoramento;
        private MySqlCommand comandoDiaMonitoramento;
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

        public bool insereRajadaSumarizada(String endereco, String porta, String usuario, String senha, String nomeBD, List<Rajada> listaDeRajadas, String tipoRajada)
        {
            // ** Variável de retorno do método ** //
            bool retornoMetodo = false;

            // ** Pega a data atual e formata para para DD-MM-AAAA
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
            String dataFormatada = dia + "-" + mes + "-" + ano;

            // ** Percorre a lista de rajadas para recuperar os horários das rajadas ** //
            List<string> listaHorarios = new List<string>();

            foreach (Rajada rajada in listaDeRajadas)
            {
                bool retorno = listaHorarios.Any(l => l == rajada.horarioRajada);
                if (retorno.Equals(false))
                {
                    listaHorarios.Add(rajada.horarioRajada);
                }
            }
            // ** Percorre a lista de rajadas para recuperar os horários das rajadas ** //

            // ** Percorre a lista de rajadas para recuperar a quantidade contas processadas por horario da rajada ** //
            foreach (var horario in listaHorarios)
            {
                
                //int contadorTotalContasPorRajada = 0;
                //foreach (var rajada in listaDeRajadas)
                //{
                //    if (rajada.horarioRajada == horario)
                //    {
                //        contadorTotalContasPorRajada = contadorTotalContasPorRajada + 1;
                //    }
                //}

                // ** Retorna apenas as contas do horário específico da rajada ** //
                var rajadasPorHorario = listaDeRajadas.Where(r => r.horarioRajada == horario);

                // ** Retorna a quantidade total de contas processadas por rajada ** //
                int totalDeContasPorRajada = rajadasPorHorario.Count();

                // ** Retorna as contas dos titulares, ou seja, elimina as contas duplicadas, as quais serão de cotitulares ** //.
                var listaContasTitular = rajadasPorHorario
                                               .Select(m => new { m.agencia, m.conta, m.dac })
                                               .Distinct()
                                               .ToList();
                int qtdContasTitular = listaContasTitular.Count();

                //var listaContasTitular =
                //    (from rajada in rajadasPorHorario
                //     select rajada.conta).Distinct();





                // ** Retorna as contas dos cotitulares ** //
                int qtdContasCotitular = totalDeContasPorRajada - qtdContasTitular;

                // ** Retorna a quantidade total de contas de titulares por rajada ** //
                //var itens_duplicados = rajadasPorHorario
                //.GroupBy(r => new { r.conta })
                //.Where(x => x.Count() > 1);

                //foreach (var item in itens_duplicados)
                //{
                //    System.Windows.Forms.MessageBox.Show(item.Key.ToString());
                //}


                //var itens_duplicados = listaDeRajadas
                //.GroupBy(r => new { r.conta })

                //.Where(x => x.Equals(horario))
                //.Sum(x => x.Count());


                // ** String de conexão com o banco ** //
                String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

                // ** String para inserção de registros no banco // **
                String stringComando = "INSERT INTO rajadas_sumarizadas (codigoRajada, dataRajada, horarioRajada, qtdContasTitular, qtdContasCoTitular, qtdTotalContas) VALUES (@CODIGO, @DATA, @HORARIO, @QTDTITULAR, @QTDCOTITULAR, @QTDTOTALCONTAS)";

                try
                {
                    // ** Cria e inicia a conexão com o banco ** //
                    conexao = new MySqlConnection(stringConexao);
                    conexao.Open();

                    // ** Cria o objeto de comando ** //
                    comando = new MySqlCommand(stringComando, conexao);

                    // ** Adiciona os parâmetros ao objeto de comando
                    comando.Parameters.AddWithValue("@CODIGO", tipoRajada);
                    comando.Parameters.AddWithValue("@DATA", dataFormatada);
                    comando.Parameters.AddWithValue("@HORARIO", horario);
                    comando.Parameters.AddWithValue("@QTDTITULAR", qtdContasTitular.ToString());
                    comando.Parameters.AddWithValue("@QTDCOTITULAR", qtdContasCotitular.ToString());
                    comando.Parameters.AddWithValue("@QTDTOTALCONTAS", totalDeContasPorRajada.ToString());

                    // ** Executa o comando de inserção no banco ** //
                    comando.ExecuteNonQuery();

                    retornoMetodo = true;
                }
                catch (Exception e)
                {
                    retornoMetodo = false;
                }
                finally
                {
                    conexao.Close();
                    conexao = null;
                    comando = null;
                }

            }
            return retornoMetodo;
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
                    monitoramento.dataProcessamento = dataReader["dataProcessamento"].ToString();

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

            // ** String para buscar os registros no banco que ainda não foram executados // **
            String stringComando = "SELECT * FROM monitoramento WHERE codigoRajada = " + tipoRajada + " ORDER BY horarioMonitoramento";

            // ** String para buscar os dias da semana em que o monitoramento será executado // **
            String stringComandoDiaMonitoramento = "SELECT * FROM dia_monitoramento WHERE codigoRajada = " + tipoRajada;

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
                    monitoramento.dataProcessamento = dataReader["dataProcessamento"].ToString();

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

        public DiaMonitoramento listarDiasDeMonitoramento(String endereco, String porta, String usuario, String senha, String nomeBD, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para buscar os dias da semana em que o monitoramento será executado // **
            String stringComandoDiaMonitoramento = "SELECT * FROM dia_monitoramento WHERE codigoRajada = " + tipoRajada;

            // ** Cria a lista de parâmetros ** //
            DiaMonitoramento diaMonitoramento = new DiaMonitoramento();
            diaMonitoramento.codigoRajada = tipoRajada;

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComandoDiaMonitoramento, conexao);

                // ** Executa o comando de pesquisa no banco e retorna para um objeto Data Reader ** //
                dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    diaMonitoramento.diaMonitoramento.Add(dataReader["dia"].ToString());
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
            return diaMonitoramento;
        }


        public Boolean atualizaTabelaDeMonitoramento(String endereco, String porta, String usuario, String senha, String nomeBD, List<Monitoramento> listaMonitoramento, DiaMonitoramento diasMonitoramento, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para limpar os registros da tabela MONITORAMENTO ** //
            String stringComandoLimparTabela = "DELETE FROM monitoramento WHERE codigoRajada = " + tipoRajada;

            // ** String para limpar os registros da tabela DIA MONITORAMENTO ** //
            String stringComandoLimparTabelaDiaMonitoramento = "DELETE FROM dia_monitoramento WHERE codigoRajada = " + tipoRajada;

            // ** String para inserção de registros na tabela MONITORAMENTO ** //
            String stringComando = "INSERT INTO monitoramento (codigoRajada, horarioMonitoramento, qtdArquivos, dataProcessamento) VALUES (@CODIGO, @HORARIO, @QTD, @DATAPROCESSAMENTO)";

            // ** String para inserção de registros na tabela DIA MONITORAMENTO ** //
            String stringComandoDiaMonitoramento = "INSERT INTO dia_monitoramento (codigoRajada, dia) VALUES (@CODIGO, @DIA)";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando para limpeza da tabela MONITORAMENTO ** //
                comando = new MySqlCommand(stringComandoLimparTabela, conexao);
                comando.ExecuteNonQuery();
                comando = null;

                // ** Cria o objeto de comando para limpeza da tabela DIA MONITORAMENTO** //
                comandoDiaMonitoramento = new MySqlCommand(stringComandoLimparTabelaDiaMonitoramento, conexao);
                comandoDiaMonitoramento.ExecuteNonQuery();
                comandoDiaMonitoramento = null;

                // ** Adiciona os parâmetros ao objeto de comando
                foreach (Monitoramento monitoramento in listaMonitoramento)
                {
                    // ** Valida se a data de processamento do objeto monitoramento é vazia e o horário do monitoramento é menor que o horário atual, em caso positivo atribui a data atual à propriedade dataProcessamento do objeto monitoramento ** //
                    Agendamento agendamento = new Agendamento();
                    string horarioAtual = agendamento.RetornarHorarioAtualFormatado();
                    bool retorno = agendamento.CompararMaiorHorario(horarioAtual, monitoramento.horarioMonitoramento);
                    if (retorno.Equals(true))
                    {
                        monitoramento.dataProcessamento = agendamento.RetornarDataAtualFormatadaAAAAMMDD();
                    }

                    // ** Cria o objeto de comando MONITORAMENTO ** //
                    comando = new MySqlCommand(stringComando, conexao);

                    // ** Adiciona os parâmetros para a tabela MONITORAMENTO ** //
                    comando.Parameters.AddWithValue("@CODIGO", monitoramento.codigoRajada);
                    comando.Parameters.AddWithValue("@HORARIO", monitoramento.horarioMonitoramento);
                    comando.Parameters.AddWithValue("@QTD", monitoramento.qtdArquivos);
                    comando.Parameters.AddWithValue("@DATAPROCESSAMENTO", monitoramento.dataProcessamento);

                    // ** Executa o comando de inserção no banco ** //
                    comando.ExecuteNonQuery();

                    // ** Limpa o objeto comando ** //
                    comando = null;
                }

                // ** String para limpar os registros da tabela MONITORAMENTO TEMPORÁRIO ** //
                String stringComandoLimparTabelaMonitoramentoTMP = "DELETE FROM monitoramento_tmp WHERE codigoRajada = " + tipoRajada;

                // ** String para inserção de registros na tabela MONITORAMENTO TEMPORÁRIO ** //
                String stringComandoMonitoramentoTMP = "INSERT INTO monitoramento_tmp (codigoRajada, horarioMonitoramento, qtdArquivos, dataProcessamento) VALUES (@CODIGO, @HORARIO, @QTD, @DATAPROCESSAMENTO)";               
                
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando para limpeza da tabela MONITORAMENTO TEMPORÁRIO ** //
                comando = new MySqlCommand(stringComandoLimparTabelaMonitoramentoTMP, conexao);
                comando.ExecuteNonQuery();
                comando = null;

                // ** Adiciona os parâmetros ao objeto de comando
                foreach (Monitoramento monitoramento in listaMonitoramento)
                {
                    // ** Valida se a data de processamento do objeto monitoramento é vazia e o horário do monitoramento é menor que o horário atual, em caso positivo atribui a data atual à propriedade dataProcessamento do objeto monitoramento ** //
                    Agendamento agendamento = new Agendamento();
                    string horarioAtual = agendamento.RetornarHorarioAtualFormatado();
                    bool retorno = agendamento.CompararMaiorHorario(horarioAtual, monitoramento.horarioMonitoramento);
                    if (retorno.Equals(true))
                    {
                        monitoramento.dataProcessamento = agendamento.RetornarDataAtualFormatadaAAAAMMDD();
                    }

                    // ** Cria o objeto de comando MONITORAMENTO TEMPORÁRIO ** //
                    comando = new MySqlCommand(stringComandoMonitoramentoTMP, conexao);

                    // ** Adiciona os parâmetros para a tabela MONITORAMENTO TEMPORÁRIO ** //
                    comando.Parameters.AddWithValue("@CODIGO", monitoramento.codigoRajada);
                    comando.Parameters.AddWithValue("@HORARIO", monitoramento.horarioMonitoramento);
                    comando.Parameters.AddWithValue("@QTD", monitoramento.qtdArquivos);
                    comando.Parameters.AddWithValue("@DATAPROCESSAMENTO", monitoramento.dataProcessamento);

                    // ** Executa o comando de inserção no banco ** //
                    comando.ExecuteNonQuery();

                    // ** Limpa o objeto comando ** //
                    comando = null;
                }

                // ** Adiciona os parâmetros ao objeto de comando
                foreach (var dia in diasMonitoramento.diaMonitoramento)
                {
                    // ** Cria o objeto de comando DIA MONITORAMENTO ** //
                    comandoDiaMonitoramento = new MySqlCommand(stringComandoDiaMonitoramento, conexao);

                    // ** Adiciona os parâmetros para a tabela DIA MONITORAMENTO ** //
                    comandoDiaMonitoramento.Parameters.AddWithValue("@CODIGO", diasMonitoramento.codigoRajada);
                    comandoDiaMonitoramento.Parameters.AddWithValue("@DIA", dia);

                    // ** Executa o comando de inserção no banco ** //
                    comandoDiaMonitoramento.ExecuteNonQuery();

                    // ** Limpa o objeto comando ** //
                    comandoDiaMonitoramento = null;
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
            String stringComando = "UPDATE monitoramento SET dataProcessamento = @DATA WHERE codigoRajada = @CODIGO AND horarioMonitoramento = @HORARIO";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                //// ** Pega a data atual e formata para para AAAA-MM-DD
                //String dia = DateTime.Now.Day.ToString();
                //if (Convert.ToInt32(dia) < 10)
                //{
                //    dia = "0" + dia;
                //}
                //String mes = DateTime.Now.Month.ToString();
                //if (Convert.ToInt32(mes) < 10)
                //{
                //    mes = "0" + mes;
                //}
                //String ano = DateTime.Now.Year.ToString();
                //String dataFormatada = ano + "-" + mes + "-" + dia;

                // ** Retorna a data formatada no padrão AAAA-MM-DD ** //
                Agendamento agendamento = new Agendamento();
                string dataFormatada = agendamento.RetornarDataAtualFormatadaAAAAMMDD();

                // ** Adiciona os parâmetros ao objeto de comando
                comando.Parameters.AddWithValue("@DATA", dataFormatada);
                comando.Parameters.AddWithValue("@CODIGO", tipoRajada);
                comando.Parameters.AddWithValue("@HORARIO", monitoramento.horarioMonitoramento);

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

        // ** Esse método atualizada a data do processamento da rajada de acordo com os registros recuperados da tabela de MONITORAMENTO e MONITORAMENTO TEMPORÁRIO antes da sua atualização ** //
        public Boolean atualizaDataMonitoramentoExecutadoAposAtualizacaoDaTabelaMonitoramento(String endereco, String porta, String usuario, String senha, String nomeBD, Monitoramento monitoramento, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para atualização da data do monitoramento executado // **
            String stringComandoMonitoramento = "UPDATE monitoramento SET dataProcessamento = @DATA WHERE codigoRajada = @CODIGO AND horarioMonitoramento = @HORARIO";

            // ** String para atualização da data do monitoramento executado // **
            String stringComandoMonitoramentoTemporario = "UPDATE monitoramento_tmp SET dataProcessamento = @DATA WHERE codigoRajada = @CODIGO AND horarioMonitoramento = @HORARIO";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComandoMonitoramento, conexao);                

                // ** Adiciona os parâmetros ao objeto de comando
                comando.Parameters.AddWithValue("@DATA", monitoramento.dataProcessamento);
                comando.Parameters.AddWithValue("@CODIGO", tipoRajada);
                comando.Parameters.AddWithValue("@HORARIO", monitoramento.horarioMonitoramento);

                // ** Executa o comando de inserção no banco ** //
                comando.ExecuteNonQuery();

                // ** Limpa objeto de comando ** //
                comando = null;

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComandoMonitoramentoTemporario, conexao);

                // ** Adiciona os parâmetros ao objeto de comando
                comando.Parameters.AddWithValue("@DATA", monitoramento.dataProcessamento);
                comando.Parameters.AddWithValue("@CODIGO", tipoRajada);
                comando.Parameters.AddWithValue("@HORARIO", monitoramento.horarioMonitoramento);

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

        public Boolean AtualizarTabelaDeMonitoramentoAposNotificarPorEmail(String endereco, String porta, String usuario, String senha, String nomeBD, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para limpar os registros da tabela MONITORAMENTO ** //
            String stringComandoLimparTabelaMonitoramento = "DELETE FROM monitoramento WHERE codigoRajada = " + tipoRajada;

            // ** String para inserção de registros na tabela MONITORAMENTO ** //
            String stringInserirMonitoramento = "INSERT INTO monitoramento (codigoRajada, horarioMonitoramento, qtdArquivos, dataProcessamento) VALUES (@CODIGO, @HORARIO, @QTD, @DATAPROCESSAMENTO)";

            // ** String para buscar os registros referentes a tabela de MONITORAMENTO // **
            String stringBuscarMonitoramento = "SELECT * FROM monitoramento WHERE codigoRajada = " + tipoRajada + " ORDER BY horarioMonitoramento";

            // ** Criação do objeto Agendamento ** //
            Agendamento agendamento = new Agendamento();

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando para buscar os registros dos monitoramentos no banco ** //
                comando = new MySqlCommand(stringBuscarMonitoramento, conexao);

                // ** Executa o comando de pesquisa no banco e retorna para um objeto Data Reader ** //
                dataReader = comando.ExecuteReader();

                // ** Cria lista de objetos Monitoramento para armazenar retorno do banco ** //
                List<Monitoramento> listaDeMonitoramento = new List<Monitoramento>();
                while (dataReader.Read())
                {
                    Monitoramento monitoramento = new Monitoramento();

                    monitoramento.codigoRajada = dataReader["codigoRajada"].ToString();
                    monitoramento.horarioMonitoramento = dataReader["horarioMonitoramento"].ToString();
                    monitoramento.qtdArquivos = dataReader["qtdArquivos"].ToString();
                    monitoramento.dataProcessamento = dataReader["dataProcessamento"].ToString();

                    listaDeMonitoramento.Add(monitoramento);
                }

                // ** Limpa o objeto comando ** //
                conexao.Close();
                comando = null;
                conexao.Open();
                                
                // ** Cria o objeto de comando para limpeza da tabela MONITORAMENTO ** //
                comando = new MySqlCommand(stringComandoLimparTabelaMonitoramento, conexao);
                comando.ExecuteNonQuery();
                comando = null;                

                // ** Insere os valores de monitoramento na tabela MONITORAMENTO subtraindo 1 na quantidade arquivos ** //
                foreach (Monitoramento monitoramentoAtualizado in listaDeMonitoramento)
                {
                    // ** Cria o objeto de comando para inserir os registros dos monitoramentos na tabela Monitoramento** //
                    comando = new MySqlCommand(stringInserirMonitoramento, conexao);

                    // ** Adiciona os parâmetros para a tabela MONITORAMENTO ** //
                    comando.Parameters.AddWithValue("@CODIGO", monitoramentoAtualizado.codigoRajada);
                    comando.Parameters.AddWithValue("@HORARIO", monitoramentoAtualizado.horarioMonitoramento);

                    // ** Valida o se o horário da rajada é maior ou igual ao horário atual para subtrair 1 do número de arquivos esperados ** //
                    string horarioAtualFormatado = agendamento.RetornarHorarioAtualFormatado();
                    bool retornoValidacaoHorario = agendamento.CompararMaiorHorario(monitoramentoAtualizado.horarioMonitoramento, horarioAtualFormatado);
                    if (retornoValidacaoHorario.Equals(true))
                    {
                        comando.Parameters.AddWithValue("@QTD", Convert.ToInt32(monitoramentoAtualizado.qtdArquivos) - 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@QTD", monitoramentoAtualizado.qtdArquivos);
                    }
                    
                    comando.Parameters.AddWithValue("@DATAPROCESSAMENTO", monitoramentoAtualizado.dataProcessamento);

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

        public Boolean RestaurarTabelaDeMonitoramentoAtual(String endereco, String porta, String usuario, String senha, String nomeBD, String tipoRajada)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para limpar os registros da tabela MONITORAMENTO ** //
            String stringComandoLimparTabelaMonitoramento = "DELETE FROM monitoramento WHERE codigoRajada = " + tipoRajada;

            // ** String para inserção de registros na tabela MONITORAMENTO ** //
            String stringInserirMonitoramento = "INSERT INTO monitoramento (codigoRajada, horarioMonitoramento, qtdArquivos, dataProcessamento) VALUES (@CODIGO, @HORARIO, @QTD, @DATAPROCESSAMENTO)";

            // ** String para buscar os registros da tabela de MONITORAMENTO TEMPORÁRIO // **
            String stringBuscarMonitoramento = "SELECT * FROM monitoramento_tmp WHERE codigoRajada = " + tipoRajada + " ORDER BY horarioMonitoramento";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando para buscar os registros da tabela de MONITORAMENTO TEMPORÁRIO no banco ** //
                comando = new MySqlCommand(stringBuscarMonitoramento, conexao);

                // ** Executa o comando de pesquisa no banco e retorna os registros da tabela de MONITORAMENTO TEMPORÁRIO para um objeto Data Reader ** //
                dataReader = comando.ExecuteReader();

                // ** Cria lista de objetos Monitoramento para armazenar retorno do banco ** //
                List<Monitoramento> listaDeMonitoramento = new List<Monitoramento>();
                while (dataReader.Read())
                {
                    Monitoramento monitoramento = new Monitoramento();

                    monitoramento.codigoRajada = dataReader["codigoRajada"].ToString();
                    monitoramento.horarioMonitoramento = dataReader["horarioMonitoramento"].ToString();
                    monitoramento.qtdArquivos = dataReader["qtdArquivos"].ToString();
                    monitoramento.dataProcessamento = dataReader["dataProcessamento"].ToString();

                    listaDeMonitoramento.Add(monitoramento);
                }

                // ** Limpa o objeto comando ** //
                conexao.Close();
                comando = null;
                conexao.Open();

                // ** Cria o objeto de comando para limpeza da tabela MONITORAMENTO ** //
                comando = new MySqlCommand(stringComandoLimparTabelaMonitoramento, conexao);
                comando.ExecuteNonQuery();
                comando = null;

                // ** Insere os valores de monitoramento na tabela MONITORAMENTO de acordo com os registros encontrados na tabela MONITORAMENTO TEMPORÁRIO ** //
                foreach (Monitoramento monitoramentoAtualizado in listaDeMonitoramento)
                {
                    // ** Cria o objeto de comando para inserir os registros dos monitoramentos na tabela Monitoramento** //
                    comando = new MySqlCommand(stringInserirMonitoramento, conexao);

                    // ** Adiciona os parâmetros para a tabela MONITORAMENTO ** //
                    comando.Parameters.AddWithValue("@CODIGO", monitoramentoAtualizado.codigoRajada);
                    comando.Parameters.AddWithValue("@HORARIO", monitoramentoAtualizado.horarioMonitoramento);
                    comando.Parameters.AddWithValue("@QTD", Convert.ToInt32(monitoramentoAtualizado.qtdArquivos));
                    comando.Parameters.AddWithValue("@DATAPROCESSAMENTO", monitoramentoAtualizado.dataProcessamento);

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

        // ** Método para inserir o Detalhado do Registro do BD ** //
        public Boolean InserirDetalhadoDoRegistro(String endereco, String porta, String usuario, String senha, String nomeBD, DetalhadoRegistro detalhadoRegistro, String sistema)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para inserção de registros no banco // **
            String stringComando = "INSERT INTO detalhado_registros (protocolo, sistema, workflow, cpf_cnpj, data_cadastro, data_conclusao, status_registro, resultado, " +
                "usuario, nh, contrato_proposta, prioridade, data_analise, tempo_analise, tipo_conclusao, agencia, conta, dac, matricula ) " +
                "VALUES (@PROTOCOLO, @SISTEMA, @WORKFLOW, @CPF_CNPJ, @DATA_CADASTRO, @DATA_CONCLUSAO, @STATUS_REGISTRO, @RESULTADO, @USUARIO, @NH, @CONTRATO_PROPOSTA, " +
                "@PRIORIDADE, @DATA_ANALISE, @TEMPO_ANALISE, @TIPO_CONCLUSAO, @AGENCIA, @CONTA, @DAC, @MATRICULA)";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                // ** Adiciona os parâmetros ao objeto de comando
                comando.Parameters.AddWithValue("@PROTOCOLO", detalhadoRegistro.protocolo);
                comando.Parameters.AddWithValue("@SISTEMA", sistema);
                comando.Parameters.AddWithValue("@WORKFLOW", detalhadoRegistro.workflow);
                comando.Parameters.AddWithValue("@CPF_CNPJ", detalhadoRegistro.cpfCnpj);
                comando.Parameters.AddWithValue("@DATA_CADASTRO", detalhadoRegistro.dataCadastro);
                comando.Parameters.AddWithValue("@DATA_CONCLUSAO", detalhadoRegistro.dataConclusao);
                comando.Parameters.AddWithValue("@STATUS_REGISTRO", detalhadoRegistro.statusRegistro);
                comando.Parameters.AddWithValue("@RESULTADO", detalhadoRegistro.resultado);
                comando.Parameters.AddWithValue("@USUARIO", detalhadoRegistro.usuario);
                comando.Parameters.AddWithValue("@NH", detalhadoRegistro.nh);
                comando.Parameters.AddWithValue("@CONTRATO_PROPOSTA", detalhadoRegistro.contratoProposta);
                comando.Parameters.AddWithValue("@PRIORIDADE", detalhadoRegistro.prioridade);
                comando.Parameters.AddWithValue("@DATA_ANALISE", detalhadoRegistro.dataAnalise);
                comando.Parameters.AddWithValue("@TEMPO_ANALISE", detalhadoRegistro.tempoAnalise);
                comando.Parameters.AddWithValue("@TIPO_CONCLUSAO", detalhadoRegistro.tipoConclusao);
                comando.Parameters.AddWithValue("@AGENCIA", detalhadoRegistro.agencia);
                comando.Parameters.AddWithValue("@CONTA", detalhadoRegistro.conta);
                comando.Parameters.AddWithValue("@DAC", detalhadoRegistro.dac);
                comando.Parameters.AddWithValue("@MATRICULA", detalhadoRegistro.matricula);

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

        // ** Método para atualizar objeto Detalhado do Registro do BD ** //
        public Boolean AtualizarDetalhadoDoRegistro(String endereco, String porta, String usuario, String senha, String nomeBD, DetalhadoRegistro detalhadoRegistro, string sistema)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            String stringComando = "UPDATE detalhado_registros SET data_conclusao = @DATA_CONCLUSAO, status_registro = @STATUS_REGISTRO, " +
                                        "resultado = @RESULTADO, prioridade = @PRIORIDADE, data_analise = @DATA_ANALISE, " +
                                        "tempo_analise = @TEMPO_ANALISE, tipo_conclusao = @TIPO_CONCLUSAO, agencia = @AGENCIA, conta = @CONTA, dac = @DAC WHERE protocolo = " + detalhadoRegistro.protocolo + " AND sistema = '" + sistema + "'";

            try
            {
                // ** Cria e inicia a conexão com o banco ** //
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();

                // ** Cria o objeto de comando ** //
                comando = new MySqlCommand(stringComando, conexao);

                // ** Adiciona os parâmetros ao objeto de comando
               
                comando.Parameters.AddWithValue("@DATA_CONCLUSAO", detalhadoRegistro.dataConclusao);
                comando.Parameters.AddWithValue("@STATUS_REGISTRO", detalhadoRegistro.statusRegistro);
                comando.Parameters.AddWithValue("@RESULTADO", detalhadoRegistro.resultado);
                comando.Parameters.AddWithValue("@PRIORIDADE", detalhadoRegistro.prioridade);
                comando.Parameters.AddWithValue("@DATA_ANALISE", detalhadoRegistro.dataAnalise);
                comando.Parameters.AddWithValue("@TEMPO_ANALISE", detalhadoRegistro.tempoAnalise);
                comando.Parameters.AddWithValue("@TIPO_CONCLUSAO", detalhadoRegistro.tipoConclusao);
                comando.Parameters.AddWithValue("@AGENCIA", detalhadoRegistro.agencia);
                comando.Parameters.AddWithValue("@CONTA", detalhadoRegistro.conta);
                comando.Parameters.AddWithValue("@DAC", detalhadoRegistro.dac);

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

        // ** Método para retornar os registros da tabela detalhado_registros filtrando pelo campo sistema ** //
        public List<DetalhadoRegistro> ListarDetalhadoRegistro(String endereco, String porta, String usuario, String senha, String nomeBD, String sistema)
        {
            // ** String de conexão com o banco ** //
            String stringConexao = "server=" + endereco + ";port=" + porta + ";User Id=" + usuario + ";database=" + nomeBD + ";password=" + senha;

            // ** String para buscar os registros no banco // **
            String stringComando = "SELECT * FROM detalhado_registros WHERE sistema = '" + sistema + "' ORDER BY protocolo";

            // ** Cria a lista de parâmetros ** //
            List<DetalhadoRegistro> listaDetalhadoRegistro = new List<DetalhadoRegistro>();

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
                    DetalhadoRegistro detalhadoRegistro = new DetalhadoRegistro();

                    detalhadoRegistro.protocolo = dataReader["protocolo"].ToString();
                    detalhadoRegistro.sistema = null;
                    detalhadoRegistro.workflow = dataReader["workflow"].ToString();
                    detalhadoRegistro.cpfCnpj = dataReader["cpf_cnpj"].ToString();
                    detalhadoRegistro.dataCadastro = dataReader["data_cadastro"].ToString();
                    detalhadoRegistro.dataConclusao = dataReader["data_conclusao"].ToString();
                    detalhadoRegistro.statusRegistro = dataReader["status_registro"].ToString();
                    detalhadoRegistro.resultado = dataReader["resultado"].ToString();
                    detalhadoRegistro.usuario = dataReader["usuario"].ToString();
                    detalhadoRegistro.nh = dataReader["nh"].ToString();
                    detalhadoRegistro.contratoProposta = dataReader["contrato_proposta"].ToString();
                    detalhadoRegistro.prioridade = dataReader["prioridade"].ToString();
                    detalhadoRegistro.dataAnalise = dataReader["data_analise"].ToString();
                    detalhadoRegistro.tempoAnalise = dataReader["tempo_analise"].ToString();
                    detalhadoRegistro.tipoConclusao = dataReader["tipo_conclusao"].ToString();
                    detalhadoRegistro.agencia = dataReader["agencia"].ToString();
                    detalhadoRegistro.conta = dataReader["conta"].ToString();
                    detalhadoRegistro.dac = dataReader["dac"].ToString();
                    detalhadoRegistro.matricula = dataReader["matricula"].ToString();

                    listaDetalhadoRegistro.Add(detalhadoRegistro);
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
            return listaDetalhadoRegistro;
        }

    }
}
