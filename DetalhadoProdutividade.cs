using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rajadas
{
    class DetalhadoProdutividade
    {
        public string cliente { get; set; }
        public string workflow { get; set; }
        public string protocolo { get; set; }
        public string matricula { get; set; }
        public string contrato { get; set; }
        public string dataCadastro { get; set; }
        public string dataAnalise { get; set; }
        public string tempoAnalise { get; set; }
        public string etapa { get; set; }
        public string statusRegistro { get; set; }
        

        // ** Faz a verificação e leitura do arquivo CSV e retorna uma lista do tipo DetalhadoProdutividade ** //
        public List<DetalhadoProdutividade> LerArquivoDetalhadoDeProdutividade(string arquivoCSV)
        {
            List<DetalhadoProdutividade> listaDetalhadoProdutividade = new List<DetalhadoProdutividade>();

            try
            {
                listaDetalhadoProdutividade = File.ReadAllLines(arquivoCSV, Encoding.Default)
                .Select(a => a.Split(';'))
                .Select(c => new DetalhadoProdutividade()
                {
                    cliente = c[0].Replace("\"", ""),
                    workflow = c[1].Replace("\"", ""),
                    protocolo = c[2].Replace("\"", ""),
                    matricula = c[3].Replace("\"", ""),
                    contrato = c[4].Replace("\"", ""),
                    dataCadastro = c[5].Replace("\"", ""),
                    dataAnalise = c[6].Replace("\"", ""),
                    tempoAnalise = c[7].Replace("\"", ""),
                    etapa = c[8].Replace("\"", ""),
                    statusRegistro = c[9].Replace("\"", "")
                })
                .ToList();
                
                if (listaDetalhadoProdutividade.Count() > 0)
                {
                    // ** Remove o cabeçalho do arquivo CSV ** //
                    listaDetalhadoProdutividade.RemoveAt(0);
                    return listaDetalhadoProdutividade;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            { }
        }

        // ** Faz a verificação da pasta apontada e retorna uma lista com todos arquivos CSV encontrados ** //
        public List<string> LocalizarArquivosCSV(string diretorioCSV)
        {
            // ** Variável que irá receber os arquivos localizados no diretório informado através do parâmetro caminhoCSV **//
            var listaDeArquivosNoDiretorio = new List<String>();

            try
            {
                // ** Localiza todos arquivos no diretório apontado **//
                listaDeArquivosNoDiretorio = Directory.GetFiles(diretorioCSV).ToList();

                // ** Retorna a lista contendo os arquivos CSV encontrados **//
                return listaDeArquivosNoDiretorio;
            }
            catch (Exception)
            {
                return null;
            }
        }

        // ** Compara duas listas e retorna uma lista com os objetos novos, ou seja, que não estão no banco de dados ** //
        public List<DetalhadoProdutividade> CompararListasDetalhadoProdutividadeObjetosNovos(List<DetalhadoProdutividade> listaInserir, List<DetalhadoProdutividade> listaBD)
        {
            List<DetalhadoProdutividade> listaDetalhadoProdutividade = new List<DetalhadoProdutividade>();

            try
            {
                foreach (var detalhadoProdutividadeListaInserir in listaInserir)
                {
                    if (listaBD.Any(l => l.protocolo == detalhadoProdutividadeListaInserir.protocolo) && listaBD.Any(l => l.etapa == detalhadoProdutividadeListaInserir.etapa))
                    { }
                    else
                    {
                        listaDetalhadoProdutividade.Add(detalhadoProdutividadeListaInserir);
                    }
                }

                if (listaDetalhadoProdutividade.Count() > 0)
                {
                    return listaDetalhadoProdutividade;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            { }
        }

        // ** Compara duas listas e retorna uma lista com os objetos que já estão no banco de dados e precisam ser atualizados ** //
        public List<DetalhadoProdutividade> CompararListasDetalhadoProdutividadeObjetosCadastrados(List<DetalhadoProdutividade> listaAtualizar, List<DetalhadoProdutividade> listaBD)
        {
            List<DetalhadoProdutividade> listaDetalhadoProdutividade = new List<DetalhadoProdutividade>();

            try
            {
                foreach (var detalhadoProdutividadeListaAtualizar in listaAtualizar)
                {
                    // ** Valida se o objeto da lista já está na lista que veio do banco de dados ** //
                    if (listaBD.Any(l => l.protocolo == detalhadoProdutividadeListaAtualizar.protocolo) && listaBD.Any(l => l.etapa == detalhadoProdutividadeListaAtualizar.etapa))
                    {
                        listaDetalhadoProdutividade.Add(detalhadoProdutividadeListaAtualizar);
                    }
                }

                if (listaDetalhadoProdutividade.Count() > 0)
                {
                    return listaDetalhadoProdutividade;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            { }
        }

        // ** Mover arquivo processado para outro diretório ** //
        public bool MoverArquivoProcessado(string arquivoProcessado, string diretorioArquivoProcessado)
        {
            bool retorno = false;
            try
            {
                // ** Recupera o nome do arquivo ** //
                FileInfo informacaoDoArquivo = new FileInfo(arquivoProcessado);
                string destinoArquivoProcessado = diretorioArquivoProcessado + @"\" + informacaoDoArquivo.Name;

                // ----------- ** Move o arquivo para o diretório de arquivos processados ** -----------//
                File.Move(arquivoProcessado, destinoArquivoProcessado);
                retorno = true;
            }
            catch (Exception e)
            {
                // ** Se o erro for que o arquivo já existe no diretório de destino o sistema exclui o arquivo no diretório de origem ** //
                string erro = e.Message;
                if (erro.Equals("Não é possível criar um arquivo já existente.\r\n"))
                {
                    File.Delete(arquivoProcessado);
                }
            }

            return retorno;
        }

        
    }
}
