using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.Windows.Forms;

namespace rajadas
{
    class Excel
    {        
        public Boolean inserirObjetoNaPlanilhaExcel(Rajada objetoRajada, String caminhoArquivoExcel)
        {
            try
            {
                var arquivoExcel = new XLWorkbook(caminhoArquivoExcel);
                var planilhaExcel = arquivoExcel.Worksheet(1);

                int contadorDeLinhas = planilhaExcel.RowsUsed().Count() + 1;

                planilhaExcel.Cell("A" + contadorDeLinhas).SetValue(objetoRajada.nomeTitular);
                planilhaExcel.Cell("B" + contadorDeLinhas).SetValue(objetoRajada.cpfTitular);
                planilhaExcel.Cell("C" + contadorDeLinhas).SetValue(objetoRajada.conta);
                planilhaExcel.Cell("D" + contadorDeLinhas).SetValue(objetoRajada.dataLiberacaoDocumento);
                planilhaExcel.Cell("E" + contadorDeLinhas).SetValue(objetoRajada.horaLiberacaoDocumento);

                arquivoExcel.Save();
                arquivoExcel.Dispose();
            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
            return true;
        }

        public Boolean validarSePlanilhaAberta(String caminhoArquivoExcel)
        {
            Boolean retorno;
            try
            {
                var arquivoExcel = new XLWorkbook(caminhoArquivoExcel);
                retorno = true;
            }

            catch (Exception e)
            {
                retorno = false;
            }
            return retorno;
        }

        //// ** Faz a verificação e leitura do arquivo CSV e retorna uma lista do tipo DetalhadoRegistro ** //
        //public List<DetalhadoRegistro> LerArquivoDetalhadoDeRegistro(String caminhoArquivoExcel)
        //{
        //    List<DetalhadoRegistro> listaDetalhadoRegistro = new List<DetalhadoRegistro>();
        //    try
        //    {
                
        //    }
        //    catch (Exception)
        //    {
                
        //        throw;
        //    }

        //    return listaDetalhadoRegistro;
        //}
    }
}
