using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace rajadas
{
    class ParametrosSistema
    {
        private String caminhoRajadas;
        private String caminhoExcel;
        private String caminhoRajadasProcessadas;
        private String parametroCopiarOuMoverArquivoTxt;
        private String intervalo;
        private String frequencia;
        private String statusLeitura;
        List<String> parametrosRajada = new List<String>();

        public List<String> carregarParametrosRajada(String arquivoDeConfiguracaoSistema, String tipoRajada)
        {
            try
            {
                XElement xml = XElement.Load(arquivoDeConfiguracaoSistema);

                IEnumerable<XElement> listaDeParametros = xml.Elements();

                var parametrosXml = from parametros in listaDeParametros
                          where parametros.Attribute("Id").Value == tipoRajada
                          select parametros;

                foreach (var parametro in parametrosXml)
                {
                    caminhoRajadas = parametro.Element("CaminhoRajadas").Value;
                    caminhoExcel = parametro.Element("CaminhoExcel").Value;
                    caminhoRajadasProcessadas = parametro.Element("CaminhoRajadasProcessadas").Value;
                    parametroCopiarOuMoverArquivoTxt = parametro.Element("ConfiguracaoCopiarOuMover").Value;
                    intervalo = parametro.Element("Intervalo").Value;
                    frequencia = parametro.Element("Frequencia").Value;
                    statusLeitura = parametro.Element("StatusLeitura").Value;
                }

                List<String> parametrosLocais = new List<String>();

                parametrosLocais.Add(caminhoRajadas);
                parametrosLocais.Add(caminhoExcel);
                parametrosLocais.Add(caminhoRajadasProcessadas);
                parametrosLocais.Add(parametroCopiarOuMoverArquivoTxt);
                parametrosLocais.Add(intervalo);
                parametrosLocais.Add(frequencia);
                parametrosLocais.Add(statusLeitura);

                this.parametrosRajada = parametrosLocais;
            }

            catch (Exception e)
            {         
                DialogResult result = MessageBox.Show("O Arquivo 'Parametros.xml' não foi localizado na pasta do sistema, o sistema será encerrado !");
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            return this.parametrosRajada;
        }


        public Boolean salvarConfiguracoes(List<String> listaDeParametros, String caminhoArquivoDeConfiguracao, String tipoRajada, int indiceInicial, int indiceFinal)
        {
            try
            {
                XDocument xml = XDocument.Load(caminhoArquivoDeConfiguracao);

                for (int contador = indiceInicial; contador <= indiceFinal; contador++)
                {
           
                        xml.Element("Parametros")
                            .Elements("TipoRajada")
                            .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
                            .SetElementValue("CaminhoRajadas", listaDeParametros[contador]);

                      contador = contador + 1;

                        xml.Element("Parametros")
                            .Elements("TipoRajada")
                            .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
                            .SetElementValue("CaminhoExcel", listaDeParametros[contador]);

                      contador = contador + 1;

                        xml.Element("Parametros")
                            .Elements("TipoRajada")
                            .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
                            .SetElementValue("CaminhoRajadasProcessadas", listaDeParametros[contador]);

                      contador = contador + 1;

                        xml.Element("Parametros")
                            .Elements("TipoRajada")
                            .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
                            .SetElementValue("ConfiguracaoCopiarOuMover", listaDeParametros[contador]);

                      contador = contador  + 1;

                        xml.Element("Parametros")
                            .Elements("TipoRajada")
                            .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
                            .SetElementValue("Intervalo", listaDeParametros[contador]);

                       contador = contador + 1;

                        xml.Element("Parametros")
                            .Elements("TipoRajada")
                            .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
                            .SetElementValue("Frequencia", listaDeParametros[contador]);

                    contador = contador + 1;

                    xml.Element("Parametros")
                            .Elements("TipoRajada")
                            .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
                            .SetElementValue("StatusLeitura", listaDeParametros[contador]);
                }

                xml.Save(caminhoArquivoDeConfiguracao);

            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            return true;

        }

    }
}
