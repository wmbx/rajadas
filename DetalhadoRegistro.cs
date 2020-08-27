using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rajadas
{
    class DetalhadoRegistro
    {
        public string protocolo {get; set;}
        public string sistema { get; set; }
        public string workflow { get; set; }
        public string cpfCnpj { get; set; }
        public string dataCadastro { get; set; }
        public string dataConclusao { get; set; }
        public string statusRegistro { get; set; }
        public string resultado { get; set; }
        public string usuario { get; set; }
        public string nh { get; set; }
        public string contratoProposta { get; set; }
        public string prioridade { get; set; }
        public string dataAnalise { get; set; }
        public string tempoAnalise { get; set; }
        public string tipoConclusao { get; set; }
        public string agencia { get; set; }
        public string conta { get; set; }
        public string dac { get; set; }
        public string matricula { get; set; }


        // ** Faz a verificação e leitura do arquivo CSV e retorna uma lista do tipo DetalhadoRegistro ** //
        public List<DetalhadoRegistro> LerArquivoDetalhadoDeRegistro(string arquivoCSV)
        {
            // ** Lista que será retornada com os registros do arquivo CSV
            List<DetalhadoRegistro> listaDetalhadoRegistro = new List<DetalhadoRegistro>();

            // ** Lista temporária utilizada para remoção do cabeçalho do arquivo CSV
            


            try
            {
                // ** Valida se o arquivo CSV é do FDI ou do BrFlow, primeiro trata como FDI e se der erro de índice vai para o catch que tratará com BrFlow ** //
                try
                {                    
                    listaDetalhadoRegistro = File.ReadAllLines(arquivoCSV, Encoding.Default)
                    .Select(a => a.Split(';'))
                    .Skip(1)
                    .Select(c => new DetalhadoRegistro()
                    {
                        protocolo = c[0].Replace("\"", ""),
                        sistema = "FDI",
                        workflow = c[1].Replace("\"", ""),
                        cpfCnpj = c[2].Replace("\"", ""),
                        dataCadastro = c[3].Replace("\"", ""),
                        dataConclusao = c[4].Replace("\"", ""),
                        statusRegistro = c[5].Replace("\"", ""),
                        resultado = c[6].Replace("\"", ""),
                        usuario = c[7].Replace("\"", ""),
                        nh = c[8].Replace("\"", ""),
                        contratoProposta = c[9].Replace("\"", ""),
                        prioridade = c[10].Replace("\"", ""),
                        dataAnalise = c[11].Replace("\"", ""),
                        tempoAnalise = c[12].Replace("\"", ""),
                        tipoConclusao = c[13].Replace("\"", ""),
                        agencia = c[14].Replace("\"", ""),
                        conta = c[15].Replace("\"", ""),
                        dac = c[16].Replace("\"", ""),
                        matricula = c[17].Replace("\"", "")
                    })
                    .ToList();
                }
                catch (Exception erro)
                {
                    if (erro.Message.Equals("O índice estava fora dos limites da matriz."))
                    {
                        listaDetalhadoRegistro = File.ReadAllLines(arquivoCSV, Encoding.Default)
                        .Select(a => a.Split(';'))
                        .Skip(1)
                        .Select(c => new DetalhadoRegistro()
                        {
                            protocolo = c[0].Replace("\"", ""),
                            sistema = "BrFlow",
                            workflow = c[1].Replace("\"", ""),
                            cpfCnpj = c[2].Replace("\"", ""),
                            dataCadastro = c[3].Replace("\"", ""),
                            dataConclusao = c[4].Replace("\"", ""),
                            statusRegistro = c[5].Replace("\"", ""),
                            resultado = c[6].Replace("\"", ""),
                            usuario = c[7].Replace("\"", ""),
                            nh = c[8].Replace("\"", ""),
                            contratoProposta = c[9].Replace("\"", ""),
                            prioridade = c[10].Replace("\"", ""),
                            dataAnalise = c[11].Replace("\"", ""),
                            tempoAnalise = c[12].Replace("\"", ""),
                            agencia = c[13].Replace("\"", ""),
                            conta = c[14].Replace("\"", ""),
                            matricula = c[15].Replace("\"", "")
                        })                        
                        .ToList();
                    }                    
                }                
        
                if (listaDetalhadoRegistro.Count() > 0)
                {
                    List<DetalhadoRegistro> listaDetalhadoRegistroOrdenada = listaDetalhadoRegistro.OrderBy(o => o.dataCadastro).ToList();
                    return listaDetalhadoRegistroOrdenada;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            { }
        }

        // ** Faz a verificação da pasta apontada e retorna uma lista com todos arquivos CSV encontrados ** //
        public List<string> LocalizarArquivosCSV(string diretorioCSV)
        {
            List<string> listaDetalhadoRegistro = new List<string>();

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
        public List<DetalhadoRegistro> CompararListasDetalhadoRegistroObjetosNovos(List<DetalhadoRegistro> listaInserir, List<DetalhadoRegistro> listaBD)
        {
            List<DetalhadoRegistro> listaDetalhadoRegistro = new List<DetalhadoRegistro>();

            try
            {
                foreach (var detalhadoRegistroListaInserir in listaInserir)
                {
                        if (listaBD.Any(l => l.protocolo == detalhadoRegistroListaInserir.protocolo))
                        {}
                        else
                        {
                            listaDetalhadoRegistro.Add(detalhadoRegistroListaInserir);
                        }
                }

                if (listaDetalhadoRegistro.Count() > 0)
                {
                    return listaDetalhadoRegistro;
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
        public List<DetalhadoRegistro> CompararListasDetalhadoRegistroObjetosCadastrados(List<DetalhadoRegistro> listaAtualizar, List<DetalhadoRegistro> listaBD)
        {
            List<DetalhadoRegistro> listaDetalhadoRegistro = new List<DetalhadoRegistro>();

            try
            {
                foreach (var detalhadoRegistroListaAtualizar in listaAtualizar)
                {
                    // ** Valida se o objeto da lista já está na lista que veio do banco de dados ** //
                    if (listaBD.Any(l => l.protocolo == detalhadoRegistroListaAtualizar.protocolo))
                    {
                        //// ** Valida se o status do objeto que veio da lista do banco de dados é diferente de Concluído e Cancelado ** //
                        //if (detalhadoRegistroListaAtualizar.statusRegistro != "Concluído" && detalhadoRegistroListaAtualizar.statusRegistro != "Cancelado")
                        //{
                            listaDetalhadoRegistro.Add(detalhadoRegistroListaAtualizar);
                        //}
                        
                    }
                }

                if (listaDetalhadoRegistro.Count() > 0)
                {
                    return listaDetalhadoRegistro;
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
