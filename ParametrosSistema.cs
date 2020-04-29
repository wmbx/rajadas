using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<String> carregarParametrosRajada(String arquivoDeConfiguracaoSistema, String tipoRajada)
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
            }

            List<String> parametrosRajadaTijolo = new List<String>();

            parametrosRajadaTijolo.Add(caminhoRajadas);
            parametrosRajadaTijolo.Add(caminhoExcel);
            parametrosRajadaTijolo.Add(caminhoRajadasProcessadas);
            parametrosRajadaTijolo.Add(parametroCopiarOuMoverArquivoTxt);
            parametrosRajadaTijolo.Add(intervalo);
            parametrosRajadaTijolo.Add(frequencia);

            return parametrosRajadaTijolo;
        }


        public Boolean salvarConfiguracoes(List<String> listaDeParametros, String caminhoArquivoDeConfiguracao, String tipoRajada, int indiceInicial, int indiceFinal)
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
            }

            xml.Save(caminhoArquivoDeConfiguracao);

            return true;

        }

    }
}
