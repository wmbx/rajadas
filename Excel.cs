using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace rajadas
{
    class Excel
    {        
        public Boolean inserirObjetoNaPlanilhaExcel(List<Rajada> listaDeObjetosRajadas, String caminhoArquivoExcel)
        {
            var arquivoExcel = new XLWorkbook(caminhoArquivoExcel);
            var planilhaExcel = arquivoExcel.Worksheet(1);

            int contadorDeLinhas = planilhaExcel.RowsUsed().Count() + 1;

            foreach (var objetoRajada in listaDeObjetosRajadas)
            {
                planilhaExcel.Cell("A" + contadorDeLinhas).SetValue(objetoRajada.nomeTitular);
                planilhaExcel.Cell("B" + contadorDeLinhas).SetValue(objetoRajada.cpfTitular);
                planilhaExcel.Cell("C" + contadorDeLinhas).SetValue(objetoRajada.conta);
                planilhaExcel.Cell("D" + contadorDeLinhas).SetValue(objetoRajada.dataLiberacaoDocumento);
                planilhaExcel.Cell("E" + contadorDeLinhas).SetValue(objetoRajada.horaLiberacaoDocumento);

                contadorDeLinhas++;
            }

            arquivoExcel.Save();
            arquivoExcel.Dispose();

            return true;
        }

    }
}
