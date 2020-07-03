using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rajadas
{
    class Expurgo
    {
        // ** Excluir arquivos CSV criados ou modificados antes da data atual ** //
        public Boolean ExcluirArquivosCSVAntigos(String caminhoArquivosProcessados)
        {
            var listaDeArquivosCSV = new List<String>();

            var listaDeDiretorios = new List<String>();

            var listaDeArquivosEmCadaDiretorio = new List<String>();

            try
            {
                listaDeDiretorios = Directory.GetDirectories(caminhoArquivosProcessados).ToList();
                listaDeDiretorios.Add(caminhoArquivosProcessados);

                String ano = DateTime.Now.Year.ToString();
                String mes = DateTime.Now.Month.ToString();
                // ** Acrescenta 0 ao mês ** //
                if (Convert.ToInt32(mes) < 10)
                {
                    mes = "0" + mes;
                }

                String dia = DateTime.Now.Day.ToString();

                // ** Acrescenta 0 ao dia ** //
                if (Convert.ToInt32(dia) < 10)
                {
                    dia = "0" + dia;
                }

                String dataAtual = dia + "/" + mes + "/" + ano;

                foreach (var diretorio in listaDeDiretorios)
                {
                    listaDeArquivosEmCadaDiretorio = Directory.GetFiles(diretorio).ToList();
                    foreach (var arquivoEncontrado in listaDeArquivosEmCadaDiretorio)
                    {
                        listaDeArquivosCSV.Add(arquivoEncontrado);
                    }
                }

                foreach (var arquivoCSV in listaDeArquivosCSV)
                {
                    FileInfo informacaoDoArquivo = new FileInfo(arquivoCSV);
                    String nomeArquivoRajadaTxt = informacaoDoArquivo.Name;
                    string dataArquivo = informacaoDoArquivo.CreationTime.ToString();
                    

                    // ** Valida se o nome do diretório é maior que 10 antes de fazer o substring ** //
                    if (dataArquivo.Length > 10)
                    {
                        string dataArquivoAjustada = dataArquivo.Substring(0, 10);

                        if (dataArquivoAjustada != dataAtual)
                        {
                            // -- ** Exclui o arquivo do diretório de origem caso o sistema esteja parametrizado para isso -- ** //
                            File.Delete(arquivoCSV);
                            // -- ** Exclui o arquivo do diretório de origem caso o sistema esteja parametrizado para isso -- ** //

                        }
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
