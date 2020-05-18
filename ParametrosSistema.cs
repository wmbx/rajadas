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
        //private String caminhoRajadas;
        //private String caminhoRajadasProcessadas;
        //private String parametroCopiarOuMoverArquivoTxt;
        //private String intervaloLeitura;
        //private String frequenciaLeitura;
        //private String statusLeitura;
        //private String intervaloMonitoramento;
        //private String frequenciaMonitoramento;
        //private String statusMonitoramento;
        //private String destinatariosMonitoramento;

        private String enderecoBD;
        private String portaBD;
        private String usuarioBD;
        private String senhaBD;
        private String nomeBD;
        
        List<String> parametrosBD = new List<String>();

        //public List<String> carregarParametrosRajada(String arquivoDeConfiguracaoSistema, String tipoRajada)
        //{
        //    try
        //    {
        //        XElement xml = XElement.Load(arquivoDeConfiguracaoSistema);

        //        IEnumerable<XElement> listaDeParametros = xml.Elements();

        //        var parametrosXml = from parametros in listaDeParametros
        //                  where parametros.Attribute("Id").Value == tipoRajada
        //                  select parametros;

        //        foreach (var parametro in parametrosXml)
        //        {
        //            caminhoRajadas = parametro.Element("CaminhoRajadas").Value;
        //            caminhoRajadasProcessadas = parametro.Element("CaminhoRajadasProcessadas").Value;
        //            parametroCopiarOuMoverArquivoTxt = parametro.Element("ConfiguracaoCopiarOuMover").Value;
        //            intervaloLeitura = parametro.Element("Intervalo").Value;
        //            frequenciaLeitura = parametro.Element("Frequencia").Value;
        //            statusLeitura = parametro.Element("StatusLeitura").Value;
        //            statusMonitoramento = parametro.Element("StatusMonitoramento").Value;
        //            intervaloMonitoramento = parametro.Element("IntervaloMonitoramento").Value;
        //            frequenciaMonitoramento = parametro.Element("FrequenciaMonitoramento").Value;
        //            destinatariosMonitoramento = parametro.Element("DestinatariosMonitoramento").Value;
        //        }

        //        List<String> parametrosLocais = new List<String>();

        //        parametrosLocais.Add(caminhoRajadas);
        //        parametrosLocais.Add(caminhoRajadasProcessadas);
        //        parametrosLocais.Add(parametroCopiarOuMoverArquivoTxt);
        //        parametrosLocais.Add(intervaloLeitura);
        //        parametrosLocais.Add(frequenciaLeitura);
        //        parametrosLocais.Add(statusLeitura);
        //        parametrosLocais.Add(statusMonitoramento);
        //        parametrosLocais.Add(intervaloMonitoramento);
        //        parametrosLocais.Add(frequenciaMonitoramento);
        //        parametrosLocais.Add(destinatariosMonitoramento);

        //        this.parametrosRajada = parametrosLocais;
        //    }

        //    catch (Exception e)
        //    {         
        //        DialogResult result = MessageBox.Show("O Arquivo 'Parametros.xml' não foi localizado na pasta do sistema, o sistema será encerrado !");
        //        if (result == DialogResult.OK)
        //        {
        //            Application.Exit();
        //        }
        //    }

        //    return this.parametrosRajada;
        //}

        public List<String> carregarParametrosBD(String arquivoDeConfiguracaoSistema)
        {
            try
            {
                XElement xml = XElement.Load(arquivoDeConfiguracaoSistema);

                IEnumerable<XElement> listaDeParametros = xml.Elements();

                var parametrosXml = from parametros in listaDeParametros
                                    where parametros.Attribute("Id").Value == "BD"
                                    select parametros;

                foreach (var parametro in parametrosXml)
                {
                    enderecoBD = parametro.Element("Endereco").Value;
                    portaBD = parametro.Element("Porta").Value;
                    usuarioBD = parametro.Element("Usuario").Value;
                    senhaBD = parametro.Element("Senha").Value;
                    nomeBD = parametro.Element("NomeBD").Value;
                }

                List<String> parametrosLocais = new List<String>();

                parametrosLocais.Add(enderecoBD);
                parametrosLocais.Add(portaBD);
                parametrosLocais.Add(usuarioBD);
                parametrosLocais.Add(senhaBD);
                parametrosLocais.Add(nomeBD);

                this.parametrosBD = parametrosLocais;
            }

            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("O Arquivo 'Parametros.xml' não foi localizado na pasta do sistema, o sistema será encerrado !");
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            return this.parametrosBD;
        }


        //public Boolean salvarConfiguracoes(List<String> listaDeParametros, String caminhoArquivoDeConfiguracao, String tipoRajada, int indiceInicial, int indiceFinal)
        //{
        //    try
        //    {
        //        XDocument xml = XDocument.Load(caminhoArquivoDeConfiguracao);

        //        for (int contador = indiceInicial; contador <= indiceFinal; contador++)
        //        {
           
        //                xml.Element("Parametros")
        //                    .Elements("TipoRajada")
        //                    .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                    .SetElementValue("CaminhoRajadas", listaDeParametros[contador]);

        //              contador = contador + 1;

        //                xml.Element("Parametros")
        //                    .Elements("TipoRajada")
        //                    .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                    .SetElementValue("CaminhoRajadasProcessadas", listaDeParametros[contador]);

        //              contador = contador + 1;

        //                xml.Element("Parametros")
        //                    .Elements("TipoRajada")
        //                    .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                    .SetElementValue("ConfiguracaoCopiarOuMover", listaDeParametros[contador]);

        //              contador = contador  + 1;

        //                xml.Element("Parametros")
        //                    .Elements("TipoRajada")
        //                    .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                    .SetElementValue("Intervalo", listaDeParametros[contador]);

        //               contador = contador + 1;

        //                xml.Element("Parametros")
        //                    .Elements("TipoRajada")
        //                    .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                    .SetElementValue("Frequencia", listaDeParametros[contador]);

        //            contador = contador + 1;

        //            xml.Element("Parametros")
        //                    .Elements("TipoRajada")
        //                    .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                    .SetElementValue("StatusLeitura", listaDeParametros[contador]);

        //            contador = contador + 1;

        //            xml.Element("Parametros")
        //                .Elements("TipoRajada")
        //                .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                .SetElementValue("StatusMonitoramento", listaDeParametros[contador]);

        //            contador = contador + 1;

        //            xml.Element("Parametros")
        //                .Elements("TipoRajada")
        //                .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                .SetElementValue("IntervaloMonitoramento", listaDeParametros[contador]);

        //            contador = contador + 1;

        //            xml.Element("Parametros")
        //                .Elements("TipoRajada")
        //                .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                .SetElementValue("FrequenciaMonitoramento", listaDeParametros[contador]);

        //            contador = contador + 1;

        //            xml.Element("Parametros")
        //                    .Elements("TipoRajada")
        //                    .Where(x => x.Attribute("Id").Value == tipoRajada).FirstOrDefault()
        //                    .SetElementValue("DestinatariosMonitoramento", listaDeParametros[contador]);


        //        }

        //        xml.Save(caminhoArquivoDeConfiguracao);

        //    }

        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Erro: " + e.Message);
        //    }

        //    return true;

        //}

    }
}
