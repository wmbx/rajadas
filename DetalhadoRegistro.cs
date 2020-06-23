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
        public List<DetalhadoRegistro> LerArquivoDetalhadoDeRegistro(string caminhoArquivoExcel)
        {
            List<DetalhadoRegistro> listaDetalhadoRegistro = new List<DetalhadoRegistro>();
            
            try
            {
                listaDetalhadoRegistro = File.ReadAllLines(caminhoArquivoExcel)
                    .Select(a => a.Split(';'))
                    .Select(c => new DetalhadoRegistro()
                    {
                        protocolo = c[0],
                        workflow = c[1],
                        cpfCnpj = c[2],
                        dataCadastro = c[3],
                        dataConclusao = c[4],
                        statusRegistro = c[5],
                        resultado = c[6],
                        usuario = c[7],
                        nh = c[8],
                        contratoProposta= c[9],
                        prioridade = c[10],
                        dataAnalise = c[11],
                        tempoAnalise = c[12],
                        tipoConclusao = c[13],
                        agencia = c[14],
                        conta = c[15],
                        dac = c[16],
                        matricula = c[17]
                    })
                    .ToList();

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
                throw;
            }
            finally
            {            }
        }

    }
}
