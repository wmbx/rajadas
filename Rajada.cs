using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace rajadas
{
    class Rajada
    {
        public String horarioRajada;
        public String tipoRegistro;
        public String agencia;
        public String zeros;
        public String conta;
        public String dac;
        public String segmento;
        public String sequencia;
        public String codigoEmpresa;
        public String indicadorSequenciaParticipante;
        public String indicadorRepresentanteLegal;
        public String codigoParticipante;
        public String titularOuRepresentante;
        public String sequenciaDoTitular;
        public String tipoConta;
        public String titularidadeConta;
        public String pacoteServicos;
        public String descricaoTarifaBancaria;
        public String terminoCurso;
        public String nomeTitular;
        public String cpfTitular;
        public String dacCpfTitular;
        public String tipoDocIdentificacao;
        public String numeroDocIdentificacao;
        public String dataEmissaoDocIdentificacao;
        public String orgaoEmissorDocIdentificacao;
        public String estadoEmissorDocIdentificacao;
        public String paisEmissorDocIdentificacao;
        public String sexo;
        public String escolaridade;
        public String statusUniversitario;
        public String mesAnoConclusao;
        public String estadoCivil;
        public String qtdDependentes;
        public String dataNascimentoTitular;
        public String cidadeNascimento;
        public String estadoNascimento;
        public String paisNascimento;
        public String nacionalidade;
        public String nomePai;
        public String nomeMae;
        public String nomeConjuge;
        public String cpfConjuge;
        public String dacCpfConjuge;
        public String tipoResidencia;
        public String tempoResidencia;
        public String cepGrupoUm;
        public String cepGrupoDois;
        public String logradouroResidencia;
        public String numeroResidencia;
        public String complementoResidencia;
        public String bairroResidencia;
        public String cidadeResidencia;
        public String estadoResidencia;
        public String beneficiarioInss;
        public String vincularBeneficioConta;
        public String numeroBeneficio;
        public String indicadorTelefone;
        public String dddTelefone;
        public String numeroTelefone;
        public String origemRenda;
        public String profissao;
        public String descricaoProfissao;
        public String rendaMensal;
        public String motivoSemRenda;
        public String motivoSemRendaOutros;
        public String rendaComprovada;
        public String nomeEmpresarial;
        public String qualificacaoCliente;
        public String patrimonio;
        public String tipoPatrimonio;
        public String motivoSemPatrimonio;
        public String motivoSemPatrimonioOutros;
        public String dataAdmissao;
        public String tipoDadoProfissional;
        public String identificadorEndereco;
        public String cepComercial;
        public String logradouroComercial;
        public String numeroComercial;
        public String complementoComercial;
        public String bairroComercial;
        public String cidadeComercial;
        public String estadoComercial;
        public String propositoConta;
        public String execeCargoPublico;
        public String lec;
        public String envioCorrespondencia;
        public String transferenciaRecursosContaSalario;
        public String cnpjEmpregador;
        public String situacaoEspecial;
        public String funcionalGerente;
        public String codigoGerente;
        public String funcionalResponsavelDocumentos;
        public String funcionalResponsavelProdutos;
        public String localData1;
        public String localData2;
        public String produtoLisCep;
        public String produtoCartaoMultiplo;
        public String produtoCartaoCredito;
        public String produtoDebitoAutomatico;
        public String produtoEntregaChequesDomicilio;
        public String produtoCartaoProvisorio;
        public String produtoAplicaut;
        public String produtoCollectePersonnalite;
        public String produtoSeguroCartaoDebito;
        public String produtoAplicautCciPersonnalite;
        public String produtoSeguroLis;
        public String produtoSeguroMultiprotecao;
        public String produtoAdiatamentoDepositante;
        public String produtoCartaoDebito;
        public String produtoServicoAvaliacaoEmergencialCredito;
        public String tipoEmpresa;
        public String codigoBanco;
        public String codigoSistema;
        public String codigoProduto;
        public String faseConta;
        public String qtdDocumentos;
        public String numeroLote;
        public String nomeReceitaFederal;
        public String dataLiberacaoDocumento;
        public String horaLiberacaoDocumento;
        public String codigoBeneficio;
        public String nomeBeneficio;
        public String indicadorContaOnline;
        public String indicadorDispensaValidacaoComprovanteResidencia;
        public String indicadorSpi;
        public String idPropostaSh;
        public String codigoRajada;
        public String codigoFormalizacao;

        public List<Rajada> lerArquivoTxtRajadaTijolo(String caminhoArquivoTXT, String caminhoRajadasProcessadas, String parametroCopiarOuMover)
        {
            
            var listaDeObjetosRajadas = new List<Rajada>();
            
            var listaDeArquivosTxtRajadas = new List<String>();

            var listaDeDiretorios = new List<String>();

            var listaDeArquivosEmCadaDiretorio = new List<String>();

            try
            {
                listaDeDiretorios = Directory.GetDirectories(caminhoArquivoTXT).ToList();
                listaDeDiretorios.Add(caminhoArquivoTXT);

                String ano = DateTime.Now.Year.ToString();
                String mes = DateTime.Now.Month.ToString();
                // ** Acrescenta 0 ao mês ** //
                if (Convert.ToInt32(mes) < 10)
                {
                    mes = "0" + mes;
                }
                // ** Acrescenta 0 ao mês ** //
                String dia = DateTime.Now.Day.ToString();

                // ** Acrescenta 0 ao dia ** //
                if (Convert.ToInt32(dia) < 10)
                {
                    dia = "0" + dia;
                }
                String dataAtual = ano + mes + dia;

                foreach (var diretorio in listaDeDiretorios)
                {
                    // ** Recupera a quantidade de caracteres do caminho do diretório ** //
                    int qtdCaracteres = diretorio.Length;

                    // ** Pega o nome da pasta ** //
                    if (qtdCaracteres > 7)
                    {
                        String diretorioAjustado = diretorio.Substring(qtdCaracteres - 8);

                        if (diretorioAjustado == dataAtual)
                        {
                            listaDeArquivosEmCadaDiretorio = Directory.GetFiles(diretorio).ToList();
                            foreach (var arquivoEncontrado in listaDeArquivosEmCadaDiretorio)
                            {
                                listaDeArquivosTxtRajadas.Add(arquivoEncontrado);
                            }
                        }
                    }                 
                }

                foreach (var arquivoTxtRajada in listaDeArquivosTxtRajadas)
                {
                    FileInfo informacaoDoArquivo = new FileInfo(arquivoTxtRajada);
                    String nomeArquivoRajadaTxt = informacaoDoArquivo.Name;

                    // ** Valida se o nome do diretório é maior que 10 antes de fazer o substring ** //
                    if (nomeArquivoRajadaTxt.Length > 10)
                    {
                        String parteDoNomeDoArquivo = nomeArquivoRajadaTxt.Substring(0, 11);

                        if (parteDoNomeDoArquivo == "ARQBRSAGORD")
                        {
                            String diretorioRajadaProcessada = "";
                            diretorioRajadaProcessada = caminhoRajadasProcessadas + "\\" + nomeArquivoRajadaTxt;

                            if (File.Exists(diretorioRajadaProcessada))
                            {

                            }
                            else
                            {
                                // ----------- ** Copia o arquivo para o diretório de rajada processada antes de iniciar a leitura ** -----------//
                                File.Copy(arquivoTxtRajada, diretorioRajadaProcessada);
                                // ----------- ** Copia o arquivo para o diretório de rajada processada antes de iniciar a leitura ** -----------//

                                // ** Pega o horário da rajada através do nome do arquivo ** //
                                String horarioOriginal = nomeArquivoRajadaTxt.Substring(nomeArquivoRajadaTxt.Length - 10, 4);
                                String horarioFormatado = horarioOriginal.Substring(0, 2) + ":" + horarioOriginal.Substring(2, 2);
                                // ** Pega o horário da rajada através do nome do arquivo ** //

                                string[] arquivoTXT = File.ReadAllLines(arquivoTxtRajada);
                                foreach (var linha in arquivoTXT)
                                {
                                    if (linha.Substring(0, 1).Equals("1"))
                                    {
                                        Rajada rajada = new Rajada();
                                        rajada.horarioRajada = horarioFormatado;
                                        rajada.tipoRegistro = linha.Substring(0, 1);
                                        rajada.agencia = linha.Substring(1, 4);
                                        rajada.zeros = linha.Substring(5, 2);
                                        rajada.conta = linha.Substring(7, 5);
                                        rajada.dac = linha.Substring(12, 1);
                                        rajada.segmento = linha.Substring(13, 2);
                                        rajada.sequencia = linha.Substring(15, 4);
                                        rajada.codigoEmpresa = linha.Substring(19, 3);
                                        rajada.indicadorSequenciaParticipante = linha.Substring(22, 4);
                                        rajada.indicadorRepresentanteLegal = linha.Substring(26, 3);
                                        rajada.codigoParticipante = linha.Substring(29, 4);
                                        rajada.titularOuRepresentante = linha.Substring(33, 1);
                                        rajada.sequenciaDoTitular = linha.Substring(34, 2);
                                        rajada.tipoConta = linha.Substring(36, 1);
                                        rajada.titularidadeConta = linha.Substring(37, 1);
                                        rajada.pacoteServicos = linha.Substring(38, 2);
                                        rajada.descricaoTarifaBancaria = linha.Substring(40, 15);
                                        rajada.terminoCurso = linha.Substring(55, 6);
                                        rajada.nomeTitular = linha.Substring(61, 50);
                                        rajada.cpfTitular = linha.Substring(111, 9);
                                        rajada.dacCpfTitular = linha.Substring(120, 2);
                                        rajada.tipoDocIdentificacao = linha.Substring(122, 5);
                                        rajada.numeroDocIdentificacao = linha.Substring(127, 13);
                                        rajada.dataEmissaoDocIdentificacao = linha.Substring(140, 8);
                                        rajada.orgaoEmissorDocIdentificacao = linha.Substring(148, 7);
                                        rajada.estadoEmissorDocIdentificacao = linha.Substring(155, 2);
                                        rajada.paisEmissorDocIdentificacao = linha.Substring(157, 2);
                                        rajada.sexo = linha.Substring(159, 1);
                                        rajada.escolaridade = linha.Substring(160, 1);
                                        rajada.statusUniversitario = linha.Substring(161, 1);
                                        rajada.mesAnoConclusao = linha.Substring(162, 6);
                                        rajada.estadoCivil = linha.Substring(168, 1);
                                        rajada.qtdDependentes = linha.Substring(169, 2);
                                        rajada.dataNascimentoTitular = linha.Substring(171, 8);
                                        rajada.cidadeNascimento = linha.Substring(179, 20);
                                        rajada.estadoNascimento = linha.Substring(199, 2);
                                        rajada.paisNascimento = linha.Substring(201, 2);
                                        rajada.nacionalidade = linha.Substring(203, 2);
                                        rajada.nomePai = linha.Substring(205, 30);
                                        rajada.nomeMae = linha.Substring(235, 30);
                                        rajada.nomeConjuge = linha.Substring(265, 30);
                                        rajada.cpfConjuge = linha.Substring(295, 9);
                                        rajada.dacCpfConjuge = linha.Substring(304, 2);
                                        rajada.tipoResidencia = linha.Substring(306, 1);
                                        rajada.tempoResidencia = linha.Substring(307, 1);
                                        rajada.cepGrupoUm = linha.Substring(308, 5);
                                        rajada.cepGrupoDois = linha.Substring(313, 3);
                                        rajada.logradouroResidencia = linha.Substring(316, 30);
                                        rajada.numeroResidencia = linha.Substring(346, 5);
                                        rajada.complementoResidencia = linha.Substring(351, 15);
                                        rajada.bairroResidencia = linha.Substring(366, 15);
                                        rajada.cidadeResidencia = linha.Substring(381, 20);
                                        rajada.estadoResidencia = linha.Substring(401, 2);
                                        rajada.beneficiarioInss = linha.Substring(403, 1);
                                        rajada.vincularBeneficioConta = linha.Substring(404, 1);
                                        rajada.numeroBeneficio = linha.Substring(405, 15);
                                        rajada.indicadorTelefone = linha.Substring(420, 1);
                                        rajada.dddTelefone = linha.Substring(421, 2);
                                        rajada.numeroTelefone = linha.Substring(423, 9);
                                        rajada.origemRenda = linha.Substring(432, 1);
                                        rajada.profissao = linha.Substring(433, 3);
                                        rajada.descricaoProfissao = linha.Substring(436, 15);
                                        rajada.rendaMensal = linha.Substring(451, 11);
                                        rajada.motivoSemRenda = linha.Substring(462, 1);
                                        rajada.motivoSemRendaOutros = linha.Substring(463, 20);
                                        rajada.rendaComprovada = linha.Substring(483, 1);
                                        rajada.nomeEmpresarial = linha.Substring(484, 30);
                                        rajada.qualificacaoCliente = linha.Substring(514, 40);
                                        rajada.patrimonio = linha.Substring(554, 11);
                                        rajada.tipoPatrimonio = linha.Substring(565, 1);
                                        rajada.motivoSemPatrimonio = linha.Substring(566, 1);
                                        rajada.motivoSemPatrimonioOutros = linha.Substring(567, 20);
                                        rajada.dataAdmissao = linha.Substring(587, 6);
                                        rajada.tipoDadoProfissional = linha.Substring(593, 6);
                                        rajada.identificadorEndereco = linha.Substring(594, 1);
                                        rajada.cepComercial = linha.Substring(595, 8);
                                        rajada.logradouroComercial = linha.Substring(603, 30);
                                        rajada.numeroComercial = linha.Substring(633, 5);
                                        rajada.complementoComercial = linha.Substring(638, 15);
                                        rajada.bairroComercial = linha.Substring(653, 15);
                                        rajada.cidadeComercial = linha.Substring(668, 20);
                                        rajada.estadoComercial = linha.Substring(688, 2);
                                        rajada.propositoConta = linha.Substring(690, 1);
                                        rajada.execeCargoPublico = linha.Substring(691, 1);
                                        rajada.lec = linha.Substring(692, 1);
                                        rajada.envioCorrespondencia = linha.Substring(693, 1);
                                        rajada.transferenciaRecursosContaSalario = linha.Substring(694, 1);
                                        rajada.cnpjEmpregador = linha.Substring(695, 14);
                                        rajada.situacaoEspecial = linha.Substring(709, 1);
                                        rajada.funcionalGerente = linha.Substring(710, 9);
                                        rajada.codigoGerente = linha.Substring(719, 2);
                                        rajada.funcionalResponsavelDocumentos = linha.Substring(721, 9);
                                        rajada.funcionalResponsavelProdutos = linha.Substring(730, 9);
                                        rajada.localData1 = linha.Substring(739, 20);
                                        rajada.localData2 = linha.Substring(759, 8);
                                        rajada.produtoLisCep = linha.Substring(767, 1);
                                        rajada.produtoCartaoMultiplo = linha.Substring(768, 1);
                                        rajada.produtoCartaoCredito = linha.Substring(769, 1);
                                        rajada.produtoDebitoAutomatico = linha.Substring(770, 1);
                                        rajada.produtoEntregaChequesDomicilio = linha.Substring(771, 1);
                                        rajada.produtoCartaoProvisorio = linha.Substring(772, 1);
                                        rajada.produtoAplicaut = linha.Substring(773, 1);
                                        rajada.produtoCollectePersonnalite = linha.Substring(774, 1);
                                        rajada.produtoSeguroCartaoDebito = linha.Substring(775, 1);
                                        rajada.produtoAplicautCciPersonnalite = linha.Substring(776, 1);
                                        rajada.produtoSeguroLis = linha.Substring(777, 1);
                                        rajada.produtoSeguroMultiprotecao = linha.Substring(778, 1);
                                        rajada.produtoAdiatamentoDepositante = linha.Substring(779, 1);
                                        rajada.produtoCartaoDebito = linha.Substring(780, 1);
                                        rajada.produtoServicoAvaliacaoEmergencialCredito = linha.Substring(781, 1);
                                        rajada.tipoEmpresa = linha.Substring(782, 3);
                                        rajada.codigoBanco = linha.Substring(785, 3);
                                        rajada.codigoSistema = linha.Substring(788, 2);
                                        rajada.codigoProduto = linha.Substring(790, 3);
                                        rajada.faseConta = linha.Substring(793, 3);
                                        rajada.qtdDocumentos = linha.Substring(796, 3);
                                        rajada.numeroLote = linha.Substring(799, 16);
                                        rajada.nomeReceitaFederal = linha.Substring(815, 50);
                                        rajada.dataLiberacaoDocumento = linha.Substring(865, 10);
                                        rajada.horaLiberacaoDocumento = linha.Substring(875, 8);
                                        rajada.codigoBeneficio = linha.Substring(883, 2);
                                        rajada.nomeBeneficio = linha.Substring(885, 30);
                                        rajada.indicadorContaOnline = linha.Substring(915, 1);
                                        rajada.indicadorDispensaValidacaoComprovanteResidencia = linha.Substring(916, 1);

                                        listaDeObjetosRajadas.Add(rajada);

                                    }
                                }
                                // -- ** Exclui o arquivo do diretório de orgigem caso o sistema esteja parametrizado para isso -- ** //
                                if (parametroCopiarOuMover == "Mover Arquivo Processado")
                                {
                                    File.Delete(arquivoTxtRajada);
                                }
                                // -- ** Exclui o arquivo do diretório de orgigem caso o sistema esteja parametrizado para isso -- ** //
                            }
                        }
                    }
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
                Application.Exit();
            }

            return listaDeObjetosRajadas;
        }

        public List<Rajada> lerArquivoTxtRajadaDigital(String caminhoArquivoTXT, String caminhoRajadasProcessadas, String parametroCopiarOuMover)
        {
            var listaDeObjetosRajadas = new List<Rajada>();

            var listaDeArquivosTxtRajadas = new List<String>();

            var listaDeDiretorios = new List<String>();

            var listaDeArquivosEmCadaDiretorio = new List<String>();

            try
            {

                listaDeDiretorios = Directory.GetDirectories(caminhoArquivoTXT).ToList();
                listaDeDiretorios.Add(caminhoArquivoTXT);

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

                String dataAtual = ano + mes + dia;

                foreach (var diretorio in listaDeDiretorios)
                {
                    // ** Recupera a quantidade de caracteres do caminho do diretório ** //
                    int qtdCaracteres = diretorio.Length;

                    // ** Pega o nome da pasta ** //
                    if (qtdCaracteres > 7)
                    {
                        String diretorioAjustado = diretorio.Substring(qtdCaracteres - 8);

                        if (diretorioAjustado == dataAtual)
                        {
                            listaDeArquivosEmCadaDiretorio = Directory.GetFiles(diretorio).ToList();
                            foreach (var arquivoEncontrado in listaDeArquivosEmCadaDiretorio)
                            {
                                listaDeArquivosTxtRajadas.Add(arquivoEncontrado);
                            }
                        }
                    }
                }

                foreach (var arquivoTxtRajada in listaDeArquivosTxtRajadas)
                {
                    FileInfo informacaoDoArquivo = new FileInfo(arquivoTxtRajada);
                    String nomeArquivoRajadaTxt = informacaoDoArquivo.Name;

                    // ** Valida se o nome do diretório é maior que 12 antes de fazer o substring ** //
                    if (nomeArquivoRajadaTxt.Length > 12)
                    {
                        String parteDoNomeDoArquivo = nomeArquivoRajadaTxt.Substring(0, 13);

                        if (parteDoNomeDoArquivo == "BRSCANDIGITAL")
                        {

                            String diretorioRajadaProcessada = "";
                            diretorioRajadaProcessada = caminhoRajadasProcessadas + "\\" + nomeArquivoRajadaTxt;


                            if (File.Exists(diretorioRajadaProcessada))
                            {

                            }
                            else
                            {
                                // ----------- ** Copia o arquivo para o diretório de rajada processada antes de iniciar a leitura ** -----------//
                                File.Copy(arquivoTxtRajada, diretorioRajadaProcessada);
                                // ----------- ** Copia o arquivo para o diretório de rajada processada antes de iniciar a leitura ** -----------//

                                // ** Pega o horário da rajada através do nome do arquivo ** //
                                String horarioOriginal = nomeArquivoRajadaTxt.Substring(nomeArquivoRajadaTxt.Length - 10, 4);
                                String horarioFormatado = horarioOriginal.Substring(0, 2) + ":" + horarioOriginal.Substring(2, 2);
                                // ** Pega o horário da rajada através do nome do arquivo ** //

                                string[] arquivoTXT = File.ReadAllLines(arquivoTxtRajada);
                                foreach (var linha in arquivoTXT)
                                {
                                    if (linha.Substring(0, 1).Equals("1"))
                                    {
                                        Rajada rajada = new Rajada();
                                        rajada.horarioRajada = horarioFormatado;
                                        rajada.tipoRegistro = linha.Substring(0, 1);
                                        rajada.agencia = linha.Substring(1, 4);
                                        rajada.zeros = linha.Substring(5, 2);
                                        rajada.conta = linha.Substring(7, 5);
                                        rajada.dac = linha.Substring(12, 1);
                                        rajada.segmento = linha.Substring(13, 2);
                                        rajada.sequencia = linha.Substring(15, 4);
                                        rajada.codigoEmpresa = linha.Substring(19, 3);
                                        rajada.indicadorSequenciaParticipante = linha.Substring(22, 4);
                                        rajada.indicadorRepresentanteLegal = linha.Substring(26, 3);
                                        rajada.codigoParticipante = linha.Substring(29, 4);
                                        rajada.titularOuRepresentante = linha.Substring(33, 1);
                                        rajada.sequenciaDoTitular = linha.Substring(34, 2);
                                        rajada.tipoConta = linha.Substring(36, 1);
                                        rajada.titularidadeConta = linha.Substring(37, 1);
                                        rajada.pacoteServicos = linha.Substring(38, 2);
                                        rajada.descricaoTarifaBancaria = linha.Substring(40, 15);
                                        rajada.terminoCurso = linha.Substring(55, 6);
                                        rajada.nomeTitular = linha.Substring(61, 50);
                                        rajada.cpfTitular = linha.Substring(111, 9);
                                        rajada.dacCpfTitular = linha.Substring(120, 2);
                                        rajada.tipoDocIdentificacao = linha.Substring(122, 5);
                                        rajada.numeroDocIdentificacao = linha.Substring(127, 13);
                                        rajada.dataEmissaoDocIdentificacao = linha.Substring(140, 8);
                                        rajada.orgaoEmissorDocIdentificacao = linha.Substring(148, 7);
                                        rajada.estadoEmissorDocIdentificacao = linha.Substring(155, 2);
                                        rajada.paisEmissorDocIdentificacao = linha.Substring(157, 2);
                                        rajada.sexo = linha.Substring(159, 1);
                                        rajada.escolaridade = linha.Substring(160, 1);
                                        rajada.statusUniversitario = linha.Substring(161, 1);
                                        rajada.mesAnoConclusao = linha.Substring(162, 6);
                                        rajada.estadoCivil = linha.Substring(168, 1);
                                        rajada.qtdDependentes = linha.Substring(169, 2);
                                        rajada.dataNascimentoTitular = linha.Substring(171, 8);
                                        rajada.cidadeNascimento = linha.Substring(179, 20);
                                        rajada.estadoNascimento = linha.Substring(199, 2);
                                        rajada.paisNascimento = linha.Substring(201, 2);
                                        rajada.nacionalidade = linha.Substring(203, 2);
                                        rajada.nomePai = linha.Substring(205, 30);
                                        rajada.nomeMae = linha.Substring(235, 30);
                                        rajada.nomeConjuge = linha.Substring(265, 30);
                                        rajada.cpfConjuge = linha.Substring(295, 9);
                                        rajada.dacCpfConjuge = linha.Substring(304, 2);
                                        rajada.tipoResidencia = linha.Substring(306, 1);
                                        rajada.tempoResidencia = linha.Substring(307, 1);
                                        rajada.cepGrupoUm = linha.Substring(308, 5);
                                        rajada.cepGrupoDois = linha.Substring(313, 3);
                                        rajada.logradouroResidencia = linha.Substring(316, 30);
                                        rajada.numeroResidencia = linha.Substring(346, 5);
                                        rajada.complementoResidencia = linha.Substring(351, 15);
                                        rajada.bairroResidencia = linha.Substring(366, 15);
                                        rajada.cidadeResidencia = linha.Substring(381, 20);
                                        rajada.estadoResidencia = linha.Substring(401, 2);
                                        rajada.beneficiarioInss = linha.Substring(403, 1);
                                        rajada.vincularBeneficioConta = linha.Substring(404, 1);
                                        rajada.numeroBeneficio = linha.Substring(405, 15);
                                        rajada.indicadorTelefone = linha.Substring(420, 1);
                                        rajada.dddTelefone = linha.Substring(421, 2);
                                        rajada.numeroTelefone = linha.Substring(423, 9);
                                        rajada.origemRenda = linha.Substring(432, 1);
                                        rajada.profissao = linha.Substring(433, 3);
                                        rajada.descricaoProfissao = linha.Substring(436, 15);
                                        rajada.rendaMensal = linha.Substring(451, 11);
                                        rajada.motivoSemRenda = linha.Substring(462, 1);
                                        rajada.motivoSemRendaOutros = linha.Substring(463, 20);
                                        rajada.rendaComprovada = linha.Substring(483, 1);
                                        rajada.nomeEmpresarial = linha.Substring(484, 30);
                                        rajada.qualificacaoCliente = linha.Substring(514, 40);
                                        rajada.patrimonio = linha.Substring(554, 11);
                                        rajada.tipoPatrimonio = linha.Substring(565, 1);
                                        rajada.motivoSemPatrimonio = linha.Substring(566, 1);
                                        rajada.motivoSemPatrimonioOutros = linha.Substring(567, 20);
                                        rajada.dataAdmissao = linha.Substring(587, 6);
                                        rajada.tipoDadoProfissional = linha.Substring(593, 1);
                                        rajada.identificadorEndereco = linha.Substring(594, 1);
                                        rajada.cepComercial = linha.Substring(595, 8);
                                        rajada.logradouroComercial = linha.Substring(603, 30);
                                        rajada.numeroComercial = linha.Substring(633, 5);
                                        rajada.complementoComercial = linha.Substring(638, 15);
                                        rajada.bairroComercial = linha.Substring(653, 15);
                                        rajada.cidadeComercial = linha.Substring(668, 20);
                                        rajada.estadoComercial = linha.Substring(688, 2);
                                        rajada.propositoConta = linha.Substring(690, 1);
                                        rajada.execeCargoPublico = linha.Substring(691, 1);
                                        rajada.lec = linha.Substring(692, 1);
                                        rajada.envioCorrespondencia = linha.Substring(693, 1);
                                        rajada.transferenciaRecursosContaSalario = linha.Substring(694, 1);
                                        rajada.cnpjEmpregador = linha.Substring(695, 14);
                                        rajada.situacaoEspecial = linha.Substring(709, 1);
                                        rajada.funcionalGerente = linha.Substring(710, 9);
                                        rajada.codigoGerente = linha.Substring(719, 2);
                                        rajada.funcionalResponsavelDocumentos = linha.Substring(721, 9);
                                        rajada.funcionalResponsavelProdutos = linha.Substring(730, 9);
                                        rajada.localData1 = linha.Substring(739, 20);
                                        rajada.localData2 = linha.Substring(759, 8);
                                        rajada.produtoLisCep = linha.Substring(767, 1);
                                        rajada.produtoCartaoMultiplo = linha.Substring(768, 1);
                                        rajada.produtoCartaoCredito = linha.Substring(769, 1);
                                        rajada.produtoDebitoAutomatico = linha.Substring(770, 1);
                                        rajada.produtoEntregaChequesDomicilio = linha.Substring(771, 1);
                                        rajada.produtoCartaoProvisorio = linha.Substring(772, 1);
                                        rajada.produtoAplicaut = linha.Substring(773, 1);
                                        rajada.produtoCollectePersonnalite = linha.Substring(774, 1);
                                        rajada.produtoSeguroCartaoDebito = linha.Substring(775, 1);
                                        rajada.produtoAplicautCciPersonnalite = linha.Substring(776, 1);
                                        rajada.produtoSeguroLis = linha.Substring(777, 1);
                                        rajada.produtoSeguroMultiprotecao = linha.Substring(778, 1);
                                        rajada.produtoAdiatamentoDepositante = linha.Substring(779, 1);
                                        rajada.produtoCartaoDebito = linha.Substring(780, 1);
                                        rajada.produtoServicoAvaliacaoEmergencialCredito = linha.Substring(781, 1);
                                        rajada.tipoEmpresa = linha.Substring(782, 3);
                                        rajada.codigoBanco = linha.Substring(785, 3);
                                        rajada.codigoSistema = linha.Substring(788, 2);
                                        rajada.codigoProduto = linha.Substring(790, 3);
                                        rajada.faseConta = linha.Substring(793, 3);
                                        rajada.qtdDocumentos = linha.Substring(796, 3);
                                        rajada.numeroLote = linha.Substring(799, 16);
                                        rajada.nomeReceitaFederal = linha.Substring(815, 50);
                                        rajada.dataLiberacaoDocumento = linha.Substring(865, 10);
                                        rajada.horaLiberacaoDocumento = linha.Substring(875, 8);
                                        rajada.codigoBeneficio = linha.Substring(883, 2);
                                        rajada.nomeBeneficio = linha.Substring(885, 30);
                                        rajada.indicadorContaOnline = linha.Substring(915, 1);
                                        rajada.indicadorDispensaValidacaoComprovanteResidencia = linha.Substring(916, 1);
                                        rajada.indicadorSpi = linha.Substring(917, 1);
                                        rajada.idPropostaSh = linha.Substring(918, 15);
                                        rajada.codigoRajada = linha.Substring(933, 2);
                                        rajada.codigoFormalizacao = linha.Substring(935, 15);

                                        listaDeObjetosRajadas.Add(rajada);
                                    }
                                }
                                // -- ** Exclui o arquivo do diretório de orgigem caso o sistema esteja parametrizado para isso -- ** //
                                if (parametroCopiarOuMover == "Mover Arquivo Processado")
                                {
                                    File.Delete(arquivoTxtRajada);
                                }
                                // -- ** Exclui o arquivo do diretório de orgigem caso o sistema esteja parametrizado para isso -- ** //
                            }
                        }
                    }
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }
            return listaDeObjetosRajadas;
        }

        public List<Rajada> lerArquivoTxtRajadaInvertida(String caminhoArquivoTXT, String caminhoRajadasProcessadas, String parametroCopiarOuMover)
        {
            var listaDeObjetosRajadas = new List<Rajada>();

            var listaDeArquivosTxtRajadas = new List<String>();

            var listaDeDiretorios = new List<String>();

            var listaDeArquivosEmCadaDiretorio = new List<String>();

            try
            {
                listaDeDiretorios = Directory.GetDirectories(caminhoArquivoTXT).ToList();
                listaDeDiretorios.Add(caminhoArquivoTXT);

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

                String dataAtual = ano + mes + dia;

                foreach (var diretorio in listaDeDiretorios)
                {
                    // ** Recupera a quantidade de caracteres do caminho do diretório ** //
                    int qtdCaracteres = diretorio.Length;

                    // ** Pega o nome da pasta ** //
                    if (qtdCaracteres > 7)
                    {
                        String diretorioAjustado = diretorio.Substring(qtdCaracteres - 8);

                        if (diretorioAjustado == dataAtual)
                        {
                            listaDeArquivosEmCadaDiretorio = Directory.GetFiles(diretorio).ToList();
                            foreach (var arquivoEncontrado in listaDeArquivosEmCadaDiretorio)
                            {
                                listaDeArquivosTxtRajadas.Add(arquivoEncontrado);
                            }
                        }
                    }
                }

                foreach (var arquivoTxtRajada in listaDeArquivosTxtRajadas)
                {
                FileInfo informacaoDoArquivo = new FileInfo(arquivoTxtRajada);
                String nomeArquivoRajadaTxt = informacaoDoArquivo.Name;

                    // ** Valida se o nome do diretório é maior que 10 antes de fazer o substring ** //
                    if (nomeArquivoRajadaTxt.Length > 10)
                    {
                        String parteDoNomeDoArquivo = nomeArquivoRajadaTxt.Substring(0, 11);

                        if (parteDoNomeDoArquivo == "ARQBRSINVER")
                        {
                            String diretorioRajadaProcessada = "";
                            diretorioRajadaProcessada = caminhoRajadasProcessadas + "\\" + nomeArquivoRajadaTxt;


                            if (File.Exists(diretorioRajadaProcessada))
                            {

                            }
                            else
                            {
                                // ----------- ** Copia o arquivo para o diretório de rajada processada antes de iniciar a leitura ** -----------//
                                File.Copy(arquivoTxtRajada, diretorioRajadaProcessada);
                                // ----------- ** Copia o arquivo para o diretório de rajada processada antes de iniciar a leitura ** -----------//

                                // ** Pega o horário da rajada através do nome do arquivo ** //
                                String horarioOriginal = nomeArquivoRajadaTxt.Substring(nomeArquivoRajadaTxt.Length - 10, 4);
                                String horarioFormatado = horarioOriginal.Substring(0, 2) + ":" + horarioOriginal.Substring(2, 2);
                                // ** Pega o horário da rajada através do nome do arquivo ** //

                                string[] arquivoTXT = File.ReadAllLines(arquivoTxtRajada);
                                foreach (var linha in arquivoTXT)
                                {
                                    if (linha.Substring(0, 1).Equals("1"))
                                    {
                                        Rajada rajada = new Rajada();
                                        rajada.horarioRajada = horarioFormatado;
                                        rajada.tipoRegistro = linha.Substring(0, 1);
                                        rajada.agencia = linha.Substring(1, 4);
                                        rajada.zeros = linha.Substring(5, 2);
                                        rajada.conta = linha.Substring(7, 5);
                                        rajada.dac = linha.Substring(12, 1);
                                        rajada.segmento = linha.Substring(13, 2);
                                        rajada.sequencia = linha.Substring(15, 4);
                                        rajada.codigoEmpresa = linha.Substring(19, 3);
                                        rajada.indicadorSequenciaParticipante = linha.Substring(22, 4);
                                        rajada.indicadorRepresentanteLegal = linha.Substring(26, 3);
                                        rajada.codigoParticipante = linha.Substring(29, 4);
                                        rajada.titularOuRepresentante = linha.Substring(33, 1);
                                        rajada.sequenciaDoTitular = linha.Substring(34, 2);
                                        rajada.tipoConta = linha.Substring(36, 1);
                                        rajada.titularidadeConta = linha.Substring(37, 1);
                                        rajada.pacoteServicos = linha.Substring(38, 2);
                                        rajada.descricaoTarifaBancaria = linha.Substring(40, 15);
                                        rajada.terminoCurso = linha.Substring(55, 6);
                                        rajada.nomeTitular = linha.Substring(61, 50);
                                        rajada.cpfTitular = linha.Substring(111, 9);
                                        rajada.dacCpfTitular = linha.Substring(120, 2);
                                        rajada.tipoDocIdentificacao = linha.Substring(122, 5);
                                        rajada.numeroDocIdentificacao = linha.Substring(127, 13);
                                        rajada.dataEmissaoDocIdentificacao = linha.Substring(140, 8);
                                        rajada.orgaoEmissorDocIdentificacao = linha.Substring(148, 7);
                                        rajada.estadoEmissorDocIdentificacao = linha.Substring(155, 2);
                                        rajada.paisEmissorDocIdentificacao = linha.Substring(157, 2);
                                        rajada.sexo = linha.Substring(159, 1);
                                        rajada.escolaridade = linha.Substring(160, 1);
                                        rajada.statusUniversitario = linha.Substring(161, 1);
                                        rajada.mesAnoConclusao = linha.Substring(162, 6);
                                        rajada.estadoCivil = linha.Substring(168, 1);
                                        rajada.qtdDependentes = linha.Substring(169, 2);
                                        rajada.dataNascimentoTitular = linha.Substring(171, 8);
                                        rajada.cidadeNascimento = linha.Substring(179, 20);
                                        rajada.estadoNascimento = linha.Substring(199, 2);
                                        rajada.paisNascimento = linha.Substring(201, 2);
                                        rajada.nacionalidade = linha.Substring(203, 2);
                                        rajada.nomePai = linha.Substring(205, 30);
                                        rajada.nomeMae = linha.Substring(235, 30);
                                        rajada.nomeConjuge = linha.Substring(265, 30);
                                        rajada.cpfConjuge = linha.Substring(295, 9);
                                        rajada.dacCpfConjuge = linha.Substring(304, 2);
                                        rajada.tipoResidencia = linha.Substring(306, 1);
                                        rajada.tempoResidencia = linha.Substring(307, 1);
                                        rajada.cepGrupoUm = linha.Substring(308, 5);
                                        rajada.cepGrupoDois = linha.Substring(313, 3);
                                        rajada.logradouroResidencia = linha.Substring(316, 30);
                                        rajada.numeroResidencia = linha.Substring(346, 5);
                                        rajada.complementoResidencia = linha.Substring(351, 15);
                                        rajada.bairroResidencia = linha.Substring(366, 15);
                                        rajada.cidadeResidencia = linha.Substring(381, 20);
                                        rajada.estadoResidencia = linha.Substring(401, 2);
                                        rajada.beneficiarioInss = linha.Substring(403, 1);
                                        rajada.vincularBeneficioConta = linha.Substring(404, 1);
                                        rajada.numeroBeneficio = linha.Substring(405, 15);
                                        rajada.indicadorTelefone = linha.Substring(420, 1);
                                        rajada.dddTelefone = linha.Substring(421, 2);
                                        rajada.numeroTelefone = linha.Substring(423, 9);
                                        rajada.origemRenda = linha.Substring(432, 1);
                                        rajada.profissao = linha.Substring(433, 3);
                                        rajada.descricaoProfissao = linha.Substring(436, 15);
                                        rajada.rendaMensal = linha.Substring(451, 11);
                                        rajada.motivoSemRenda = linha.Substring(462, 1);
                                        rajada.motivoSemRendaOutros = linha.Substring(463, 20);
                                        rajada.rendaComprovada = linha.Substring(483, 1);
                                        rajada.nomeEmpresarial = linha.Substring(484, 30);
                                        rajada.qualificacaoCliente = linha.Substring(514, 40);
                                        rajada.patrimonio = linha.Substring(554, 11);
                                        rajada.tipoPatrimonio = linha.Substring(565, 1);
                                        rajada.motivoSemPatrimonio = linha.Substring(566, 1);
                                        rajada.motivoSemPatrimonioOutros = linha.Substring(567, 20);
                                        rajada.dataAdmissao = linha.Substring(587, 6);
                                        rajada.tipoDadoProfissional = linha.Substring(593, 1);
                                        rajada.identificadorEndereco = linha.Substring(594, 1);
                                        rajada.cepComercial = linha.Substring(595, 8);
                                        rajada.logradouroComercial = linha.Substring(603, 30);
                                        rajada.numeroComercial = linha.Substring(633, 5);
                                        rajada.complementoComercial = linha.Substring(638, 15);
                                        rajada.bairroComercial = linha.Substring(653, 15);
                                        rajada.cidadeComercial = linha.Substring(668, 20);
                                        rajada.estadoComercial = linha.Substring(688, 2);
                                        rajada.propositoConta = linha.Substring(690, 1);
                                        rajada.execeCargoPublico = linha.Substring(691, 1);
                                        rajada.lec = linha.Substring(692, 1);
                                        rajada.envioCorrespondencia = linha.Substring(693, 1);
                                        rajada.transferenciaRecursosContaSalario = linha.Substring(694, 1);
                                        rajada.cnpjEmpregador = linha.Substring(695, 14);
                                        rajada.situacaoEspecial = linha.Substring(709, 1);
                                        rajada.funcionalGerente = linha.Substring(710, 9);
                                        rajada.codigoGerente = linha.Substring(719, 2);
                                        rajada.funcionalResponsavelDocumentos = linha.Substring(721, 9);
                                        rajada.funcionalResponsavelProdutos = linha.Substring(730, 9);
                                        rajada.localData1 = linha.Substring(739, 20);
                                        rajada.localData2 = linha.Substring(759, 8);
                                        rajada.produtoLisCep = linha.Substring(767, 1);
                                        rajada.produtoCartaoMultiplo = linha.Substring(768, 1);
                                        rajada.produtoCartaoCredito = linha.Substring(769, 1);
                                        rajada.produtoDebitoAutomatico = linha.Substring(770, 1);
                                        rajada.produtoEntregaChequesDomicilio = linha.Substring(771, 1);
                                        rajada.produtoCartaoProvisorio = linha.Substring(772, 1);
                                        rajada.produtoAplicaut = linha.Substring(773, 1);
                                        rajada.produtoCollectePersonnalite = linha.Substring(774, 1);
                                        rajada.produtoSeguroCartaoDebito = linha.Substring(775, 1);
                                        rajada.produtoAplicautCciPersonnalite = linha.Substring(776, 1);
                                        rajada.produtoSeguroLis = linha.Substring(777, 1);
                                        rajada.produtoSeguroMultiprotecao = linha.Substring(778, 1);
                                        rajada.produtoAdiatamentoDepositante = linha.Substring(779, 1);
                                        rajada.produtoCartaoDebito = linha.Substring(780, 1);
                                        rajada.produtoServicoAvaliacaoEmergencialCredito = linha.Substring(781, 1);
                                        rajada.tipoEmpresa = linha.Substring(782, 3);
                                        rajada.codigoBanco = linha.Substring(785, 3);
                                        rajada.codigoSistema = linha.Substring(788, 2);
                                        rajada.codigoProduto = linha.Substring(790, 3);
                                        rajada.faseConta = linha.Substring(793, 3);
                                        rajada.qtdDocumentos = linha.Substring(796, 3);
                                        rajada.numeroLote = linha.Substring(799, 16);
                                        rajada.nomeReceitaFederal = linha.Substring(815, 60);
                                        rajada.dataLiberacaoDocumento = linha.Substring(875, 10);
                                        rajada.horaLiberacaoDocumento = linha.Substring(885, 8);
                                        rajada.codigoBeneficio = linha.Substring(893, 2);
                                        rajada.nomeBeneficio = linha.Substring(895, 30);
                                        rajada.indicadorContaOnline = linha.Substring(925, 1);
                                        rajada.indicadorDispensaValidacaoComprovanteResidencia = linha.Substring(926, 1);
                                        rajada.indicadorSpi = linha.Substring(927, 1);
                                        rajada.idPropostaSh = linha.Substring(928, 15);
                                        rajada.codigoRajada = linha.Substring(943, 2);
                                        rajada.codigoFormalizacao = linha.Substring(945, 15);

                                        listaDeObjetosRajadas.Add(rajada);
                                    }
                                }
                                // -- ** Exclui o arquivo do diretório de origem caso o sistema esteja parametrizado para isso -- ** //
                                if (parametroCopiarOuMover == "Mover Arquivo Processado")
                                {
                                    File.Delete(arquivoTxtRajada);
                                }
                                // -- ** Exclui o arquivo do diretório de origem caso o sistema esteja parametrizado para isso -- ** //
                            }
                        }
                    }
            }

            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            return listaDeObjetosRajadas;
        }

        public int retornaQuantidadeRegistrosProcessados(String caminhoArquivoTXT, String caminhoRajadasProcessadas, String nomeDoArquivo)
        {
            int quantidadeDeRegistros = 0;

            var listaDeArquivosTxtRajadas = new List<String>();

            var listaDeDiretorios = new List<String>();

            var listaDeArquivosEmCadaDiretorio = new List<String>();

            try
            {
                listaDeDiretorios = Directory.GetDirectories(caminhoArquivoTXT).ToList();
                listaDeDiretorios.Add(caminhoArquivoTXT);

                foreach (var diretorio in listaDeDiretorios)
                {
                    listaDeArquivosEmCadaDiretorio = Directory.GetFiles(diretorio).ToList();
                    foreach (var arquivoEncontrado in listaDeArquivosEmCadaDiretorio)
                    {
                        listaDeArquivosTxtRajadas.Add(arquivoEncontrado);
                    }
                }

                foreach (var arquivoTxtRajada in listaDeArquivosTxtRajadas)
                {
                    FileInfo informacaoDoArquivo = new FileInfo(arquivoTxtRajada);
                    String nomeArquivoRajadaTxt = informacaoDoArquivo.Name;

                    // ** Valida se o nome do diretório é maior que 10 antes de fazer o substring ** //
                    if (nomeArquivoRajadaTxt.Length > 10)
                    {
                        String parteDoNomeDoArquivo = nomeArquivoRajadaTxt.Substring(0, 11);

                        if (parteDoNomeDoArquivo == nomeDoArquivo)
                        {
                            String diretorioRajadaProcessada = "";
                            diretorioRajadaProcessada = caminhoRajadasProcessadas + "\\" + nomeArquivoRajadaTxt;


                            if (File.Exists(diretorioRajadaProcessada))
                            {

                            }
                            else
                            {
                                string[] arquivoTXT = File.ReadAllLines(arquivoTxtRajada);
                                foreach (var linha in arquivoTXT)
                                {
                                    if (linha.Substring(0, 1).Equals("1"))
                                    {
                                        quantidadeDeRegistros = quantidadeDeRegistros + 1;
                                    }
                                }
                            }
                        }
                    }
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            return quantidadeDeRegistros;
        }

        public List<String> retornaQuantidadeArquivosEncontrados(String caminhoArquivoTXT, String nomeDoArquivo)
        {
            List<String> listaDeArquivosEncontrados = new List<String>();

            var listaDeArquivosTxtRajadas = new List<String>();

            var listaDeDiretorios = new List<String>();

            var listaDeArquivosEmCadaDiretorio = new List<String>();

            try
            {
                listaDeDiretorios = Directory.GetDirectories(caminhoArquivoTXT).ToList();
                listaDeDiretorios.Add(caminhoArquivoTXT);

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

                String dataAtual = ano + mes + dia;

                foreach (var diretorio in listaDeDiretorios)
                {
                    // ** Recupera a quantidade de caracteres do caminho do diretório ** //
                    int qtdCaracteres = diretorio.Length;

                    // ** Valida se o nome do diretório é maior que 7 antes de fazer o substring ** //
                    if (qtdCaracteres > 7)
                    {
                        // ** Pega o nome da pasta ** //
                        String diretorioAjustado = diretorio.Substring(qtdCaracteres - 8);

                        if (diretorioAjustado == dataAtual)
                        {
                            listaDeArquivosEmCadaDiretorio = Directory.GetFiles(diretorio).ToList();
                            foreach (var arquivoEncontrado in listaDeArquivosEmCadaDiretorio)
                            {
                                listaDeArquivosTxtRajadas.Add(arquivoEncontrado);
                            }
                        }
                    }
                }

                foreach (var arquivoTxtRajada in listaDeArquivosTxtRajadas)
                {
                    FileInfo informacaoDoArquivo = new FileInfo(arquivoTxtRajada);
                    String nomeArquivoRajadaTxt = informacaoDoArquivo.Name;

                    // ** Valida se o nome do diretório é maior que 10 antes de fazer o substring ** //
                    if (nomeArquivoRajadaTxt.Length > 10)
                    {
                        String parteDoNomeDoArquivo = nomeArquivoRajadaTxt.Substring(0, 11);

                        if (parteDoNomeDoArquivo == nomeDoArquivo)
                        {
                            // ** Retorna a quantidade de caracteres do nome do arquivo encontrado ** //
                            int qtdCaracteresArquivoEncontrado = nomeArquivoRajadaTxt.Length;

                            // ** Extrai do nome do arquivo o horário em que ele foi enviado ** //
                            String horaDoRecebimento = nomeArquivoRajadaTxt.Substring(qtdCaracteresArquivoEncontrado - 10, 4);

                            // ** Formata o horário que o arquivo foi enviado ** //
                            String horaDoRecebimentoFormatada = horaDoRecebimento.Insert(2, ":");

                            // ** Adiciona o arquivo a lista ** //
                            listaDeArquivosEncontrados.Add("Rajada das " + horaDoRecebimentoFormatada + "       ====>>       Arquivo:  " + nomeArquivoRajadaTxt);
                        }
                    }
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            return listaDeArquivosEncontrados;
        }

        public Boolean ExcluirArquivosProcessadosAntigos(String caminhoRajadasProcessadas)
        {
            var listaDeArquivosTxtRajadas = new List<String>();

            var listaDeDiretorios = new List<String>();

            var listaDeArquivosEmCadaDiretorio = new List<String>();

            try
            {
                listaDeDiretorios = Directory.GetDirectories(caminhoRajadasProcessadas).ToList();
                listaDeDiretorios.Add(caminhoRajadasProcessadas);

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

                String dataAtual = ano + mes + dia;

                foreach (var diretorio in listaDeDiretorios)
                {
                    listaDeArquivosEmCadaDiretorio = Directory.GetFiles(diretorio).ToList();
                    foreach (var arquivoEncontrado in listaDeArquivosEmCadaDiretorio)
                    {
                        listaDeArquivosTxtRajadas.Add(arquivoEncontrado);
                    }
                }

                foreach (var arquivoTxtRajada in listaDeArquivosTxtRajadas)
                {
                    FileInfo informacaoDoArquivo = new FileInfo(arquivoTxtRajada);
                    String nomeArquivoRajadaTxt = informacaoDoArquivo.Name;

                    // ** Valida se o nome do diretório é maior que 10 antes de fazer o substring ** //
                    if (nomeArquivoRajadaTxt.Length > 18)
                    {
                        String parteDoNomeDoArquivo = nomeArquivoRajadaTxt.Substring(nomeArquivoRajadaTxt.Length - 18, 8);

                        if (parteDoNomeDoArquivo != dataAtual)
                        {
                            // -- ** Exclui o arquivo do diretório de origem caso o sistema esteja parametrizado para isso -- ** //
                            File.Delete(arquivoTxtRajada);
                            // -- ** Exclui o arquivo do diretório de origem caso o sistema esteja parametrizado para isso -- ** //
                        
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: " + e.Message);
            }

            return true;
        }

    }
}
